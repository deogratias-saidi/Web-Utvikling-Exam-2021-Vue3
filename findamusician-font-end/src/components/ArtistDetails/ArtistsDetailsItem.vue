<template>
  <div class="row">
          
        <div class="col-md-6 pt-3">
            <img class="img-fluid" :src="`https://localhost:5001/images/${artist.image}`" alt="...">
        </div>
        <div class="col-md-3 social-info">
            <h3>
                More Info
            </h3>

            <div class="d-flex align-content-center">
                <i class='bx bxl-spotify'></i>
                <p>Spotify</p>
            </div>
            <div class="d-flex align-content-center">
                <i class='bx bxl-instagram'></i>
                <p>Instragram</p>
            </div>
            <div class="d-flex align-content-center">
                <i class='bx bxl-facebook'></i>
                <p>Facebook</p>
            </div>
            <div class="d-flex align-content-center">
                <i class='bx bxl-twitter' ></i>
                <p>Twitter</p>
            </div>
            <div class="d-flex align-content-center">
                <i class='bx bxl-youtube' ></i>
                <p>Youtube</p>
            </div>
            <div class="d-flex align-content-center">
                <i class='bx bxl-wikipedia'></i>
                <p>Wikipedia</p>
            </div>
        </div>
    </div>
          <div class="col-md-9 wrapper">
              
              <div class="description mt-4">
                  <h1>
                      {{artist.artistName}}
                  </h1>
                  
                  <p>
                      {{artist.description}}
                  </p>
                 

              </div>

              <button class="btn btn-primary">Request</button>
          </div>

          <div class="more-info-bottom">
              <h4>
                  More Info
              </h4>
              <div class="d-flex align-content-center">
                  <i class='bx bxl-spotify'></i>
                  <p>Spotify</p>
              </div>
              <div class="d-flex align-content-center">
                  <i class='bx bxl-instagram'></i>
                  <p>Instragram</p>
              </div>
              <div class="d-flex align-content-center">
                  <i class='bx bxl-facebook'></i>
                  <p>Facebook</p>
              </div>
              <div class="d-flex align-content-center">
                  <i class='bx bxl-twitter' ></i>
                  <p>Twitter</p>
              </div>
              <div class="d-flex align-content-center">
                  <i class='bx bxl-youtube' ></i>
                  <p>Youtube</p>
              </div>
              <div class="d-flex align-content-center">
                  <i class='bx bxl-wikipedia'></i>
                  <p>Wikipedia</p>
              </div>
          </div>
</template>

<script>

export default {
    props:['artist']

    


}
</script>

<style scoped>
.bx{
    font-size: 2rem;
}


.description{
    padding-right: 3rem;

}

.artist-name{
    font-size: 5rem;
}

.more-info-bottom{
    display: none;
}


@media (max-width: 768px){
   .social-info{
       display: none;
   }

   .more-info-bottom{
       display: initial;
   }

   
}
</style>