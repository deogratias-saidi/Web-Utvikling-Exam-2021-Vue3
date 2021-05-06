<template>
    <genres-item
        v-for="genre in genres" :key="genre.id"
        :genreName="genre.genreName"
        :genre="genre"
    />
</template>

<script>
import GenresItem from "./GenresItem.vue"

export default {
  components: { GenresItem },
  props:['genres']
}
</script>

<style>

</style>