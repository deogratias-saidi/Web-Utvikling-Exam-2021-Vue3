<template>
    <landing-page-item
        v-for="artist in artists" :key="artist.id"
        :id="artist.id"
        :artistName="artist.artistName"
        :price="artist.price"
        :image="artist.image"
        :artist="artist"

        
    />
</template>

<script>
import LandingPageItem from "./LandingPageItem.vue";

export default {
  components: { LandingPageItem },
  props: ['artists']
    
}
</script>