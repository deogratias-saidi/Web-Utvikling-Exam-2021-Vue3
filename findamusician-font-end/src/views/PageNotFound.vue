<template>
    <div class="p-5 position-relative d-flex flex-column  align-items-center justify-content-center">
        <h1 >404: FINNER IKKE SIDEN DU LETTET ETTER</h1>
        <router-link :to="'/'">
            <h4>Gå tilbake til hovedsiden</h4>
        </router-link>
    </div>
</template>

<style>
    a{
        text-decoration: none;
    }
</style>