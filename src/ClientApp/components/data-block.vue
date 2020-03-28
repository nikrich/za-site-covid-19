<template>
    <div class="data-block rounded">
      <span class="data-block--title">
        {{title}}
      </span>
      <span class="data-block--figure">
        {{figure}}
      </span>
    </div>
</template>

<script>
export default {
  props: {
    title: {     
      default: ''
    },
    figure: {    
      default: ''
    }
  },  
  data () {
    return {}
  }
}
</script>

<style scoped>
  .data-block {
    border-radius: 1em;
    overflow: hidden;
    -webkit-box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);
    box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);
    padding: 2em;
  }

  .data-block--title{
    text-transform: uppercase;
    color: rgba(51,38,174,0.4);
    display: block;
    text-align: right;
  }

  .data-block--figure{
    text-transform: uppercase;
    color: #000;
    display: block;
    font-size: 32px;
    text-align: right;
  }
</style>
