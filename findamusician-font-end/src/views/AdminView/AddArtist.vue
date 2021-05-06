<template>
<admin-navigation/>
  <div class="container pt-3">
      <create-artist/>
  </div>
</template>

<script>
import AdminNavigation from '../../components/Admin/AdminNavigation.vue'
import CreateArtist from "../../components/Admin/CreateArtist.vue"

export default{
  components: { CreateArtist, AdminNavigation }

}
</script>

<style>

</style>