<template>
  <div>
    <div :request="request" class="container d-flex justify-content-center">
      <h1>Forespørsel #{{ request.id }}</h1>
    </div>

    <div class="container p-3">
      <div class="col-md-9 wrapper">
        <div class="description mt-4">
          <h1 class="py-2">BIO</h1>
          <h4>Sender: {{ request.userName }}</h4>
          <p class="artistGenre">
            {{ request.requestDetails }}
          </p>
        </div>

        <button class="btn btn-primary">Kontakt</button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: ["request"],
};
</script>

<style></style>
