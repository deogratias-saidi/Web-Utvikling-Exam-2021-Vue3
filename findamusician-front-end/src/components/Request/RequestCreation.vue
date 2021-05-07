<template>
<form class="row g-3" @submit.prevent="postRequest">
    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label" required >Navn</label>
      <input
        type="text"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="Ola Nordmann"
        v-model="newRequest.UserName"
      />
    </div>
    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label" required>Telefon Nummer</label>
      <input
        type="text"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="+47 12345678"
        v-model="newRequest.PhoneNumber"
      />
    </div>
    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label">E-post</label>
      <input
        type="email"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="Ola.nordmann@gmail.com"
        v-model="newRequest.EmailAddress"
      />
    </div>
    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label">Adresse</label>
      <input
        type="text"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="Karl Johans gate 1"
        v-model="newRequest.Address"
      />
    </div>

    <div class="row d-flex">
      <div class="mb-3 col-4">
        <label for="exampleFormControlInput1" class="form-label"
          >Postnummer</label
        >
        <input
          type="text"
          class="form-control"
          id="exampleFormControlInput1"
          placeholder="0000"
          v-model="newRequest.PostNumber"
        />
      </div>
      <div class="mb-3 col-3">
        <label for="exampleFormControlInput1" class="form-label">Poststed</label>
        <input
          type="text"
          class="form-control"
          id="exampleFormControlInput1"
          placeholder="Oslo"
          v-model="newRequest.PostalArea"
        />
      </div>
    </div>

    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label">Budsjett</label>
      <input
        type="text"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="NOK"
        v-model="newRequest.Budget"
      />
    </div>

    <div class="mb-3">
      <label for="exampleFormControlTextarea1" class="form-label"
        >Henvedelse</label
      >
      <textarea
        class="form-control"
        id="exampleFormControlTextarea1"
        rows="3"
        placeholder="Gi en kort beskrivelse av hva din henvendelse gjelder..."
        v-model="newRequest.RequestDetails"
      ></textarea>
    </div>
    <button type="submit" class="btn btn-primary">Send</button>
</form>
    
  
</template>

<script>

import axios from 'axios'
import { reactive } from '@vue/reactivity'
import {useRouter } from 'vue-router'
export default {
    
    setup(){
        const router = useRouter() // for å sende brukere til en annet sted etter at du har trykker send
        
        const newRequest = reactive({
            UserName:"",
            PhoneNumber: "",
            EmailAddress: "",
            Address:"",
            PostNumber:"",
            PostalArea:"",
            Budget: "",
            RequestDetails: "",
            
        });

        const API_URL = 'https://localhost:5001/api/requests'

        function postRequest(){
          let UserName =  newRequest.UserName
          let PhoneNumber = newRequest.PhoneNumber
          let EmailAddress = newRequest.EmailAddress
          let Address = newRequest.Address
          let PostNumber = newRequest.PostNumber
          let PostalArea = newRequest.PostalArea
          let Budget = newRequest.Budget
          let RequestDetails = newRequest.RequestDetails

          axios.post(API_URL, {
            UserName: UserName,
            PhoneNumber: PhoneNumber,
            EmailAddress: EmailAddress,
            Address: Address,
            PostNumber: PostNumber,
            PostalArea: PostalArea,
            Budget: Budget,
            RequestDetails: RequestDetails
          }).then(() =>{ // Når brukeren har send inn forespørsel, de blir direkt sent til hjemme siden
            router.push({
              name: 'landingpage'
            })
          })
        }

        return{
            newRequest,
            postRequest,
            router
            
        }
    }
}
</script>

<style>
textarea{
  height: 20rem;
}
</style>
