import { createRouter, createWebHistory } from "vue-router";
import LandingPage from "../views/LandingPage.vue";
import ArtistsPage from "../views/ArtistsPage.vue";
import RequestPage from "../views/RequestPage.vue";
import PageNotFound from "../views/PageNotFound.vue";
import EditArtists from "../views/AdminView/EditArtists.vue";
import ArtistAdmin from "../views/AdminView/ArtistAdmin.vue";
import AddArtist from "../views/AdminView/AddArtist.vue";
import IncomingRequests from "../views/AdminView/IncomingRequests.vue";
import SeeRequests from "../views/AdminView/SeeRequests.vue";

const routes = [
  {
    path: "/artists",
    name: "LandingPage",
    component: LandingPage,
  },
  {
    path: "/",
    redirect: '/artists'
  },
  {
    path: "/artists/:id",
    name: "ArtistsPage",
    component: ArtistsPage,
    
  },
  {
    path: "/request",
    name: "RequestPage",
    component: RequestPage,
  },
  { path: "/:catchAll(.*)", component: PageNotFound },

 

  /* Admin Pages */

  {
    path: "/admin/edit-artists",
    name: "EditArtists",
    component: EditArtists,
  },
  {
    path: "/admin/artist-admin",
    name: "ArtistAdmin",
    component: ArtistAdmin,
  },
  {
    path: "/admin/add-artist",
    name: "AddArtist",
    component: AddArtist,
  },
  {
    path: "/admin/incoming-request",
    name: "IncomingRequest",
    component: IncomingRequests,
  },
  {
    path: "/admin/incoming-request/:id",
    name: "SeeRequests",
    component: SeeRequests,
  },
  
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
