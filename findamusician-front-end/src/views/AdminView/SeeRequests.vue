<template>
  <see-request-item 
  v-bind:request="request"
  
  
  />
</template>

<script>
import axios from 'axios'
import SeeRequestItem from '../../components/Request/SeeRequestItem.vue'
import { ref } from "vue";
import { useRoute } from "vue-router";
export default {
  components: { SeeRequestItem },

  setup() {
    const route = useRoute(); 
    const request = ref({});

    axios
      .get(`https://localhost:5001/api/requests/${route.params.id}`)
      .then((respose) => {
        request.value = respose.data;
      });

    return {
      request,
      route,
    };
  },
  
}
</script>

<style>

</style>