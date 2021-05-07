<template>
  <div  >
    <navigation/>
    <router-view/>
    
  </div>
  
</template>
<script>
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle'
import Navigation from './components/shared/Navigation.vue'


export default {
  components: { Navigation,  },
  
  
}
</script>
<style>


</style>
