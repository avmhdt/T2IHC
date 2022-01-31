import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '@/views/student/Home.vue'
import HomeCoord from '@/views/coordinator/Home.vue'
import InternDetails from '@/views/student/InternDetails.vue'
import RegisterNew from '@/views/coordinator/RegisterNew.vue'
import Login from '@/views/shared/Login.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home,
    meta: {
      requiresStudent: true
    }
  },
  {
    path: '/Home/Coord',
    name: 'HomeCoord',
    component: HomeCoord,
    meta: {
      requiresAdmin: true
    }
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
    path: '/novo-estagio',
    name: 'RegisterNew',
    component: RegisterNew,
    meta: {
      requiresAdmin: true
    }
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

router.beforeEach((to, from, next) => {
  const json = localStorage.getItem('knowledge_user')
  const user = JSON.parse(json)

  if (to.matched.some((record) => record.meta.requiresAdmin)) {
    user && user.tipoUsuario === 0 ? next() : next({ path: '/' })
  } else if (to.matched.some((record) => record.meta.requiresStudent)) {
    user && user.tipoUsuario === 1 ? next() : next({ path: '/Home/Coord' })
  } else {
    next()
  }
})

export default router
