<template>
  <div class="container">
    <admin-navigation />

    <div class="container">
      <div class="table-responsive">
        <table
          class="table table-hover text-center table-hover mb-0 table-dark"
        >
          <thead>
            <tr>
              <th>Id</th>
              <th>Artist Navn</th>
              <th>Kontakt</th>
              <th>Pris</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="artist in artists" :key="artist.id">
              <td>{{ artist.id }}</td>
              <td>{{ artist.artistName }}</td>
              <td>{{ artist.contact }}</td>
              <td>NOK {{ artist.price }}</td>
              <td class="d-flex justify-content-center gap-3">
                <router-link
                  class="btn btn-primary"
                  :to="`/artists/${artist.id}`"
                  ><i class="bx bx-show"></i
                ></router-link>
                <router-link
                  class="btn btn-primary mx-2"
                  :to="{name: 'edit', params:{id:artist.id}}"
                  ><i class="bx bx-edit-alt"></i
                ></router-link>
                <div
                  class="btn btn-danger"
                  @click.prevent="deleteArtist(artist.id)"
                >
                  <i class="bx bx-trash"></i>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
      
  </div>
</template>

<script>
import AdminNavigation from "../../components/Admin/AdminNavigation.vue";

import axios from "axios";
import { onMounted, ref } from "vue";

export default {
  components: { AdminNavigation,  },
  setup() {
    const artists = ref([]);

    

    onMounted(() => {
      axios.get(`https://localhost:5001/api/artists`).then((respose) => {
        artists.value = respose.data;
      });
    });

    function deleteArtist(id) {
      axios.delete(`https://localhost:5001/api/artists/${id}`).then(() => {
        let selected = this.artists.map((artists) => artists.id).indexOf(id);
        this.artists.splice(selected, 1);
      }).catch((error) => {
          console.log(error);
        });
    }

    return { artists, deleteArtist };
  },
};
</script>

<style></style>
