<template>
  <nav>
    <Header />
    <a href="/Home/Coord" class="link-sidebar">Visualizar notificações</a>
    <a href="/novo-estagio" class="link-sidebar">Cadastrar estágio</a>
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
  max-width: 250px;
  background-color: #bdbfc1;
  height: 100vh;
}

.link-sidebar {
  color: #000;
  text-decoration: none;
  border-bottom: 0.5px solid rgba(0, 0, 0, 0.3);
  padding: 15px;
}

nav a:nth-of-type(2) {
  margin-top: 60px;
}
</style>
