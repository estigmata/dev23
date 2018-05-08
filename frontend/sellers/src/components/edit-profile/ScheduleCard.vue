<template>
  <div>
    <sui-card class="orange">
      <sui-card-content class="grey">
        <sui-card-header>{{ day }}</sui-card-header>
      </sui-card-content>
      <sui-card-content class="schedules">
        <sui-table>
          <sui-table-body>
            <schedule v-for="index in dailySchedules.length"
              :range.sync="dailySchedules[index-1]"
              :key="index"
              v-if="dailySchedules[index-1] != null"></schedule>
          </sui-table-body>
        </sui-table>
      </sui-card-content>
      <sui-card-content>
        <sui-icon class="floated right" name="calendar plus outline" @click="newSchedule" />
      </sui-card-content>
    </sui-card>
  </div>
</template>

<script>
import Schedule from '@/components/edit-profile/Schedule'

export default {
  data () {
    return {
      daysEnum: {
        'Monday': 1,
        'Tuesday': 2,
        'Wednesday': 3,
        'Thurday': 4,
        'Friday': 5,
        'Saturday': 6,
        'Sunday': 7
      }
    }
  },
  components: {
    Schedule
  },
  props: [
    'day',
    'dailySchedules'
  ],
  methods: {
    enterEditMode () {
      this.editModeActive = true
    },
    exitEditMode () {
      this.editModeActive = false
    },
    newSchedule () {
      this.dailySchedules.push({
        day: this.daysEnum[this.day],
        from: '00:00',
        to: '00:00'
      })
    }
  },
  watch: {
    dailySchedules: function (val) {
      this.dailySchedules.filter(range => {
        return range !== null
      })
      this.$emit('update:dailySchedules', this.dailySchedules)
    }
  }
}
</script>

<style scoped>
.grey {
  background-color: #eee !important;
}

.floated.right {
  cursor: pointer;
  float: right;
  font-size: 16px;
}

.floated.right:hover {
  color: #f60;
}

.orange {
  margin-bottom: 10px !important;
}

.schedules.content {
  padding: 10px 0;
}

.schedules.content > .ui.table {
  border: none;
}
</style>
