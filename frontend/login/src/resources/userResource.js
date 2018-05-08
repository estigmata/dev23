import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  getHomePageUrl (email, password) {
    const params = {
      email: email,
      password: password
    }
    return Vue.http.post(`${process.env.BASE_URL}/roles`, params)
  }
}
