<template>
  <div>
    <Header />
    <div>
      <div class="details">
        <div class="situation">
          <h1>Estágio na empresa {{ companyName }}</h1>
          <p><b>Situação: </b>Ativo</p>
        </div>
        <div class="buttons-section">
          <router-link to="/renovar-estagio">
            <button class="secondary">Pedir renovação</button>
          </router-link>
          <button class="secondary">Alterar dados</button>
          <button class="secondary">Encerrar estágio</button>
        </div>
      </div>
      <StudentTable v-if="showTable" />
    </div>
  </div>
</template>

<script>
import Header from '@/components/Header.vue'
import StudentTable from '@/components/StudentTable.vue'

export default {
  name: 'InternDetails',
  props: {
    showTable: {
      type: Boolean,
      default: true
    }
  },
  data () {
    return {
      companyName: 'UFJF'
    }
  },
  components: { Header, StudentTable },
  methods: {},
  created () {}
}
</script>

<style>
.details {
  display: flex;
  justify-content: space-around;
  align-items: center;
  max-width: 80%;
  margin-left: 70px;
}

.situation {
  text-align: left;
}

.buttons-section button {
  margin-left: 15px;
}
</style>
