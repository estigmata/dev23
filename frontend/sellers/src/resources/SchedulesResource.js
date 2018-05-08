import Vue from 'vue'
import VueResource from 'vue-resource'

Vue.use(VueResource)

export default {
  save (scheduleList) {
    return Vue.http.post(`${process.env.BASE_URL}/Schedules`, scheduleList)
  },
  getSchedulesByPromoter (promoterId) {
    return Vue.http.get(`${process.env.BASE_URL}/Schedules/Promoter/${promoterId}`)
  }
}
