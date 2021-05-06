<template>
  <div class="container pt-3">
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
              <td>{{ artist.contact}}</td>
              <td>NOK {{ artist.price }}</td>
              <td class="d-flex justify-content-center gap-3">
                <router-link
                  class="btn btn-primary"
                  :to="`/artists/${artist.id}`"
                  ><i class="bx bx-show"></i
                ></router-link>
                <div
                  class="btn btn-danger"
                  v-on:click="deleteArtist(artist.id)"
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
import axios from 'axios'
export default {
    data(){
    return {
      artists: []
    }

  },
  methods: {

    getArtists(){
      axios.get("https://localhost:5001/api/artists/")
      .then((res) => {
        this.artists = res.data
      })
    },

    deleteArtist(id){
      axios.delete(`https://localhost:5001/api/artists/${id}`)
      .then(() => {
        this.getArtists()
        
      })
    },
    
    
  },
  mounted(){
    this.getArtists()
  }
};
</script>

<style></style>
