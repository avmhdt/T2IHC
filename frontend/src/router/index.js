import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '@/views/student/Home.vue'
import InternDetails from '@/views/student/InternDetails.vue'
import RenewalProcess from '@/views/student/RenewalProcess.vue'
import Login from '@/views/shared/Login.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/details',
    name: 'InternDetails',
    component: InternDetails
  },
  {
    path: '/login',
    name: 'Login',
    component: Login
  },
  {
    path: '/renovar-estagio',
    name: 'RenewalProcess',
    component: RenewalProcess
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
