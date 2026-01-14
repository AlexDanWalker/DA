<script setup lang="ts">
import { ref } from "vue";
import { AuthService } from "@/services/AuthService";
import { useRouter } from "vue-router";

const name = ref("");
const email = ref("");
const router = useRouter();

function handleRegister() {
  const user = AuthService.register(name.value, email.value);

  if (!user) {
    alert("El usuario ya existe");
    return;
  }

  alert("Usuario registrado correctamente");
  router.push("/");
}
</script>

<template>
  <div>
    <h1>Register</h1>

    <input v-model="name" placeholder="Nombre" />
    <input v-model="email" placeholder="Email" />

    <button @click="handleRegister">Registrar</button>
  </div>
</template>
