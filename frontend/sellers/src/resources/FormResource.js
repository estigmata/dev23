import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  getAllForms () {
    return Vue.http.get(`${process.env.BASE_URL}/forms`)
  },
  getForm (id) {
    const params = `id=${id}`
    return Vue.http.get(`${process.env.BASE_URL}/forms?${params}`)
  }
}
