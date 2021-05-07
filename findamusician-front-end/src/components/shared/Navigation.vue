<template>
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
    <div class="container-fluid">
      <routerLink class="navbar-brand " :to="'/'" href="#"
        ><i class="bx bxs-binoculars logo-image"></i>
        </routerLink
      >
      <button
        class="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#navbarSupportedContent"
        aria-controls="navbarSupportedContent"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item">
            <router-link class="nav-link active" to="/">HJEM</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link active" to="/request">
              BOOK</router-link
            >
          </li>
          <li class="nav-item">
            <router-link class="nav-link active" to="/admin/incoming-request">
              admin</router-link
            >
          </li>
        </ul>
      </div>
    </div>
  </nav>
</template>

<style scoped>
.logo-image {
  font-size: 3rem;
}
</style>
