<template>
  <div class="container pt-3">
    <div class="container">
      <div class="table-responsive">
        <table
          class="table table-hover text-center table-hover mb-0 table-dark"
        >
          <thead>
            <tr>
              <th>Id</th>
              <th>Requested By</th>
              <th>Dato</th>
              <th>Total</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="request in requests" :key="request.id">
              <td>{{ request.id }}</td>
              <td>{{ request.userName }}</td>
              <td>{{ dateFilter(request.dateCreated)  }}</td>
              <td>NOK {{ request.budget }}</td>
              <td class="d-flex justify-content-center gap-3">
                <router-link
                  class="btn btn-primary"
                  :to="`/admin/incoming-request/${request.id}`"
                  ><i class="bx bx-show"></i
                ></router-link>
                <div
                  class="btn btn-danger" data-bs-toggle="modal" data-bs-target="#staticBackdrop"
                  
                >
                  <i class="bx bx-trash"></i>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>

  <!-- Modal -->

  <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="staticBackdropLabel">Modal title</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        ...
      </div>
      <div class="modal-footer" v-for="request in requests" :key="request.id">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary" v-on:click="deleteRequest(request.id)" >Understood</button>
      </div>
    </div>
  </div>
</div>


</template>

<script>
import axios from 'axios'
import moment from 'moment'
export default {
    data(){
    return {
      requests: []
    }

  },
  methods: {

    getRequests(){
      axios.get("https://localhost:5001/api/requests/")
      .then((res) => {
        this.requests = res.data
      })
    },

    deleteRequest(id){
      axios.delete(`https://localhost:5001/api/requests/${id}`)
      .then(() => {
        this.getRequests()
      })
    },
    dateFilter(dateCreated){
        return moment(dateCreated).format('DD/MM/YYYY')
    }
    
  },
  mounted(){
    this.getRequests()
  }
};
</script>

<style></style>
