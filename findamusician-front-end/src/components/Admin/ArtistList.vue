<template>
  <div>
    <artist-item
      v-for="artist in artists"
      :key="artist.id"
      :id="artist.id"
      :artistName="artist.artistName"
      :price="artist.price"
      :contact="artist.contact"
      :artist="artist"
    />
  </div>
</template>

<script>
import ArtistItem from "./ArtistItem.vue";
export default {
  components: { ArtistItem },

  props: ["artists"],
};
</script>

<style>
</style>