<template>
    <artists-details-item
        :id="artist.id"
        :artistName="artist.artistName"
        :image="artist.image"
        :description="artist.description"
        :artist="artist"
        
    />
</template>

<script>

import ArtistsDetailsItem from './ArtistsDetailsItem.vue';

export default {
  components: { ArtistsDetailsItem },
  props:['artists']
    

}
</script>

<style>

</style>