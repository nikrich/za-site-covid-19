<template>
  <div class="cases--line-chart mt-4">
    <div class="container">
      <div class="row">
        <div class="col-sm pt-4">
          <h3>Provincial Statistics</h3>
        </div>
      </div>      
    </div>
    <div class="container">      
      <div class="row">
        <div class="col-sm-8 province-chart">
          <line-chart
            v-if="loaded"
            :chartdata="chartdata"
            :chartdataEC="chartdataEC"
            :chartdataFS="chartdataFS"
            :chartdataGP="chartdataGP"
            :chartdataKZN="chartdataKZN"
            :chartdataLP="chartdataLP"
            :chartdataMP="chartdataMP"
            :chartdataNC="chartdataNC"
            :chartdataNW="chartdataNW"
            :chartdataWC="chartdataWC"
            :chartdataUnknown="chartdataUnknown"
            :chartlabels="labels"
            :options="options"
            class="p-5"/>
          </div>
          <div class="col-sm-4 p-4">
            <div class="table-responsive">
              <table class="table">
                <tr>
                  <th>Eastern Cape</th>
                  <td>{{chartdataEC[chartdataEC.length - 1]}}</td>
                </tr>
                <tr>
                  <th>Free State</th>
                  <td>{{chartdataFS[chartdataFS.length - 1]}}</td>
                </tr>
                <tr>
                  <th>Gauteng</th>
                  <td>{{chartdataGP[chartdataGP.length - 1]}}</td>
                </tr>
                <tr>
                  <th>Kwazulu Natal</th>
                  <td>{{chartdataKZN[chartdataKZN.length - 1]}}</td>
                </tr>
                <tr>
                  <th>Limpopo</th>
                  <td>{{chartdataLP[chartdataLP.length - 1]}}</td>
                </tr>
                <tr>
                  <th>Mpumalanga</th>
                  <td>{{chartdataMP[chartdataMP.length - 1]}}</td>
                </tr>
                <tr>
                  <th>North West</th>
                  <td>{{chartdataNW[chartdataNW.length - 1]}}</td>
                </tr>
                <tr>
                  <th>Northern Cape</th>
                  <td>{{chartdataNC[chartdataNC.length - 1]}}</td>
                </tr>
                <tr>
                  <th>Western Cape</th>
                  <td>{{chartdataWC[chartdataWC.length - 1]}}</td>
                </tr>
              </table>
            </div>
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
    chartdataEC: [],
    chartdataFS: [],
    chartdataGP: [],
    chartdataKZN: [],
    chartdataLP: [],
    chartdataMP: [],
    chartdataNC: [],
    chartdataNW: [],
    chartdataWC: [],
    chartdataUnknown: [],
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
      let responseAll = await this.$http.get(`https://covidvisual.com/api/cases/getaggregateall`);

      this.chartdata = response.data.map(x => x.casesTotal);
      this.chartdataEC = responseAll.data.map(x => x.easternCape);
      this.chartdataFS = responseAll.data.map(x => x.freeState);
      this.chartdataGP = responseAll.data.map(x => x.gauteng);
      this.chartdataKZN = responseAll.data.map(x => x.kwazuluNatal);
      this.chartdataLP = responseAll.data.map(x => x.limpopo);
      this.chartdataMP = responseAll.data.map(x => x.mpumalanga);
      this.chartdataNC = responseAll.data.map(x => x.northernCape);
      this.chartdataNW = responseAll.data.map(x => x.northWest);
      this.chartdataWC = responseAll.data.map(x => x.westernCape);
      this.chartdataUnknown = responseAll.data.map(x => x.unknown);

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

  .province-chart .p-5{
    padding: 3em 0 0 0 !important;
  }
</style>