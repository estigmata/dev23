<template>
  <div>
    <div class="ui top attached tabular menu">
      <a
        class="item"
        data-tab="profile"
        :class="{ active: activeTab === 'profile' }"
        @click="selectTab('profile')">Profile</a>
      <a
        class="item"
        data-tab="schedule"
        :class="{ active: activeTab === 'schedule' }"
        @click="selectTab('schedule')">Schedule</a>
    </div>
    <div
      class="ui bottom attached tab segment"
      data-tab="profile"
      :class="{ active: activeTab === 'profile' }">
      <profile></profile>
    </div>
    <div
      class="ui bottom attached tab segment"
      data-tab="schedule"
      :class="{ active: activeTab === 'schedule' }">
      <schedule></schedule>
    </div>
  </div>
</template>

<script>
import Profile from '@/components/edit-profile/PromoterInformationForm'
import Schedule from '@/components/edit-profile/ScheduleForm'

export default {
  components: {
    Profile,
    Schedule
  },
  data () {
    return {
      activeTab: 'profile'
    }
  },
  methods: {
    selectTab (tab) {
      this.activeTab = tab
    }
  }
}
</script>
