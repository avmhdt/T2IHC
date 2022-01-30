<template>
  <div>
    <Header />
    <div class="home-intro">
      <h1>Olá, {{ studentDetails.nome }}!</h1>
      <div>
        <p class="my-info">Meus estágios</p>
        <div class="intern-info">
          <p>
            <b>Instituição concedente: </b> {{ studentDetails.estagio.empresa }}
          </p>
          <p>
            <b>Período de estágio: </b>
            {{ format_date(studentDetails.estagio.dataInicio) }} -
            {{ format_date(studentDetails.estagio.dataFim) }}
          </p>
          <p>
            <b>Horas semanais: </b> {{ studentDetails.estagio.horasSemanais }}
          </p>
          <p>
            <b>Professor orientador: </b
            >{{ studentDetails.estagio.coordenador.nome }}
          </p>
          <p>
            <b>Valor da bolsa: </b
            >{{ formatCurrency(studentDetails.estagio.valorBolsa) }}
          </p>
          <router-link to="/details">
            <button class="primary final">
              <span>Ver mais</span>
              <img
                src="@/assets/arrow-right.svg"
                alt="seta direita"
                class="arrow-right"
              /></button
          ></router-link>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import api from '@/services/api.js'
import Header from '@/components/Header.vue'
import moment from 'moment'

export default {
  name: 'Home',
  props: {},
  data () {
    return {
      studentDetails: {}
    }
  },
  components: { Header },
  methods: {
    format_date (value) {
      if (value) {
        return moment(String(value)).format('DD/MM/YYYY')
      }
    },
    formatCurrency (value) {
      return value.toLocaleString('pt-br', {
        style: 'currency',
        currency: 'BRL'
      })
    }
  },
  async created () {
    const { data } = await api.get(
      `/api/Aluno/GetAlunoByUsername?username=${this.$store.state.name}`
    )
    this.studentDetails = data
    console.log(this.studentDetails)
  }
}
</script>

<style scoped>
.home-intro {
  display: flex;
  min-height: 100vh;
  flex-direction: column;
  align-items: center;
}
.my-info {
  text-align: left;
  margin-left: 10px;
}
.intern-info {
  padding: 30px;
  text-align: left;
  width: 750px;
  background-color: #bdbfc1;
  border-radius: 8px;
  box-shadow: 2px 2px 5px rgba(0, 0, 0, 0.45);
  padding-left: 50px;
  position: relative;
}
button.final {
  position: absolute;
  right: 0;
  bottom: 0;
  margin-right: 80px;
  margin-bottom: 10px;
  display: flex;
  align-content: center;
}
.arrow-right {
  width: 18px;
  margin-left: 5px;
}
</style>
