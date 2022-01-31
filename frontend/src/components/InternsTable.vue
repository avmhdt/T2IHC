<template>
  <div>
    <p class="interns">Estágios cadastrados</p>
    <table class="interns-table">
      <tr>
        <th>Nome do aluno</th>
        <th>Nome da empresa</th>
        <th>Data de início</th>
        <th>Data de fim</th>
        <th>Ações</th>
      </tr>

      <tr v-for="item in interns" :key="item.id">
        <td>{{ item.nomeAluno }}</td>
        <td>{{ item.empresa }}</td>
        <td>{{ format_date(item.dataInicio) }}</td>
        <td>{{ format_date(item.dataFim) }}</td>
        <td>
          <button class="primary" @click="changeRouter(item.usuario)">
            Visualizar
          </button>
        </td>
      </tr>
    </table>
  </div>
</template>

<script>
import moment from 'moment'
export default {
  name: 'InternsTable',
  props: {
    interns: Array
  },
  data () {
    return {}
  },
  components: {},
  methods: {
    format_date (value) {
      if (value) {
        return moment(String(value)).format('DD/MM/YYYY')
      }
    },
    changeRouter (item) {
      console.log(item)
      this.$router.push({
        name: 'InternDetails',
        params: { name: item }
      })
    }
  },
  created () {}
}
</script>

<style scoped>
.interns-table {
  background-color: #bdbfc1;
  padding: 20px;
  padding-top: 10px;
}
.interns-table td {
  padding-top: 20px;
  margin-top: 60px;
}
table {
  width: 100%;
}
.interns {
  text-align: left;
  margin-left: 5px;
}
</style>
