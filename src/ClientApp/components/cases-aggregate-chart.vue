<template>
  <div class="cases--line-chart mt-4">
    <div  class="container">
      <div class="row justify-content-md-center">
        <div class="col-sm">
          <line-chart
            v-if="loaded"
            :chartdata="chartdata"
            :chartlabels="labels"
            :options="options"
            class="p-5"/>
          </div>
      </div>
    </div>
  </div>
</template>

<script>
import LineChart from './line-chart.vue'

export default {
  name: 'CasesAggregateChart',
  components: { LineChart },
  data: () => ({
    loaded: false,
    chartdata: [],
    labels: [], 
    options: {
      responsive: true,
      responsiveAnimationDuration: 500,
      maintainAspectRatio: false
    }
  }),
  methods: {
    async loadData () {
      let response = await this.$http.get(`https://covidvisual.com/api/cases/getdayaggregate`);

      this.chartdata = response.data.map(x => x.casesTotal);
      this.labels = response.data.map(x => new Date(x.date).toLocaleDateString('en-ZA'));
    }
  },
  async mounted () {
    this.loaded = false
    try {
      await this.loadData();   
      this.loaded = true;
    } catch (e) {
      console.error(e)
    }
  }
}
</script>

<style scoped>
  .cases--line-chart{
    background-color: rgba(51,38,174,0.05);
  }
</style>