<template>
  <div class="container">
    <admin-navigation></admin-navigation>

    <from class="row-3">
      <div class="mb-3">
        <label for="exampleFormControlInput1" class="form-label" required
          >Artist Navn</label
        >
        <input
          type="text"
          class="form-control"
          id="exampleFormControlInput1"
          placeholder="Ola Nordmann"
          v-model="ArtistName"
        />
      </div>
      <div class="mb-3">
        <label for="exampleFormControlInput1" class="form-label" required
          >Kontakt Informasjon</label
        >
        <input
          type="text"
          class="form-control"
          id="exampleFormControlInput1"
          placeholder="Kontakt"
          v-model="Contact"
        />
      </div>
      <div class="mb-3">
        <label for="exampleFormControlInput1" class="form-label" required
          >Sjanger</label
        >
        <input
          type="text"
          class="form-control"
          id="exampleFormControlInput1"
          placeholder="Sjanger"
          v-model="Genre"
        />
      </div>

      <div class="mb-3">
        <label for="exampleFormControlInput1" class="form-label"
          >Pris Per Time</label
        >
        <input
          type="number"
          class="form-control"
          id="exampleFormControlInput1"
          placeholder="50000"
          v-model="Price"
        />
      </div>
      <div class="mb-3">
        <label for="exampleFormControlInput1" class="form-label"
          >Biograffi</label
        >
        <textarea
          type="number"
          class="form-control"
          id="exampleFormControlInput1"
          placeholder="Bio"
          v-model="Description"
        ></textarea>
      </div>

      <div class="form-group pb-3">
        <label for="formFile" lass="form-label"></label><br />
        <input
          @change="setImage"
          type="file"
          class="form-control"
          id="formFile"
        />
      </div>

      <button @click.prevent="postArtist" class="btn btn-primary">
        Legg til Artist
      </button>
    </from>
  </div>
</template>


<script>
import axios from "axios";
import { reactive, toRefs } from "@vue/reactivity";
import { useRouter } from "vue-router";

export default {
  components: {},
  setup() {
    const artistInput = reactive({
      ArtistName: "",
      Contact: "",
      Price: "",
      Genre: "",
      Image: "",
      Description: "",
    });

    const router = useRouter();

    const imageObject = new FormData();
    const setImage = (e) => {
      imageObject.append("file", e.target.files[0]);
      artistInput.Image = e.target.files[0].name;
    };
    /* =======  =========== */
    const API_URL = "https://localhost:5001/api/";

    const postArtist = () => {
      const newArtist = {
        ArtistName: artistInput.ArtistName,
        Contact: artistInput.Contact,
        Genre: artistInput.Genre,
        Price: parseInt(artistInput.Price),
        Image: artistInput.Image,
        Description: artistInput.Description,
      };

      axios
        .post(API_URL + "artists", newArtist)
        .then(() => {
          axios({
            method: "POST",
            url: "https://localhost:5001/api/artists/UploadImage",
            data: imageObject,
            config: { header: { "Content-type": "multipart/form-data" } },
          });
        })
        .then(() => {
          router.push({
            name: "landingpage",
          });
        });
    };

    /* ==== get Genres in the genre api controller ==== */

    return {
      ...toRefs(artistInput),

      setImage,
      postArtist,
    };
  },
};
</script>

<style></style>
