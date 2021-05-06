<template>
  <tr>
    <td>{{request.id}}</td>
    <td>{{ request.userName }}</td>
    <td>{{ dateFilter(request.dateCreated) }}</td>
    <td>NOK {{ request.budget }}</td>
    <td class="d-flex justify-content-center gap-3">
      <router-link class="btn btn-primary" :to="`/admin/incoming-request/${request.id}`"><i class='bx bx-show' ></i></router-link>
      <div class="btn btn-danger"  v-on:click="$emits('delete-request', request.id)" ><i class='bx bx-trash' ></i></div>
    </td>
    
    
    
  </tr>

 
</template>

<script>

import moment from 'moment'
export default {
  props: ["request"],
  
  methods: {
    dateFilter(dateCreated){
        return moment(dateCreated).format('DD/MM/YYYY')
    }
  }
}
  

</script>

<style>



</style>
