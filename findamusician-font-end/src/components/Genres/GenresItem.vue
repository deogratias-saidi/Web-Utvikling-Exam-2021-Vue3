<template>
    <div class="form-check">
          <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
          <label class="form-check-label" for="flexCheckDefault">
            {{genre.genreName}}({{genre.id}})
          </label>
      </div>
</template>

<script>
export default {

    props:['genre']

}
</script>

<style>

</style>