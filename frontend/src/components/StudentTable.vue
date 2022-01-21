<template>
  <div class="table-wrapper">
    <div class="table-details">
      <p>Relatórios enviados</p>
      <button class="primary">Submeter relatório</button>
    </div>
    <table>
      <tr>
        <th>Número</th>
        <th>Data de envio</th>
        <th>Data de entrega</th>
        <th>Situação</th>
        <th class="without-padding">Ações</th>
      </tr>
      <tr>
        <td>001</td>
        <td>02/05/2020</td>
        <td>03/03/2021</td>
        <td>Regular</td>
        <td class="without-padding"><button>Visualizar</button></td>
      </tr>
      <tr>
        <td>001</td>
        <td>02/05/2020</td>
        <td>03/03/2021</td>
        <td>Regular</td>
        <td class="without-padding"><button>Visualizar</button></td>
      </tr>
      <tr>
        <td>001</td>
        <td>02/05/2020</td>
        <td>03/03/2021</td>
        <td>Regular</td>
        <td class="without-padding"><button>Visualizar</button></td>
      </tr>
    </table>
  </div>
</template>

<script>
export default {
  name: 'StudentTable',
  props: {},
  data () {
    return {}
  }
}
</script>

<style>
.table-wrapper {
  width: 1160px;
  margin-left: 220px;
  margin-top: 40px;
}
.table-wrapper td,
th {
  padding-right: 195px;
  padding-top: 10px;
}
table {
  background-color: #bdbfc1;
  padding: 20px;
  padding-top: 10px;
}

.table-details {
  display: flex;
  justify-content: space-between;
  margin-bottom: 20px;
}

</style>
