<template>
  <div>       
   <cases-latest></cases-latest>    
    <cases-datablocks></cases-datablocks>       
    <cases-aggregate-chart></cases-aggregate-chart>
    <cases-chart></cases-chart>
    <about></about>
  </div>
</template>

<script>
import CasesLatest from './cases-latest'
import CasesChart from './cases-chart'
import CasesAggregateChart from './cases-aggregate-chart'
import CasesDataBlocks from './cases-datablocks'
import About from './about'

export default {
  components: {
    'cases-latest': CasesLatest,
    'cases-chart': CasesChart,
    'cases-aggregate-chart': CasesAggregateChart,
    'cases-datablocks': CasesDataBlocks,
    'about': About
  },
  data () {
    return {}
  }
}
</script>

<style>

</style>
