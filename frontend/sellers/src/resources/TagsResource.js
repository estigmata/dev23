import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  getAllTags () {
    return Vue.http.get(`${process.env.BASE_URL}/tags`)
  },
  deleteAllTags (promoterId) {
    const params = `tags/${promoterId}`
    return Vue.http.delete(`${process.env.BASE_URL}/${params}`)
  }
}
