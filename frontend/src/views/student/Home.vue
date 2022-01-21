<template>
  <div>
    <Header />
    <div class="home-intro">
      <h1>Olá, {{ name }}!</h1>
      <div>
        <p class="my-info">Meus estágios</p>
        <div class="intern-info">
          <p><b>Instituição concedente: </b>Nome da empresa aqui</p>
          <p><b>Período de estágio: </b>06/06/2021 - Presente</p>
          <p><b>Horas semanais: </b>30 horas</p>
          <p><b>Professor orientador: </b>André Luiz de Oliveira</p>
          <p><b>Valor da bolsa: </b>R$1000,00</p>
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
import Header from '@/components/Header.vue'
export default {
  name: 'Home',
  props: {},
  data () {
    return {
      name: 'Juliana'
    }
  },
  components: { Header },
  methods: {},
  created () {}
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
