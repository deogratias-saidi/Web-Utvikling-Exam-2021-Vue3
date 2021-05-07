<template>
  <div
    class="row row-cols-6 row-cols-lg-4 gap-1 g-2 g-lg-3 justify-content-center text-center"
  >
    <landing-page-item
      v-for="artist in artists"
      :key="artist.id"
      :id="artist.id"
      :artistName="artist.artistName"
      :price="artist.price"
      :image="artist.image"
      :artist="artist"
    ></landing-page-item>
  </div>
</template>

<script>
import LandingPageItem from "./LandingPageItem.vue";
export default {
  components: { LandingPageItem },
  props: ["artists"],
};
</script>