<template>
  <see-request-item 
  v-bind:request="request"
  
  
  />
</template>

<script>
import axios from 'axios'
import SeeRequestItem from '../../components/Request/SeeRequestItem.vue'
export default {
  components: { SeeRequestItem },

  data(){
      return{
          request : {}
      }
  },

  async created(){
      const result = await axios.get(`https://localhost:5001/api/requests/${this.$route.params.id}`)
      const request = result.data
      this.request = request
  },
  
}
</script>

<style>

</style>