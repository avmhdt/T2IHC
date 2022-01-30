<template>
  <div class="table-wrapper">
    <p class="table-details">Lista de relatórios</p>
    <table>
      <tr>
        <th>Número</th>
        <th>Data de envio</th>
        <th>Data de entrega</th>
        <th>Situação</th>
        <th>Ações</th>
      </tr>

      <!-- <tr v-for="item in relatorios" :key="item.id">
        <td>{{ item.id }}</td>
        <td>{{ format_date(item.dataEnvio) }}</td>
        <td>{{ format_date(item.dataEntrega) }}</td>
        <td>{{ item.situacao }}</td>
        <td class="without-padding"><button>Visualizar</button></td>
      </tr> -->

      <tr>
        <td>{{ relatorios.id }}</td>
        <td>{{ format_date(relatorios.dataEnvio) }}</td>
        <td>{{ format_date(relatorios.dataEntrega) }}</td>
        <td>{{ relatorios.situacao }}</td>
        <td>
          <button class="secondary">
            <span v-if="relatorios.situacao == 'Pendente'">Enviar</span>
            <span v-else>Visualizar</span>
          </button>
        </td>
      </tr>
    </table>
  </div>
</template>

<script>
import moment from 'moment'

export default {
  name: 'StudentTable',
  props: {
    relatorios: Object
  },
  data () {
    return {}
  },
  methods: {
    format_date (value) {
      if (value) return moment(String(value)).format('DD/MM/YYYY')
      return '-'
    }
  }
}
</script>

<style>
.table-wrapper {
  margin-top: 40px;
}

.table-wrapper table {
  background-color: #bdbfc1;
  padding: 20px;
  padding-top: 10px;
  width: 100%;
}

.table-details {
  margin-bottom: 5px;
  text-align: left;
}
</style>
