<template class="body">
  <div class="container-fluid bg-dark">
    <div class="row">
      <div class="col-1"></div>
      <div class="col-md-5">
        <div
          class="col-md top-bar p-2 d-flex align-content-center justify-content-between"
        >
          <router-link :to="'/'" class="back">
            <p class="arrow">&#60;</p>
            <p>Tilbake til artister</p>
          </router-link>
        </div>

        <div class="artist-name py-5 px-2">{{ artist.artistName }}</div>

        <div class="col-md details">
          <div class="col songs">
            <h3>Kontakt info</h3>
            <h5 class="genre">{{ artist.contact }}</h5>
          </div>
          <div class="col songs">
            <h3>Pris</h3>
            <h5 class="genre">NOK {{ artist.price }} per time</h5>
          </div>
          <div class="col songs">
            <h4>Sjanger</h4>
            <p class="genre">{{ artist.genre }}</p>
          </div>
          <div class="col bio">
            <h1>Bio</h1>
            <p>
              {{ artist.description }}
            </p>
          </div>
        </div>
        <router-link :to="'/request'">
          <button class="btn btn-primary">Send en Forespørsel</button>
        </router-link>

        <div class="social m-0">
          <div class="find-more py-3">Finn mer</div>
          <div class="social-link col-md d-flex gap-3">
            <div class="text-center">
              <i class="bx bxl-spotify"></i>
              <p>Spotify</p>
            </div>
            <div class="gap-1 text-center">
              <i class="bx bxl-youtube"></i>
              <p>Youtube</p>
            </div>
            <div class="text-center">
              <i class="bx bxl-instagram"></i>
              <p>Instagram</p>
            </div>
            <div class="text-center">
              <i class="bx bxl-facebook-square"></i>
              <p>Facebook</p>
            </div>
          </div>
        </div>
      </div>
      <div class="col-md p-0">
        <img
          class="artist-image img-fluid vh-100"
          :src="`https://localhost:5001/images/${artist.image}`"
          alt=""
        />
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
import { ref } from "vue";
import { useRoute } from "vue-router";
export default {
  setup() {
    const route = useRoute(); // Vi bruker useRoute() for bringe oss til akkurat denne artist med den akkrat id
    const artist = ref({});

    axios
      .get(`https://localhost:5001/api/artists/${route.params.id}`)
      .then((respose) => {
        artist.value = respose.data;
      });

    return {
      artist,
      route,
    };
  },
};
</script>

<style scoped>
@import url("https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700;800&display=swap");

.container-fluid {
  font-family: "Poppins", sans-serif;
  color: white;
}

a {
  text-decoration: none;
  color: white;
}

.artist-name {
  color: #fff;
  font-size: 5rem;
  font-weight: 700;
}

.bio {
  padding-right: 3rem;
}

.social-link {
  font-family: "Poppins" !important;
  font-size: 1.3rem;
  text-align: center;
}

.artist-name:first-child {
  color: red;
}

.back {
  display: flex;
  gap: 0.5rem;
  align-items: center;
}
.arrow {
  font-size: 2.6rem;
}

.card {
  width: 50%;
  height: 70%;
}

.details {
  display: flex;
  flex-direction: column;
}

@media screen and (max-width: 1240px) {
  .details {
    display: flex;
    flex-direction: column;
    gap: 1.2rem;
  }

  .artist-name {
    font-size: 4rem;
  }
}

@media screen and (max-width: 1200px) {
  .row {
    display: flex;
    flex-direction: column;
    justify-self: start;
  }

  .artist-image {
    height: auto !important;
    width: 100%;
  }

  .social-link {
    font-family: "Poppins" !important;
    font-size: 1.2rem;
    text-align: center;
    display: flex;
    justify-content: start;
  }

  .col-md-5 {
    flex: 0 0 100%;
    width: 100%;
  }
}
</style>
