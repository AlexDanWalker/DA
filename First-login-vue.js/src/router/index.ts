import { createRouter, createWebHistory } from "vue-router";
import LoginVue from "@/views/LoginVue.vue";

const routes = [
  { path: "/", component: LoginVue },
  {
    path: "/register",
    component: () => import("@/views/Register.vue")
  }
];

export const router = createRouter({
  history: createWebHistory(),
  routes
});
