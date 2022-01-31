<template>
  <div v-if="!$store.state.typeofUser">
    <router-link to="/Home/Coord">
      <img src="@/assets/logo2.png" alt="Logo da UFJF" class="logo1" />
    </router-link>
  </div>
  <div class="header" v-else>
    <router-link to="/">
      <img src="@/assets/logo2.png" alt="Logo da UFJF" class="logo" />
    </router-link>
    <p>Universidade Federal de Juiz de Fora</p>
    <button class="secondary" @click="logout">SAIR</button>
  </div>
</template>

<script>
export default {
  name: 'Header',
  props: {},
  data () {
    return {}
  },
  components: {},
  methods: {
    logout () {
      localStorage.removeItem('knowledge_user')
      this.$router.push('/login')
    }
  },
  created () {}
}
</script>

<style scoped>
.logo {
  width: 65px;
  display: block;
  left: 0;
}

.logo1 {
  width: 90px;
  display: block;
  left: 0;
  margin-left: 80px;
  margin-top: 40px;
}

.header {
  max-width: 100%;
  background-color: rgba(164, 41, 26, 0.9);
  display: flex;
  justify-content: space-between;
  padding-left: 60px;
  padding-right: 60px;
  padding-top: 5px;
  margin-bottom: 50px;
  align-items: center;
}
.header p {
  color: #fff;
  font-size: 18px;
}
</style>
