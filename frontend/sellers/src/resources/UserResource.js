import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  getUserId (email) {
    const params = `email=${email}`
    return Vue.http.get(`${process.env.BASE_URL}/users?${params}`)
  }
}
