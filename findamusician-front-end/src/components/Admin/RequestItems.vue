<template>
  <div class="container pt-3">
    <div class="container">
      <div class="table-responsive">
        <table
          class="table table-hover text-center table-hover mb-0 table-dark"
        >
          <thead>
            <tr>
              <th>#Id</th>
              <th>Fra</th>
              <th>Dato</th>
              
              <th>Behandle</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="request in requests" :key="request.id">
              <td>{{ request.id }}</td>
              <td>{{ request.userName }}</td>
              <td>{{ dateFilter(request.dateCreated) }}</td>
              
              <td class="d-flex justify-content-center gap-3">
                <router-link
                  class="btn btn-primary"
                  :to="{ name: 'seerequest', params: { id: request.id } }"
                  ><i class="bx bx-show"></i
                ></router-link>
                <div
                  class="btn btn-danger"
                  data-bs-target="#staticBackdrop"
                  v-on:click="deleteRequest(request.id)"
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
</template>

<script>
import axios from "axios";
import moment from "moment";
export default {
  data() {
    return {
      requests: [],
    };
  },
  methods: {
    getRequests() {
      axios.get("https://localhost:5001/api/requests/").then((res) => {
        this.requests = res.data;
      });
    },

    deleteRequest(id) {
      axios.delete(`https://localhost:5001/api/requests/${id}`).then(() => {
        this.getRequests();
      });
    },
    dateFilter(dateCreated) { // Moment gjør dato til mår lesbar måte
      return moment(dateCreated).format("DD/MM/YYYY");
    },
  },
  mounted() {
    this.getRequests();
  },
};
</script>

<style></style>
