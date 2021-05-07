<template>
  <div class="container">
    <div class="mb-3 d-flex align-content-center  justify-content-center gap-5 p-4 topbar ">
      <router-link to="/admin/incoming-request" >Forespørsel</router-link>
      <router-link to="/admin/editartist">Artistene</router-link>
      <router-link to="/admin/add-artist" >Lag ny Artist</router-link>
    </div>
  </div>
</template>

<script>
export default {

}
</script>

<style scoped>
.topbar{
  background: rgb(70, 67, 67);
  font-size: 1rem;
  border-radius: 21rem;
  
  

}

a{
  text-decoration: none;
  color: #fff;
}

</style>