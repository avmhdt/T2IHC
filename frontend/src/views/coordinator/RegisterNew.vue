<template>
  <div>
    <h1>Novo estágio</h1>
    <div class="student-details">
      <p>Estudante</p>
      <input type="text" name="" id="" placeholder="Nome completo" />
      <input type="text" name="" id="" placeholder="Matrícula" />
      <input type="text" name="" id="" placeholder="CPF" />
      <input type="text" name="" id="" placeholder="Curso" />

      <button class="secondary">Cadastrar Estudante</button>
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
.student-details {
  width: 80%;
  background-color: #bdbfc1;
}
</style>
