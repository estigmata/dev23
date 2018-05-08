import Vue from 'vue'
import Router from 'vue-router'
import HomePage from '@/pages/HomePage'
import SellersPage from '@/pages/Sellers'
import FormEditor from '@/pages/FormEditor'
import Welcome from '@/components/Welcome'
import 'vue-awesome/icons'
import Icon from 'vue-awesome/components/Icon'
import SuiVue from 'semantic-ui-vue'
import AuthService from '@/services/AuthService'

Vue.use(Router)
Vue.component('icon', Icon)
Vue.use(SuiVue)

var router = new Router({
  routes: [
    {
      path: '/',
      name: 'HomePage',
      component: HomePage,
      children: [
        {
          path: '/form-editor',
          name: 'FormEditor',
          component: FormEditor
        },
        {
          path: '/sellers',
          name: 'SellersPage',
          component: SellersPage
        },
        {
          path: '',
          name: 'Welcome',
          component: Welcome
        }
      ]
    }
  ]
})

router.beforeEach((to, from, next) => {
  if (AuthService.isAuthenticated()) {
    if (localStorage.getItem('role') === 'Coordinator') {
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
