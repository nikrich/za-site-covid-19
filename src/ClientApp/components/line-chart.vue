<script>
import { Line } from 'vue-chartjs'

export default {
  extends: Line,
  props: {
    chartdata: {
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
    this.gradient = this.$refs.canvas
    .getContext('2d')
    .createLinearGradient(0, 0, 0, 450);

    this.gradient.addColorStop(0, 'rgba(51,38,174,0.5)');
    this.gradient.addColorStop(0.5, 'rgba(51,38,174, 0.25)');
    this.gradient.addColorStop(1, 'rgba(51,38,174, 0)');
  
    this.renderChart({
    labels: this.chartlabels,
    datasets: [
      {
        label: 'Cumulative confirmed cases per day',
        backgroundColor: this.gradient,
        data: this.chartdata
      }
    ]},
    this.options)
  }
}
</script>

<style>

</style>
