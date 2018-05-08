import Vue from 'vue'
import Router from 'vue-router'
import Icon from 'vue-awesome/components/Icon'
import VeeValidate from 'vee-validate'
import Home from '@/pages/Home'
import Form from '@/pages/Form'
import EditProfile from '@/pages/EditProfile'
import GenerateForm from '@/components/GenerateForm'
import Welcome from '@/components/Welcome'
import SuiVue from 'semantic-ui-vue'
import Notifications from 'vue-notification'
import FormEditor from '@/pages/FormEditor'
import 'vue-awesome/icons'
import Stores from '@/pages/Stores'
import VueAutosuggest from 'vue-autosuggest'
import AuthService from '@/services/AuthService'

Vue.use(Router)
Vue.use(VeeValidate)
Vue.component('icon', Icon)
Vue.use(SuiVue)
Vue.use(Notifications)
Vue.use(VueAutosuggest)

var router = new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home,
      children: [
        {
          path: '/edit-profile',
          name: 'EditProfile',
          component: EditProfile
        },
        {
          path: '/generate-form',
          name: 'GenerateForm',
          component: GenerateForm
        },
        {
          path: '',
          name: 'Welcome',
          component: Welcome
        },
        {
          path: '/stores',
          name: 'Stores',
          component: Stores
        },
        {
          path: '/form-editor',
          name: 'FormEditor',
          component: FormEditor
        }
      ]
    },
    {
      path: '/form/:id',
      name: 'Form',
      component: Form
    }
  ]
})

router.beforeEach((to, from, next) => {
  if (AuthService.isAuthenticated()) {
    if (localStorage.getItem('role') === 'Promoter') {
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
