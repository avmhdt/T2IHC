<template>
  <nav>
    <Header />
    <button>Visualizar notificações</button>
    <router-link to="/novo-estagio">
      <button>Cadastrar estágio</button></router-link
    >
  </nav>
</template>

<script>
import Header from '@/components/Header.vue'
export default {
  name: 'Sidebar',
  props: {},
  data () {
    return {}
  },
  components: { Header },
  methods: {},
  created () {}
}
</script>

<style>
nav {
  display: flex;
  flex-direction: column;
  max-width: 200px;
  background-color: #bdbfc1;
  height: 100vh;
  /* top: 0; */
  /* position: fixed; */
  /* left: 0; */
  /* display: block; */
}

nav button {
  margin-top: 20px;
}
</style>
