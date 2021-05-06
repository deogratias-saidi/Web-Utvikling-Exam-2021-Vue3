<template>
  <div class="container-fluid">
    <div class="search p-4 d-flex justify-content-center">
      <div class="input-container d-flex justify-content-center">
        <input
          type="text"
          placeholder="Søk"
          v-model="artistNameSearchString"
        />
      </div>
    </div>
    <div
      class="row row-cols-6 row-cols-lg-4 gap-1 g-2 g-lg-3 justify-content-center text-center"
    >
      <landing-page-list :artists="filteredFeed" />
    </div>
  </div>
</template>

<script>
import LandingPageList from "../components/LandingPage/LandingPageList.vue";
import axios from "axios";
/* import { reactive, toRefs } from "@vue/reactivity"; */

export default {
  components: { LandingPageList },
  data() {
    return {
      artistNameSearchString: "",
      artists: [],
    };
  },

  mounted() {
    axios
      .get("https://localhost:5001/api/artists")
      .then((response) => {
        this.artists = response.data;
      })
      .catch((error) => console.log(error));
  },

  computed: {
    filteredFeed: function () {
      //  Vi henter artist list også filter vi det opp.
      var artistList = this.artists;
      var artistNameSearchString = this.artistNameSearchString;

      if (!artistNameSearchString) {
        return artistList;
      }
      artistList = artistList.filter(function (artist) {
        if (
          artist.artistName.toLowerCase().indexOf(artistNameSearchString) !== -1
        ) {
          return artist;
        }
      });

      return artistList;
    },
  },
};
</script>

<style>
input:focus,
select:focus,
textarea:focus,
button:focus {
  outline: none;
}

.input-container {
  border-radius: 5px;
  background: #fff;
  padding: 10px;
  width: 60%;
}

.input-container input {
  border: none;
  background: transparent;
  color: #161717;
  padding: 6px 15px;
  font-size: 18px;
  width: 100%;
}

::placeholder {
  /* Chrome, Firefox, Opera, Safari 10.1+ */
  color: #161717;
  opacity: 1; /* Firefox */
}
</style>
