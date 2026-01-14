<script setup lang="ts">
import { ref } from "vue";
import { AuthService } from "@/services/AuthService";
import { useRouter } from "vue-router";

const name = ref("");
const email = ref("");
const router = useRouter();

function handleLogin() {
  const user = AuthService.login(name.value, email.value);

  if (!user) {
    alert("Usuario incorrecto");
    return;
  }

  alert("Bienvenido " + user.name);
}
</script>

<template>
  <div>
    <h1>Login</h1>

    <input v-model="name" placeholder="Nombre" />
    <input v-model="email" placeholder="Email" />

    <button @click="handleLogin">Login</button>

    <p>
      ¿No tienes cuenta?
      <router-link to="/register">Regístrate</router-link>
    </p>
  </div>
</template>
