<template>
  <div>
    <admin-navigation />

    <request-items />
  </div>
</template>

<script>
import AdminNavigation from "../../components/Admin/AdminNavigation.vue";
/* import RequestList from "../../components/Request/RequestList.vue"; */
/* import axios from "axios"; */
/* import { reactive, toRefs } from "@vue/reactivity"; */
import RequestItems from "../../components/Admin/RequestItems.vue";

export default {
  components: { AdminNavigation, RequestItems },

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
