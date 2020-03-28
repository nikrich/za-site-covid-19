<template>
  <div  class="container">
    <div class="row justify-content-md-center">
      <div class="col mt-3">
        <data-block
          v-if="loaded"
          title="Total Cases"
          :figure="figureCases"/>
      </div>
      <div class="col mt-3">
        <data-block
          v-if="loaded"
          title="Total Recoveries"
          :figure="figureRecoveries"/>
      </div>
      <div class="col mt-3">
        <data-block
          v-if="loaded"
          title="Total Deaths"
          :figure="figureDeaths"/>
      </div>      
      <div class="col  mt-3">
        <data-block
          v-if="loaded"
          title="Avg Age of Cases"
          :figure="figureAge"/>
      </div>
    </div>
  </div>
</template>

<script>
import DataBlock from './data-block.vue'

export default {
  name: 'CasesDataBlocks', 
  components: {  
    'data-block': DataBlock
  },
  data: () => ({
    loaded: false, 
    figureCases: '0',
    figureDeaths: '0',
    figureAge: '0',
    figureRecoveries: '0'
  }),
  methods: {
    async loadTotalCases () {
      let response = await this.$http.get(`https://covidvisual.com/api/cases/getcount`);
      this.figureCases = response.data.casesTotal;
    },
    async loadTotalDeaths () {
      let response = await this.$http.get(`https://covidvisual.com/api/deaths/getcount`);
      this.figureDeaths = response.data.casesTotal;
    },
    async loadAvgAge() {
      let response = await this.$http.get(`https://covidvisual.com/api/cases/getavgage`);
      this.figureAge = response.data.age;
    },
    async loadRecoveries() {
      let response = await this.$http.get(`https://covidvisual.com/api/tests/getrecovered`);
      this.figureRecoveries = response.data.casesTotal;
    }
  },
  async mounted () {
    this.loaded = false
    try {
      await this.loadTotalCases();   
      await this.loadTotalDeaths();   
      await this.loadAvgAge();   
      await this.loadRecoveries();   
      
      this.loaded = true;
    } catch (e) {
      console.error(e)
    }
  }
}
</script>