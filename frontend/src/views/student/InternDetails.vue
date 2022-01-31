<template>
  <div>
    <Header />
    <div class="wrapper-details">
      <div class="intern-details-container">
        <div class="details">
          <div class="situation">
            <h1>Estágio na empresa {{ studentDetails.empresa }}</h1>
            <h2>Aluno: {{ user }}</h2>
            <p><b>Situação: </b>Ativo</p>
          </div>
          <div class="buttons-section">
            <button
              class="secondary"
              v-if="$store.state.typeofUser"
              @click="showTable = !showTable"
            >
              <span v-if="showTable">Pedir renovação</span>
              <span v-else>Ver relatórios</span>
            </button>
            <button class="secondary">Alterar dados</button>
            <button class="secondary">Encerrar estágio</button>
          </div>
        </div>
        <StudentTable v-if="showTable" :relatorios="relatorios" />
        <RenewalProcess v-else />
      </div>
    </div>
  </div>
</template>

<script>
import api from '@/services/api.js'
import Header from '@/components/Header.vue'
import StudentTable from '@/components/StudentTable.vue'
import RenewalProcess from '@/views/student/RenewalProcess.vue'

export default {
  name: 'InternDetails',
  props: {
    showTable: {
      type: Boolean,
      default: true
    },
    name: String
  },
  data () {
    return {
      studentDetails: {},
      relatorios: {},
      user: ''
    }
  },
  components: { Header, RenewalProcess, StudentTable },
  methods: {},
  async created () {
    const { data } = await api.get(
      `/api/Aluno/GetAlunoByUsername?username=${this.name}`
    )
    this.user = data.nome
    this.studentDetails = data.estagio
    this.relatorios = data.estagio.relatorio
  }
}
</script>

<style>
.intern-details-container {
  max-width: 80vw;
  display: flex;
  flex-direction: column;
  justify-content: center;
  display: block;
  margin: 0 auto;
  margin-top: 60px;
}
.details {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.situation {
  text-align: left;
}

.buttons-section button {
  margin-left: 15px;
}
</style>
