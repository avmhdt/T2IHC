import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '@/views/student/Home.vue'
import HomeCoord from '@/views/coordinator/Home.vue'
import InternDetails from '@/views/student/InternDetails.vue'
import RenewalProcess from '@/views/student/RenewalProcess.vue'
import RegisterNew from '@/views/coordinator/RegisterNew.vue'
import Login from '@/views/shared/Login.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/Home/Coord',
    name: 'HomeCoord',
    component: HomeCoord
  },
  {
    path: '/details',
    name: 'InternDetails',
    component: InternDetails,
    props: true
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
  },
  {
    path: '/novo-estagio',
    name: 'RegisterNew',
    component: RegisterNew
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
