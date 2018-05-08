<template>
  <div>
    <p>
      To define your schedule you can choose a schedule from our template
    </p>
    <sui-dropdown
      placeholder="Load schedule template"
      selection
      :options="scheduleTemplatesOptions"
      v-model="selectedTemplate"
    />
    <sui-button-group color="orange">
      <sui-button @click="applyTemplate" content="Apply"/>
    </sui-button-group>
    <hr />
    <sui-grid>
      <sui-grid-row>
        <sui-grid-column :width="3" v-for="index in weeklySchedule.length" :key="index">
          <schedule-card :day="daysEnum[index]" :dailySchedules.sync="weeklySchedule[index-1]"></schedule-card>
        </sui-grid-column>
      </sui-grid-row>
      <sui-grid-row>
         <sui-grid-column :width="8">
            <sui-button-group color="orange">
              <sui-button @click="saveSchedules" content="Save" :disabled="promoterSchedules.length <= 0"/>
            </sui-button-group>
        </sui-grid-column>
      </sui-grid-row>
    </sui-grid>
    <sui-container>
      <notifications position="bottom right"/>
    </sui-container>
  </div>
</template>
<script>
import ScheduleResource from '@/resources/SchedulesResource'
import ScheduleCard from '@/components/edit-profile/ScheduleCard'
import TemplateResource from '@/resources/TemplateResource'
import PromoterResource from '@/resources/PromoterResource'
import UserResource from '@/resources/UserResource'
import EmailStorage from '@/resources/EmailStorage'

export default {
  components: {
    ScheduleCard
  },
  data () {
    return {
      promoter: {},
      scheduleTemplatesOptions: [],
      selectedTemplate: null,
      scheduleTemplates: [],
      weeklySchedule: [],
      daysEnum: {
        1: 'Monday',
        2: 'Tuesday',
        3: 'Wednesday',
        4: 'Thurday',
        5: 'Friday',
        6: 'Saturday',
        7: 'Sunday'
      },
      promoterSchedules: []
    }
  },
  methods: {
    async loadInformation () {
      await this.loadPromoter()
      await this.loadShedule()
    },
    async loadPromoter () {
      let email = EmailStorage.getEmail()
      try {
        const { body: userId } = await UserResource.getUserId(email)
        const {body} = await PromoterResource.getProfile(userId)
        this.promoter = body
      } catch (error) {
        console.log(error)
      }
    },
    async loadShedule () {
      this.setSchedule([])
      try {
        const { body: schedules } = await ScheduleResource.getSchedulesByPromoter(this.promoter.id)
        this.promoterSchedule = schedules.map(item => {
          return item.schedule
        })
        this.setSchedule(this.promoterSchedule)
        const { body } = await TemplateResource.getAllTemplates()
        this.scheduleTemplates = body
        this.scheduleTemplatesOptions = body.map(item => {
          return { value: item.id, text: item.name }
        })
      } catch (err) {
        console.log(err)
      }
    },
    setSchedule (schedule) {
      this.weeklySchedule = []

      for (let day = 1; day <= 7; day++) {
        this.weeklySchedule.push(schedule.filter(dailySchedules => {
          return dailySchedules.day === day
        }))
      }
    },
    updatePromoterSchedules () {
      this.promoterSchedules = []
      this.weeklySchedule.forEach(day => {
        day.forEach(schedule => {
          if (schedule !== null) {
            const promoterSchedule = {
              promoterId: this.promoter.id,
              schedule: {
                day: schedule.day,
                from: schedule.from,
                to: schedule.to
              }
            }
            this.promoterSchedules.push(promoterSchedule)
          }
        })
      })
    },
    applyTemplate () {
      const foundTemplate = this.scheduleTemplates.find(template => {
        return template.id === this.selectedTemplate
      })

      let untreatedSchedule = foundTemplate.templateSchedule.map(item => {
        return item.schedule
      })

      this.setSchedule(untreatedSchedule)
    },
    async saveSchedules () {
      this.updatePromoterSchedules()
      try {
        await ScheduleResource.save(this.promoterSchedules)
        this.$notify({
          title: 'Success',
          text: 'The schedule have been created correctly',
          type: 'success'
        })
      } catch (err) {
        if (err.status === 404) {
          this.$notify({
            title: 'An error have ocurred',
            text: 'The schedule have not been created correctly, check the schedules and try again',
            type: 'error'
          })
        } else {
          this.$notify({
            title: 'An error have ocurred',
            text: 'An unexpected error have ocurred please try again later or contact the web admin',
            type: 'error'
          })
        }
      }
    }
  },
  mounted () {
    this.loadInformation()
  },
  watch: {
    weeklySchedule: function (val) {
      this.updatePromoterSchedules()
    }
  }
}
</script>
<style scoped>
hr {
  border: none;
  border-top: 1px dashed #ccc;
  margin: 20px 0;
}
</style>
