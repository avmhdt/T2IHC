<template>
  <router-link v-if="$store.state.typeofUser" to="/">
    <img src="@/assets/logo.png" alt="Logo da UFJF" class="logo" />
  </router-link>
  <router-link v-else to="/Home/Coord">
    <img src="@/assets/logo.png" alt="Logo da UFJF" class="logo" />
  </router-link>

</template>

<script>
export default {
  name: 'Header',
  props: {},
  data () {
    return {}
  },
  components: {},
  methods: {},
  created () {}
}
</script>

<style scoped>
.logo {
  width: 150px;
  display: block;
  left: 0;
  margin-left: 40px;
  margin-top: 40px;
}
</style>
