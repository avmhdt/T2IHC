<template>
  <div class="login-box">
    <img src="@/assets/logo.png" alt="logo-ufjf" class="logo-login" />
    <form @submit.prevent="login">
      <h1>Sistema de coordenação de estágios</h1>
      <label for="text">Matrícula / Siape</label>
      <input type="text" name="text" id="text" v-model="user.usuario" />
      <label for="password">Senha</label>
      <input
        type="password"
        name="password"
        id="password"
        v-model="user.senha"
      />
      <div class="choose-type">
        <div>
          <input
            type="radio"
            id="aluno"
            name="tipoUsuario"
            :value="1"
            v-model="user.tipoUsuario"
          />
          <label for="aluno">Sou aluno</label>
        </div>
        <div>
          <input
            type="radio"
            id="coordenador"
            name="tipoUsuario"
            :value="0"
            v-model="user.tipoUsuario"
          />
          <label for="coordenador">Sou coordenador</label>
        </div>
      </div>

      <a href="">Esqueceu a senha?</a>
      <button type="submit">Entrar</button>
    </form>
  </div>
</template>

<script>
import api from '@/services/api.js'
export default {
  name: 'Login',
  props: {},
  data () {
    return {
      user: {
        usuario: '',
        senha: '',
        tipoUsuario: 1
      }
    }
  },
  components: {},
  methods: {
    async login () {
      try {
        const { data } = await api.post('/api/Login', this.user)
        console.log('tentando logar', data)
        this.$store.commit('SET_USER', data)
        localStorage.setItem('knowledge_user', JSON.stringify(data))

        if (data.tipoUsuario === 0) {
          this.$router.push('/Home/Coord')
        } else {
          this.$router.push('/')
        }
      } catch {
        alert('ERRO AO LOGAR')
      }
    }
  },
  created () {}
}
</script>

<style>
.logo-login {
  width: 170px;
}
.login-box {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  min-height: 80vh;
}
.login-box h1 {
  font-size: 20px;
  margin-bottom: 30px;
  margin-top: -10px;
}
.login-box form {
  display: flex;
  flex-direction: column;
  justify-content: center;
  padding: 50px;
  margin-top: 40px;
  background-color: rgba(189, 191, 193, 0.4);
  max-width: 500px;
  box-shadow: 2px 2px 5px rgba(0, 0, 0, 0.3);
}
.login-box form label {
  margin-bottom: 5px;
  align-self: flex-start;
}

.login-box form label:last-of-type {
  margin-top: 20px;
}

.login-box form input {
  height: 20px;
  padding: 10px;
  outline: none;
}
.login-box form a {
  margin-top: 20px;
  margin-bottom: 10px;
}
.login-box form button {
  background-color: #a4291a;
  border: none;
  color: #fff;
  font-size: 15px;
  padding: 10px 20px;
  font-weight: bold;
  text-transform: uppercase;
  border-radius: 5px;
}
.choose-type {
  display: flex;
  align-items: center;
  justify-content: space-evenly;
  margin-top: 10px;
}
.choose-type div {
  display: flex;
  align-items: center;
  align-content: center;
}
.choose-type div input {
  margin-top: 15px;
  margin-right: 10px;
}
</style>
