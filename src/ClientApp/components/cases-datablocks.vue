<template>
  <div  class="container mt-5">
    <div class="row justify-content-md-center">
      <div class="col-sm">
        <data-block
          v-if="loaded"
          title="Total Cases"
          :figure="figureCases"/>
      </div>
      <div class="col-sm">
        <data-block
          v-if="loaded"
          title="Total Deaths"
          :figure="figureDeaths"/>
      </div>
      <div class="col-sm">
        <data-block
          v-if="loaded"
          title="Avg Age af Cases"
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
    figureAge: '0'
  }),
  methods: {
    async loadTotalCases () {
      let response = await this.$http.get(`https://covidvisual.com/api/Cases/getcount`);
      this.figureCases = response.data.casesTotal;
    },
    async loadTotalDeaths () {
      let response = await this.$http.get(`https://covidvisual.com/api/Deaths/getcount`);
      this.figureDeaths = response.data.casesTotal;
    },
    async loadAvgAge() {
      let response = await this.$http.get(`https://covidvisual.com/api/Cases/getcount`);
      this.figureAge = response.data.casesTotal;
    }
  },
  async mounted () {
    this.loaded = false
    try {
      await this.loadTotalCases();   
      this.loaded = true;
    } catch (e) {
      console.error(e)
    }
  }
}
</script>