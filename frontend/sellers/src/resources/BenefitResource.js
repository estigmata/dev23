import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  save (benefit) {
    return Vue.http.post(`${process.env.BASE_URL}/benefits`, benefit)
  },
  getBenefit (id) {
    return Vue.http.get(`${process.env.BASE_URL}/benefits/${id}`)
  },
  getAllBenefits (promoterId) {
    return Vue.http.get(`${process.env.BASE_URL}/promoters/${promoterId}/benefits`)
  },
  delete (benefitId) {
    return Vue.http.delete(`${process.env.BASE_URL}/benefits/${benefitId}`)
  },
  update (benefitId, benefit) {
    return Vue.http.put(`${process.env.BASE_URL}/benefits/${benefitId}`, benefit)
  }
}
