<template>
    <div id="app">    
          <div class="header">
            <div class="container">             
              <span class="title">Covid Visual</span>  
              <a class="coffee p-3 mt-3 " href="https://ko-fi.com/nikrich" target="_blank">             
                Buy me a coffee
              </a>            
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
    background-color: #fff;     
    -webkit-box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);
    box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);
  }

  .title{
    color: #000;
    font-size: 24px;
    padding: 1em;   
    display: inline-block;
    background-color: #fff;
  }

  .coffee{
    float: right;
    -webkit-box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);
    box-shadow: 0 2px 2px 0 rgba(51,38,174,0.05), 0 3px 1px -2px rgba(51,38,174,0.05), 0 1px 5px 0 rgba(51,38,174,0.05);    
  }

  .coffee:hover{
    text-decoration: none;
  }
</style>
