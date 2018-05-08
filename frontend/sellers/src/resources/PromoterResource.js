import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  getProfile (userId) {
    const params = `userId=${userId}`
    return Vue.http.get(`${process.env.BASE_URL}/promoters?${params}`)
  },
  updateProfile (profile) {
    return Vue.http.post(`${process.env.BASE_URL}/promoters`, profile)
  }
}
