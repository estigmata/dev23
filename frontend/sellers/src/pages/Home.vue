<template>
  <div class="router-container">
    <seller-navbar :userEmail="userEmail"></seller-navbar>
    <router-view></router-view>
  </div>
</template>

<script>
import EmailStorage from '@/resources/EmailStorage'
import SellerNavbar from '@/components/SellerNavbar'
export default {
  data () {
    return {
      userEmail: ''
    }
  },
  components: {
    SellerNavbar
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
