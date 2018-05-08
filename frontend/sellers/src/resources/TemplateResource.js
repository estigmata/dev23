import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  getAllTemplates () {
    return Vue.http.get(`${process.env.BASE_URL}/schedules/templates`)
  }
}
