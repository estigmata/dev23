import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  getAllStores (promoterId) {
    return Vue.http.get(`${process.env.BASE_URL}/promoters/${promoterId}/stores`)
  },
  save (promoterId, store) {
    return Vue.http.post(`${process.env.BASE_URL}/promoters/${promoterId}/stores`, store)
  }
}
