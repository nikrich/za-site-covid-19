<template>
    <div id="app">    
          <div class="header">
            <div class="container">
              Covid Visual
            </div>
          </div>     
          <div>
              <router-view></router-view>
          </div>       
    </div>
</template>

<script>
    import NavMenu from './nav-menu'

    export default {
      components: {
        'nav-menu': NavMenu
      },

      data () {
        return {}
      }
    }
</script>

<style>
  .header{
    display: block;
    width: 100%;    
    background-color: #3326ae;
    padding: 1em;
    color: #fff;
    font-size: 24px;
    -webkit-box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14), 0 3px 1px -2px rgba(0,0,0,0.12), 0 1px 5px 0 rgba(0,0,0,0.2);
    box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14), 0 3px 1px -2px rgba(0,0,0,0.12), 0 1px 5px 0 rgba(0,0,0,0.2);
  }
</style>
