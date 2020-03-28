<script>
import { Line } from 'vue-chartjs'

export default {
  extends: Line,
  props: {
    chartdata: {
      type: Array,
      default: null
    },
    chartdataEC: {
      type: Array,
      default: null
    },
    chartdataFS: {
      type: Array,
      default: null
    },
    chartdataGP: {
      type: Array,
      default: null
    },
    chartdataKZN: {
      type: Array,
      default: null
    },
    chartdataLP: {
      type: Array,
      default: null
    },
    chartdataMP: {
      type: Array,
      default: null
    },
    chartdataNC: {
      type: Array,
      default: null
    },
    chartdataNW: {
      type: Array,
      default: null
    },
    chartdataWC: {
      type: Array,
      default: null
    }, 
    chartdataUnknown: {
      type: Array,
      default: null
    },    
    chartlabels: {
      type: Array,
      default: null
    },
    options: {
      type: Object,
      default: null
    }
  },  
  mounted () {
    // All Gradient
    this.gradient = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradient.addColorStop(0, 'rgba(183,28,28 ,0.5)');
    this.gradient.addColorStop(0.5, 'rgba(183,28,28, 0.25)');
    this.gradient.addColorStop(1, 'rgba(183,28,28, 0)');

    // EC Gradient
    this.gradientEC = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientEC.addColorStop(0, 'rgba(74,20,140 ,0.5)');
    this.gradientEC.addColorStop(0.5, 'rgba(74,20,140 ,0.25)');
    this.gradientEC.addColorStop(1, 'rgba(74,20,140 ,0)');

    // FS Gradient
    this.gradientFS = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientFS.addColorStop(0, 'rgba(26,35,126 ,0.5)');
    this.gradientFS.addColorStop(0.5, 'rgba(26,35,126 ,0.25)');
    this.gradientFS.addColorStop(1, 'rgba(26,35,126 ,0)');

    // FS Gradient
    this.gradientGP = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientGP.addColorStop(0, 'rgba(1,87,155 ,0.5)');
    this.gradientGP.addColorStop(0.5, 'rgba(1,87,155 ,0.25)');
    this.gradientGP.addColorStop(1, 'rgba(1,87,155 ,0)');

    // KZN Gradient
    this.gradientKZN = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientKZN.addColorStop(0, 'rgba(0,77,64 ,0.5)');
    this.gradientKZN.addColorStop(0.5, 'rgba(0,77,64 ,0.25)');
    this.gradientKZN.addColorStop(1, 'rgba(0,77,64 ,0)');

    // LP Gradient
    this.gradientLP = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientLP.addColorStop(0, 'rgba(51,105,30 ,0.5)');
    this.gradientLP.addColorStop(0.5, 'rgba(51,105,30 ,0.25)');
    this.gradientLP.addColorStop(1, 'rgba(51,105,30 ,0)');

    // MP Gradient
    this.gradientMP = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientMP.addColorStop(0, 'rgba(245,127,23 ,0.5)');
    this.gradientMP.addColorStop(0.5, 'rgba(245,127,23 ,0.25)');
    this.gradientMP.addColorStop(1, 'rgba(245,127,23 ,0)');

    // NW Gradient
    this.gradientNW = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientNW.addColorStop(0, 'rgba(230,81,0 ,0.5)');
    this.gradientNW.addColorStop(0.5, 'rgba(230,81,0 ,0.25)');
    this.gradientNW.addColorStop(1, 'rgba(230,81,0 ,0)');

    // NC Gradient
    this.gradientNC = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientNC.addColorStop(0, 'rgba(62,39,35 ,0.5)');
    this.gradientNC.addColorStop(0.5, 'rgba(62,39,35 ,0.25)');
    this.gradientNC.addColorStop(1, 'rgba(62,39,35 ,0)');

    // WC Gradient
    this.gradientWC = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientWC.addColorStop(0, 'rgba(0,200,83 ,0.5)');
    this.gradientWC.addColorStop(0.5, 'rgba(0,200,83 ,0.25)');
    this.gradientWC.addColorStop(1, 'rgba(0,200,83 ,0)');

    // Unkown Gradient
    this.gradientUnknown = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradientUnknown.addColorStop(0, 'rgba(33,33,33 ,0.5)');
    this.gradientUnknown.addColorStop(0.5, 'rgba(33,33,33 ,0.25)');
    this.gradientUnknown.addColorStop(1, 'rgba(33,33,33 ,0)');
  
    this.renderChart({
    labels: this.chartlabels,
    datasets: [
      {
        label: 'All',
        backgroundColor: this.gradient,
        data: this.chartdata
      },
      {
        label: 'Eastern Cape',
        backgroundColor: this.gradientEC,
        data: this.chartdataEC
      },
      {
        label: 'Free State',
        backgroundColor: this.gradientFS,
        data: this.chartdataFS
      },
      {
        label: 'Gauteng',
        backgroundColor: this.gradientGP,
        data: this.chartdataGP
      },
      {
        label: 'Kwazulu Natal',
        backgroundColor: this.gradientKZN,
        data: this.chartdataKZN
      },
      {
        label: 'Limpopo',
        backgroundColor: this.gradientLP,
        data: this.chartdataLP
      },
      {
        label: 'Mpumalanga',
        backgroundColor: this.gradientMP,
        data: this.chartdataMP
      },
      {
        label: 'North West',
        backgroundColor: this.gradientNW,
        data: this.chartdataNW
      },
      {
        label: 'Northern Cape',
        backgroundColor: this.gradientNC,
        data: this.chartdataNC
      },
      {
        label: 'Western Cape',
        backgroundColor: this.gradientWC,
        data: this.chartdataWC
      },
      {
        label: 'Unknown',
        backgroundColor: this.gradientUnknown,
        data: this.chartdataUnknown
      }
    ]},
    this.options)
  }
}
</script>

<style>

</style>
