<template>
  <div class="home-coord">
    <Sidebar />
    <div class="content">
      <h1>Olá, {{ $store.state.name }}!</h1>
      <div class="wrapper-home-coord">
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
    const { data } = await api.get('/api/Aluno/GetAlunos')
    this.estagios = data
    console.log(this.estagios)
  }
}
</script>

<style scoped>
.home-coord {
  display: grid;
  grid-template-columns: 300px 0.8fr;
  gap: 70px;
}

.home-coord .content {
  margin-top: 100px;
  max-width: 100vw;
}
.content h1 {
  text-align: center;
  margin-bottom: 40px;
}

.search-input input {
  height: 30px;
  width: 95%;
  padding: 10px 60px;
  padding-right: 0;
  box-shadow: 1px 4px 4px 0px rgba(0, 0, 0, 0.03);
  border: 0.5px solid rgba(0, 0, 0, 0.04);
  border-radius: 15px;
  text-align: left;
  outline: none;
  background: #c4c4c4;
}
.search-input {
  position: relative;
  width: 100%;
  margin-bottom: 50px;
}

.search-input input::placeholder {
  color: #000;
}

.search-input svg {
  position: absolute;
  left: 0;
  margin-top: 18px;
  margin-left: 20px;
  width: 20px;
}
</style>
