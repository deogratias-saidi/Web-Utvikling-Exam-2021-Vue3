<template>
    <new-artist-item
        v-for="artist in artistList" :key="artist.id"
        :id="artist.id"
        :artistName="artist.artistName"
        :image="artist.image"
    />
</template>

<script>
import { reactive, toRefs } from '@vue/reactivity'
import NewArtistItem from './NewArtistItem.vue'
import axios from 'axios';

export default {
    components: {NewArtistItem},
    
    setup(){
        const artists = reactive({ artistList:[]});

        axios.get("https://localhost:5001/api/artists")
        .then(res =>{
            artists.artistList = res.data
        })

        return {
            NewArtistItem, ...toRefs(artists)
        }

        
    }
    

    

    

}
</script>

<style>

</style>
NewArtistItem