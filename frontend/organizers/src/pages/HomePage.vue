<template>
  <div class="router-container">
    <organizer-navbar :userEmail="userEmail"></organizer-navbar>
    <router-view></router-view>
  </div>
</template>

<script>
import EmailStorage from '@/resources/EmailStorage'
import OrganizerNavbar from '@/components/OrganizerNavbar'
export default {
  data () {
    return {
      userEmail: ''
    }
  },
  components: {
    OrganizerNavbar
  },
  methods: {
    saveEmail () {
      const emailURL = this.$route.query.email
      this.$router.replace('/')
      if (emailURL !== undefined) {
        EmailStorage.saveEmail(emailURL)
      }
      this.userEmail = EmailStorage.getEmail()
    }
  },
  mounted () {
    this.saveEmail()
  }
}
</script>

<style scoped>
.router-container {
  height: 100%;
  width: 100%;
  margin: 0;
  padding: 0;
}
</style>
