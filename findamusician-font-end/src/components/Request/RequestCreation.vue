<template>
    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label" required >Navn</label>
      <input
        type="text"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="Ola Nordmann"
        v-model="UserName"
      />
    </div>
    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label" required>Telefon Nummer</label>
      <input
        type="text"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="+47 12345678"
        v-model="PhoneNumber"
      />
    </div>
    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label">E-post</label>
      <input
        type="email"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="Ola.nordmann@gmail.com"
        v-model="EmailAddress"
      />
    </div>
    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label">Adresse</label>
      <input
        type="text"
        class="form-control"
        id="exampleFormControlInput1"
        placeholder="Karl Johans gate 1"
        v-model="Address"
      />
    </div>

    <div class="row d-flex">
      <div class="mb-3 col-6">
        <label for="exampleFormControlInput1" class="form-label"
          >Postnummer</label
        >
        <input
          type="text"
          class="form-control"
          id="exampleFormControlInput1"
          placeholder="0000"
          v-model="PostNumber"
        />
      </div>
      <div class="mb-3 col-6">
        <label for="exampleFormControlInput1" class="form-label">Poststed</label>
        <input
          type="text"
          class="form-control"
          id="exampleFormControlInput1"
          placeholder="Oslo"
          v-model="PostalArea"
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
        v-model="Budget"
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
        v-model="RequestDetails"
      ></textarea>
    </div>
    <button @click="postRequest" class="btn btn-primary">Send</button>
    
  
</template>

<script>

import axios from 'axios'
import { reactive, toRefs } from '@vue/reactivity'

export default {
    
    setup(){
        
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

        const postRequest = () => {
            axios.post(API_URL, newRequest)
            .then((res) => {
                res.data;
            })
        }

        return{
            ...toRefs(newRequest),
            postRequest,
            
        }
    }
}
</script>

<style>

</style>
