<template>
  <div class="cases--line-chart mt-3">
    <div  class="container">
      <div class="row">
        <div class="col-sm-12">
          <bar-chart
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
import BarChart from './bar-chart.vue'

export default {
  name: 'CasesChart',
  components: { BarChart },
  data: () => ({
    loaded: false,
    chartdata: [],
    labels: [], 
    options: {
      responsive: true,
      maintainAspectRatio: false
    }
  }),
  methods: {
    async loadData () {
      let response = await this.$http.get(`https://covidvisual.com/api/Cases/getallperday`);

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