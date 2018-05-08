import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  isAuthenticated () {
    return !!localStorage.getItem('userId')
  }
}