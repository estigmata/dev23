import Vue from 'vue'
import VueResource from 'vue-resource'
Vue.use(VueResource)

export default {
  getBenefits () {
    return Vue.http.get(`${process.env.BASE_URL}/benefits`)
  },
  getBenefit (id) {
    return Vue.http.get(`${process.env.BASE_URL}/benefits/${id}`)
  },
  getBenefitsByCategory (category) {
    return Vue.http.get(`${process.env.BASE_URL}/benefits/categories/${category}`)
  }
}
