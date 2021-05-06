<template>
    <div class="card image">
        <img class="image-responsive" :src="`https://localhost:5001/images/${image}`" alt="Bricks">
        <div class="image__overlay  image__overlay--primary">
            <div class="image__title">{{artistName}} + {{id}}</div>
        </div>
    </div>
</template>

<script>
export default {

    props:{
        id: Number,
        artistName: String,
        image: String,
    }

}
</script>
<style>


.card{
  border: none;
  padding: 0;
  height: 14rem;
  width: 16rem;

}

.image img{
  height: 14rem;
  width: 16rem;
}

.image__overlay {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 14rem;
  background: rgba(0, 0, 0, 0.6);
  color: #ffffff;
  font-family: 'Quicksand', sans-serif;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  opacity: 0;
  transition: opacity 0.25s;
}

.image__overlay--blur {
  backdrop-filter: blur(5px);
}



.image__overlay > * {
  transform: translateY(20px);
  transition: transform 0.25s;
}

.image__overlay:hover {
  opacity: 1;
}

.image__overlay:hover > * {
  transform: translateY(0);
}

.image__title {
  font-size: 1.5em;
  font-weight: bold;
}

/* Artist Page description */



.artist-image img{
  height: 20rem;
  width: 20rem;
}

.artist-description{
  background-color: red;
  height: 20rem;
  width: 20rem;
}

</style>



