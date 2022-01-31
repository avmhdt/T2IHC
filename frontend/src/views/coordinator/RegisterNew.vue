<template>
  <div class="with-sidebar">
    <Sidebar />
    <div class="container-register">
      <div class="wrapper-register">
        <h1>Novo estágio</h1>
        <div class="student-details">
          <p>Estudante</p>

          <select v-model="select">
            <option disabled value="">Selecionar Estudante</option>
            <option
              v-for="item in allStudents"
              :key="item.usuario"
              :value="item.nome"
            >
              {{ item.nome }}
            </option>
          </select>

          <div class="inline">
            <input
              type="text"
              name=""
              id=""
              placeholder="Nome completo"
              class="big-input"
            />
            <input type="text" name="" id="" placeholder="Matrícula" />
          </div>
          <div class="inline">
            <input type="text" name="" id="" placeholder="CPF" />
            <input type="text" name="" id="" placeholder="Curso" />
          </div>
          <button class="secondary right">Cadastrar Estudante</button>
        </div>

        <div class="company-details">
          <div class="inline">
            <div class="label-column">
              <label for="nome">Empresa</label>
              <input
                type="text"
                name="nome"
                id="nome"
                placeholder="Nome"
                class="big-input"
                v-model="estagio.Empresa"
              />
            </div>
            <input type="text" name="" id="" placeholder="CNPJ" />
          </div>
          <div class="inline">
            <div class="label-column">
              <label for="company">Supervisor de Estágio</label>
              <input
                type="text"
                name="company"
                id="company"
                placeholder="Nome completo"
                class="big-input"
              />
            </div>
            <input type="text" name="" id="" placeholder="CPF" />
          </div>

          <div class="inline">
            <div class="label-column">
              <label for="horas">Horas semanais</label>
              <input
                type="text"
                name="horas"
                id="horas"
                placeholder="Horas semanais"
                v-model="estagio.HorasSemanais"
              />
            </div>
            <div class="label-column">
              <label for="valor">Valor da bolsa</label>
              <input
                type="text"
                name="valor"
                id="valor"
                placeholder="Valor da Bolsa (R$)"
                v-model="estagio.ValorBolsa"
              />
            </div>
          </div>
        </div>

        <div class="duration">
          <div>
            <label for="inicio">Data de início</label>
            <input
              type="date"
              name="inicio"
              id="inicio"
              v-model="estagio.DataInicio"
            />
          </div>
          <input type="number" name="" id="" placeholder="Duração" />
          <div>
            <label for="fim">Data de fim</label>
            <input type="date" name="fim" id="fim" v-model="estagio.DataFim" />
          </div>
        </div>
        <button class="primary submit-register" @click="createEstagio">
          Cadastrar Estágio
        </button>
      </div>
    </div>
  </div>
</template>

<script>
import api from '@/services/api.js'
import Sidebar from '@/components/Sidebar.vue'

export default {
  name: 'RegisterNew',
  props: {},
  data () {
    return {
      allStudents: [],
      select: '',
      estagio: {
        Id: 3,
        Empresa: '',
        DataInicio: null,
        DataFim: null,
        Relatorio: null,
        HorasSemanais: 30,
        ValorBolsa: 0
      }
    }
  },
  components: { Sidebar },
  methods: {
    async createEstagio () {
      try {
        const response = await api.post(
          '/api/Estagio/CadastrarEstagio',
          this.estagio
        )
        console.log(response)
      } catch {
        alert('Não foi possível cadastrar esse estágio!')
      }
    }
  },
  async created () {
    const { data } = await api.get('/api/Aluno/GetAlunos')
    this.allStudents = data
  }
}
</script>

<style>
.with-sidebar {
  display: grid;
  grid-template-columns: 15% 85%;
  gap: 20px;
  overflow: hidden;
}

.container-register {
  display: flex;
  flex-direction: column;
  align-items: center;
  margin-top: 10px;
}
.wrapper-register {
  width: 100%;
  position: relative;
}
.wrapper-register h1 {
  text-align: left;
}
.student-details {
  position: relative;
  height: 300px;
}
.student-details p {
  text-align: left;
  padding-top: 20px;
  margin-left: 40px;
}

.student-details,
.company-details,
.duration {
  background-color: #bdbfc1;
  width: 90%;
  box-shadow: 2px 2px 5px rgba(0, 0, 0, 0.45);
  flex-wrap: wrap-reverse;
}
.company-details {
  margin-top: 40px;
  padding: 20px 0;
}
.duration {
  display: flex;
  margin-top: 40px;
  padding: 20px 0;
  justify-content: space-around;
  margin-bottom: 70px;
  flex-wrap: wrap-reverse;
}
.duration div {
  background-color: #fff;
  padding-left: 20px;
}

.duration div input {
  border: none;
  border-left: 0.6px solid #bfbfbf;
  border-radius: 0;
  margin-left: 100px;
}

input {
  height: 40px;
  font-size: 18px;
  border-radius: 5px;
  border: 1px solid #bfbfbf;
  padding: 0 15px;
  border-bottom-width: 2px;
  outline: none;
}

input::placeholder {
  color: #bfbfbf;
  font-size: 17px;
}
button.right {
  position: absolute;
  right: 0;
  bottom: 0;
  margin-right: 40px;
  margin-bottom: 20px;
}

button.submit-register {
  position: absolute;
  right: 0;
  bottom: 0;
  padding: 15px 70px;
  margin-right: 150px;
  font-weight: bold;
  text-transform: uppercase;
}

.label-column {
  display: flex;
  flex-direction: column;
}
.label-column label {
  align-self: flex-start;
  margin-bottom: 7px;
}

.inline {
  display: flex;
  justify-content: space-between;
  padding: 10px 40px;
  align-items: flex-end;
}
.student-details select {
  width: 95%;
  padding: 10px;
  margin-bottom: 15px;
}
.big-input {
  width: 35vw;
}
</style>
