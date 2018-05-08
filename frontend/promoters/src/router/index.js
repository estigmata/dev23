import Vue from 'vue'
import Router from 'vue-router'
import Icon from 'vue-awesome/components/Icon'
import Home from '@/pages/Home'
import SuiVue from 'semantic-ui-vue'
import BenefitsCatalog from '@/pages/BenefitsCatalog'
import Benefit from '@/pages/Benefit'
import 'vue-awesome/icons'
import AuthService from '@/services/AuthService'

Vue.use(Router)
Vue.use(SuiVue)
Vue.component('icon', Icon)

var router = new Router({
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home,
      children: [
        {
          path: '',
          name: 'benefits',
          component: BenefitsCatalog
        },
        {
          path: '/benefit/:id',
          name: 'benefit',
          component: Benefit
        }
      ]
    }
  ]
})

router.beforeEach((to, from, next) => {
  if (AuthService.isAuthenticated()) {
    if (localStorage.getItem('role') === 'Employee') {
      next()
    } else {
      next(false)
      window.location.href = localStorage.getItem('url')
    }
  } else {
    next(false)
    window.location.href = `${process.env.CLIENT_URL}/login`
  }
})

export default router
