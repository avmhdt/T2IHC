<template>
  <div class="container-register">
    <div class="wrapper-register">
      <h1>Novo estágio</h1>
      <div class="student-details">
        <p>Estudante</p>
        <div>
          <input type="text" name="" id="" placeholder="Nome completo" />
          <input type="text" name="" id="" placeholder="Matrícula" />
        </div>
        <div>
          <input type="text" name="" id="" placeholder="CPF" />
          <input type="text" name="" id="" placeholder="Curso" />
        </div>
        <button class="secondary right">Cadastrar Estudante</button>
      </div>

      <div class="company-details">
        <div>
          <label for="nome">Empresa</label>
          <input type="text" name="nome" id="nome" placeholder="Nome" />
          <input type="text" name="" id="" placeholder="CNPJ" />
        </div>
        <div>
          <label for="company">Supervisor de Estágio</label>
          <input
            type="text"
            name="company"
            id="company"
            placeholder="Nome completo"
          />
          <input type="text" name="" id="" placeholder="CPF" />
        </div>

        <div>
          <label for="horas">Horas semanais</label>
          <input
            type="text"
            name="horas"
            id="horas"
            placeholder="Horas semanais"
          />
          <label for="valor">Valor da bolsa</label>
          <input
            type="text"
            name="valor"
            id="valor"
            placeholder="Valor da Bolsa (R$)"
          />
        </div>
      </div>

      <div class="duration">
        <div>
          <label for="inicio">Data de início</label>
          <input type="date" name="inicio" id="inicio" />
        </div>
        <input type="number" name="" id="" placeholder="Duração" />
        <div>
          <label for="fim">Data de fim</label>
          <input type="date" name="fim" id="fim" />
        </div>
      </div>
      <button class="primary submit-register">Cadastrar Estágio</button>
    </div>
  </div>
</template>

<script>
export default {
  name: 'RegisterNew',
  props: {},
  data () {
    return {}
  },
  components: {},
  methods: {},
  created () {}
}
</script>

<style>
.container-register {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.wrapper-register {
  width: 80%;
  position: relative;
}
.student-details {
  position: relative;
  height: 300px;
}

.student-details,
.company-details,
.duration {
  background-color: #bdbfc1;
  width: 100%;
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
  margin-bottom: 60px;
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
  height: 30px;
  font-size: 18px;
  padding: 0 45px;
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
  padding: 12px 90px;

}
</style>
