import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/pages/Home'
import VeeValidate from 'vee-validate'
import Notifications from 'vue-notification'

Vue.use(Router)
Vue.use(VeeValidate)
Vue.use(Notifications)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    }
  ]
})
