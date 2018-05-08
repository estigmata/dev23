<template>
  <div>
    <promotions-navbar :userEmail="userEmail" :hideMenuBar="isMenuNavbarHidden" :categories="categories"></promotions-navbar>
    <div class="router-container">
      <router-view @email-saved="sendEmailPromotionNavBar" @nav-bar-visibility-change="sendMenuNavBarHidden"></router-view>
    </div>
  </div>
</template>

<script>
import CategoryResource from '@/resources/CategoryResource'
import PromotionsNavbar from '@/components/PromotionsNavbar'
export default {
  components: { PromotionsNavbar },
  data () {
    return {
      categories: '',
      isMenuNavbarHidden: false,
      userEmail: ''
    }
  },
  methods: {
    async getCategories () {
      try {
        const { body: categories } = await CategoryResource.getCategories()
        this.categories = categories
      } catch (error) {
        console.error(error)
      }
    },
    sendMenuNavBarHidden (isMenuNavbarHidden) {
      this.isMenuNavbarHidden = isMenuNavbarHidden
    },
    sendEmailPromotionNavBar (email) {
      this.userEmail = email
    }
  },
  mounted () {
    this.getCategories()
  }
}
</script>

<style scoped>
  .title {
    width: 100%;
    text-align: center;
    color: white;
  }

  .categories {
    overflow: hidden;
  }
</style>
