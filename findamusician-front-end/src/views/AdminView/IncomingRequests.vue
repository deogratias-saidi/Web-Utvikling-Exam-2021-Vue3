<template>
  <div class="container">
    <admin-navigation />

    <request-items />
  </div>
</template>

<script>
import AdminNavigation from "../../components/Admin/AdminNavigation.vue";
import RequestItems from "../../components/Admin/RequestItems.vue";

export default {
  components: { AdminNavigation, RequestItems },

};
</script>

<style></style>
