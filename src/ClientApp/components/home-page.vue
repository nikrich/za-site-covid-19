<template>
  <div>       
    <cases-datablocks></cases-datablocks>   
    <cases-chart></cases-chart>    
  </div>
</template>

<script>
import CasesChart from './cases-chart'
import CasesDataBlocks from './cases-datablocks'

export default {
  components: {
    'cases-chart': CasesChart,
    'cases-datablocks': CasesDataBlocks
  },
  data () {
    return {}
  }
}
</script>

<style>

</style>
