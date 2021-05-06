<template>
  <admin-navigation />
  <div class="container-fluid">
    <div class="row">
      <div class="col-md-1"></div>
      <div class="col-md-4">
        <table class="table table-hover table-hover mb-0 table-dark">
          <thead>
            <tr>
              <th> Artist ID</th>
              <th>Artist Navn</th>
              
            </tr>
          </thead>
          <tbody>
            <tr v-for="artist in artists" :key="artist.id">
              <td>{{ artist.id }}</td>
              <td>{{ artist.artistName }}</td>
              
            </tr>
          </tbody>
        </table>
      </div>
      <div class="col-md-5">
        <div class="row d-flex">
          <div class="mb-3">
            <label for="exampleFormControlInput1" class="form-label">Artist Id</label>
            <input
              type="text"
              class="form-control"
              id="exampleFormControlInput1"
              placeholder="0000"
              v-model="id"
            />
          </div>
          <div class="mb-3 ">
            <label for="exampleFormControlInput1" class="form-label"></label>
            <button @click="getArtistById" class="btn btn-primary">Hent Artist</button>
          </div>
        </div>
        <div class="mb-3">
          <label for="exampleFormControlInput1" class="form-label" required
            >Navn</label
          >
          <input
            type="text"
            class="form-control"
            id="exampleFormControlInput1"
            placeholder="Astrid S"
            v-model="artistName"
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
            placeholder="Astrids@findamusician.no"
            v-model="contact"
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
            v-model="price"
          />
        </div>
        <div class="mb-3 image-model">
          <label for="exampleFormControlInput1" class="form-label"
            >Image</label
          >
          <input
            type="number"
            class="form-control"
            id="exampleFormControlInput1"
            placeholder="50000"
            v-model="image"
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
            v-model="description"
          ></textarea>
        </div>
        <button @click="changeArtist" class="btn btn-primary">Lagre endring</button>
      </div>
    </div>
  </div>
</template>

<script>
import AdminNavigation from "../../components/Admin/AdminNavigation.vue";
import { reactive, toRefs } from 'vue'
import axios from 'axios'
export default {
    components: {AdminNavigation},
    setup() {

        const artist = reactive( { id: "", artistName: "", contact: "", description: "", price: "", image: ""} );
        const artistList = reactive ({artists: []})

        
        axios.get("https://localhost:5001/api/artists")
        .then(res => {
          artistList.artists = res.data
        })

        const getArtistById = () => {
            axios(`https://localhost:5001/api/artists/${artist.id}`)
                .then( response => {                     
                    artist.artistName = response.data.artistName;
                    artist.contact = response.data.contact;
                    artist.price = response.data.price;
                    artist.description = response.data.description;
                    artist.image = response.data.image;
                    console.log( response.data );
                })
        }

        const changeArtist = async () => {
            const movieToEdit = { 
                id: parseInt( artist.id ),
                artistName: artist.artistName,
                contact: artist.contact,
                price: parseInt( artist.price ),
                description: artist.description,
                image: artist.image
            }

          await axios.put( "https://localhost:5001/api/artists/", movieToEdit )
                .then( response => {
                    console.log( response.data );
                })            
        }

        return { 
            getArtistById,
            ...toRefs( artist ),
            ...toRefs(artistList),
            changeArtist 
        }

    },
}
</script>


<style>
.image-model{
    display: none;
}
</style>
