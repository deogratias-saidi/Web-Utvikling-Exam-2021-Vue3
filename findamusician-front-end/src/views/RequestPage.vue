<template>

  
  <div class="container">

    <h1>Bookingforespørsel</h1>

    <p>
      Vennligst fyll ut så mye informasjon som mulig i feltene nedenfor <br>
      Trykk på "Send" når du er ferdig.
    </p>

    <request-creation></request-creation>
    
  </div>
</template>

<script>
import RequestCreation from '../components/Request/RequestCreation.vue'
export default {
  components: { RequestCreation },

}
</script>

<style>

</style>
