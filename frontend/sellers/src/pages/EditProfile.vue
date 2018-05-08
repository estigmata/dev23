<template>
  <div class="wrapper-tabs">
    <sui-header size="huge" center class="title">Edit Profile</sui-header>
    <settings-tabs></settings-tabs>
  </div>
</template>

<script>
import SettingsTabs from '@/components/edit-profile/SettingsTabs'

export default {
  components: {
    SettingsTabs
  }
}
</script>

<style lang="css" scoped>
.wrapper-tabs {
  margin: 20px;
}
</style>
