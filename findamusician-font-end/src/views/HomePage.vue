<template>

    <div class="container-fluid pt-5 m-1">
        <router-link :to="`/artists/${id}`">
            <div class="row row-cols-6 row-cols-lg-4 gap-1 g-2 g-lg-3 justify-content-center  text-center">
                <new-artist-list :artist="artistList" />
            </div>
        
        </router-link>
        
    </div>
  
</template>

<script>
import NewArtistList from '../components/NewArtistList.vue'

export default {
  components: { NewArtistList },
    name: "HomePage",
    props:['artistList'],

}
</script>

<style>

</style>