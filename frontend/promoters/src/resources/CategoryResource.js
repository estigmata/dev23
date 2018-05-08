import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  getCategories () {
    return Vue.http.get(`${process.env.BASE_URL}/categories`)
  }
}
