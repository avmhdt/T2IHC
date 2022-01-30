<template>
  <div class="home-coord">
    <Sidebar />
    <div>
      <h1>Olá, {{ $store.state.name }}!</h1>
      <div class="search-input">
        <font-awesome-icon icon="search" />
        <input
          type="text"
          name="search"
          placeholder="Procurar por aluno..."
          v-model="search"
          @keyup.enter="searchByName"
        />
      </div>
      <InternsTable :interns="estagios" />
    </div>
  </div>
</template>

<script>
import api from '@/services/api.js'
import Sidebar from '@/components/Sidebar.vue'
import InternsTable from '@/components/InternsTable.vue'

export default {
  name: 'Home',
  props: {},
  data () {
    return {
      search: '',
      estagios: []
    }
  },
  components: { Sidebar, InternsTable },
  methods: {},
  async created () {
    const { data } = await api.get('/api/Estagio/getEstagios')
    this.estagios = data
  }
}
</script>

<style>
.home-coord {
  display: grid;
  grid-template-columns: 15% 85%;
  gap: 30px;
}

.search-input input {
  height: 30px;
  width: 100%;
  padding: 10px 60px;
  box-shadow: 1px 4px 4px 0px rgba(0, 0, 0, 0.03);
  border: 0.5px solid rgba(0, 0, 0, 0.04);
  border-radius: 15px;
  text-align: left;
  outline: none;
  background: #c4c4c4;
}
.search-input {
  position: relative;
  width: 50%;
}

.search-input input::placeholder {
  color: #000;
}

.search-input svg {
  position: absolute;
  left: 0;
  margin-top: 15px;
  margin-left: 20px;
  width: 20px;
}
</style>
