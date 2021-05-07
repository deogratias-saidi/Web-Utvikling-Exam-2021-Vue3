<template>
  <div>
    <div :request="request" class="container d-flex justify-content-center">
      <h1>Forespørsel #{{ request.id }}</h1>
    </div>

    <div class="container p-3">
      <div class="col-md-9 wrapper">
        <div class="description mt-4">
          <h1 class="py-2">BIO</h1>
          <h2>Sender: {{ request.userName }}</h2>
          <h5>Telefon Nummber: {{ request.phoneNumber }}</h5>
          <h5>Budsjett: {{ request.budget }} kr-,</h5>
          <h5>
            Adressen: {{ request.address }}, {{ request.postNumber }}
            {{ request.postalArea }}.
          </h5>
          <h5>Dato: {{ dateFilter(request.dateCreated) }}</h5>
          <h5>Budsjett: {{ request.budget }} kr-,</h5>

          <p class="py-3">
            {{ request.requestDetails }}
          </p>
        </div>

        <button class="btn btn-primary">Kontakt</button>
      </div>
    </div>
  </div>
</template>

<script>
import moment from "moment";
export default {
  props: ["request"],
  methods: {
    dateFilter(dateCreated) { 
      return moment(dateCreated).format("DD/MM/YYYY");
    },
  },
  
};
</script>

<style></style>
