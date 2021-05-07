<template>
  <div class="container">
    <admin-navigation></admin-navigation>
    <form class="row-3" @submit.prevent="update">
      <div class="mb-3">
        <label for="inputEmail4" class="form-label">Artist Navn</label>
        <input type="text" class="form-control" v-model="artist.artistName" />
      </div>
      <div class="mb-3">
        <label for="inputEmail4" class="form-label">Kontakt</label>
        <input type="text" class="form-control" v-model="artist.contact" />
      </div>
      <div class="mb-3">
        <label for="inputEmail4" class="form-label">Pris per time</label>
        <input type="number" class="form-control" v-model="artist.price" />
      </div>
      <div class="mb-3">
        <label for="inputEmail4" class="form-label">Sjanger</label>
        <input type="text" class="form-control" v-model="artist.genre" />
      </div>
      <div class="mb-3 image-form">
        <label for="inputEmail4" class="form-label ">Bilde</label>
        <input type="text" class="form-control" v-model="artist.image" />
      </div>
      <div class="mb-3">
        <label for="floatingTextarea2">Biograffi</label>
        <textarea
          class="form-control"
          v-model="artist.description"
          placeholder="Leave a comment here"
          id="floatingTextarea2"
          style="height: 15rem"
        ></textarea>
        
      </div>

      <div class="col-12">
        <button type="submit" class="btn btn-primary">Update</button>
      </div>
    </form>
  </div>
</template>

<script>
import AdminNavigation from "../../components/Admin/AdminNavigation.vue";
import { reactive } from "@vue/reactivity";
import { useRouter, useRoute } from "vue-router";
import axios from "axios";
import { onMounted } from "@vue/runtime-core";

export default {
  components: {AdminNavigation},

  setup() {
    const artist = reactive({
      artistName: "",
      contact: "",
      price: "",
      genre: "",
      image: "",
      description: "",
    });

    const router = useRouter();
    const route = useRoute();

    onMounted(async () => {
      await axios
        .get(`https://localhost:5001/api/artists/${route.params.id}`)
        .then((response) => {
          artist.artistName = response.data.artistName;
          artist.contact = response.data.contact;
          artist.price = response.data.price;
          artist.genre = response.data.genre;
          artist.image = response.data.image;
          artist.description = response.data.description;
        });
    });

    function update() {
      let artistName = artist.artistName;
      let contact = artist.contact;
      let price = artist.price;
      let genre = artist.genre;
      let image = artist.image;
      let description = artist.description;

      axios
        .put(`https://localhost:5001/api/artists/${route.params.id}`, {
          artistName: artistName,
          contact: contact,
          price: parseInt(price),
          genre: genre,
          image: image,
          description: description,
        })
        .then(() => {
          router.push({
            name: "artistadmin",
          });
        });
    }

    return { artist, router, route, update };
  },
};
</script>

<style>
.image-form{
  display: none;
}
</style>