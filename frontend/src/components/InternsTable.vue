<template>
  <div>
    <table>
      <tr>
        <th>Nome do aluno</th>
        <th>Nome da empresa</th>
        <th>Data de início</th>
        <th>Data de fim</th>
        <th class="without-padding">Ações</th>
      </tr>

      <tr v-for="(item, index) in interns" :key="item.id">
        <td>Aluno {{ index + 1 }}</td>
        <td>{{ item.empresa }}</td>
        <td>{{ format_date(item.dataInicio) }}</td>
        <td>{{ format_date(item.dataFim) }}</td>
        <td class="without-padding"><button>Visualizar</button></td>
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
    }
  },
  created () {}
}
</script>

<style></style>
