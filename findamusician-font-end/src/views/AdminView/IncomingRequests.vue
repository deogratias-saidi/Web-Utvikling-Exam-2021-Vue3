<template>
  <admin-navigation />
  <!-- <div class="container pt-3">
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
            <request-list
              :requests="requests"
              v-on:delete-request="deleteRequest($event)"
              
            />
          </tbody>
        </table>
      </div>
    </div>
  </div> -->
<request-items/>

  
</template>

<script>
import AdminNavigation from "../../components/Admin/AdminNavigation.vue";
/* import RequestList from "../../components/Request/RequestList.vue"; */
/* import axios from "axios"; */
/* import { reactive, toRefs } from "@vue/reactivity"; */
import RequestItems from "../../components/Admin/RequestItems.vue"

export default {
  components: { AdminNavigation, RequestItems  },

  /* setup() {
    const requestsList = reactive({ requests: [] });
    

    axios.get("https://localhost:5001/api/requests").then((res) => {
      requestsList.requests = res.data;
    });

    



    return {
      RequestList,
      ...toRefs(requestsList),
    };
  }, */

  /* data(){
    return {
      requests: []
    }

  },
  async created(){
      const result = await axios.get(`https://localhost:5001/api/requests/`)
      const request = result.data
      this.requests = request;
    },

  methods: {
    async deleteRequest(){
      const result = await delete(`https://localhost:5001/api/requests/`)
      this.requests = result.data
    }
  } */
};
</script>

<style></style>
