<template>
    
                        
    <request-item
        v-for="request in requests" :key="request.id"
        
        :id="request.id"
        :userName="request.userName"
        :dateCreated="request.dateCreated"
        :budget="request.budget"
        :request="request"
        v-on:delete-request="$emits('delete-request', $event)"
    />
    
                        
                    
</template>

<script>


import RequestItem from './RequestItem.vue'
export default {
  components: { RequestItem },

    props:["requests"],
    

    

}
</script>

<style>

</style>