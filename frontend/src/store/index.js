import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    name: '',
    typeofUser: 0
  },
  mutations: {
    SET_USER (state, payload) {
      if (payload) {
        state.name = payload.usuario
        state.typeofUser = payload.tipoUsuario
      } else {
        state.name = ''
        state.typeofUser = 0
      }
    }
  },
  actions: {},
  modules: {}
})
