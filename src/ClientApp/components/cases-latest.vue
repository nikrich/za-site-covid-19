<template>
  <div  class="container">
    <div class="row justify-content-md-center">
      <div class="col col-md-4 mt-4">
        <div class="latest rounded p-5">          
          <span class="latest--figure">
            {{latestFigure.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",")}} new cases
          </span>    
          <span class="latest--date">
            Announced at {{latestDate}}
          </span>      
        </div>
      </div>
      <div class="col col-md-8 mt-4">
        <div class="tests rounded p-5">     
          <span class="tests--figure">
            {{latestTests.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",")}}
          </span>    
          <span class="tests--date">
            TESTS CONDUCTED
          </span>  
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import CasesChart from './cases-chart'

export default {
  name: 'CasesLatest', 
  components: {  
   'cases-chart': CasesChart
  },
  data: () => ({   
    latestDate: null,
    latestFigure: 0,
    latestTests: 0
  }),
  methods: {
    async loadLatest () {
      let response = await this.$http.get(`https://covidvisual.com/api/cases/getlatestupdate`);     
      this.latestFigure = response.data.casesTotal;
      this.latestDate = new Date(response.data.date).toLocaleDateString('en-ZA');
    },
    async loadTests () {
      let response = await this.$http.get(`https://covidvisual.com/api/tests/getall`);   
      this.latestTests = response.data[response.data.length - 1].cmulativeTests
    },
  },
  async mounted () {  
    try {
      await this.loadLatest();    
      await this.loadTests();    
    } catch (e) {
      console.error(e)
    }
  }
}
</script>

<style scoped>
.latest{ 
    padding: 5em;
    -webkit-box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);
    box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);
    background-color: #ff392b;
}

.latest--date{
  display: block;
  text-align: right;
  color: #fff;
}

.latest--figure{
  display: block;
  text-align: right;
  color: #fff;
  font-size: 28px;
  line-height:1;
}

.tests{    
    -webkit-box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);
    box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);
    background-color: #fff;
}

.tests--date{
  display: block;
  text-align: right;
  color: rgba(51,38,174,0.4);
}

.tests--figure{
  display: block;
  text-align: right;
  font-size: 28px;
  line-height:1;
}

</style>