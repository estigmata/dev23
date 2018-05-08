<template>
  <sui-container class="pusher">
    <h1 is="sui-header"></h1>
    <div v-if="!isCategoryHidden" is="sui-divider" horizontal>
      <h2 is="sui-header">
        <sui-icon name="tag icon"></sui-icon>
        Promotions
      </h2>
    </div>
     <sui-breadcrumb class="breadcrumb">
        <sui-breadcrumb-section v-if="isCategoryHidden" link @click='getBenefits()'>Catalogue</sui-breadcrumb-section>
        <sui-breadcrumb-divider v-if="category!=''" />
        <sui-breadcrumb-section> {{ category }} </sui-breadcrumb-section>
      </sui-breadcrumb>
    <div class="ui centered cards">
      <BenefitCard v-for="(benefit, index) in benefits.data"
      :key='index'
      :benefit='benefit'
      class="benefit-card">
      </BenefitCard>
    </div>
  </sui-container>
</template>

<script>
import BenefitCard from '@/components/BenefitCard'
import BenefitResource from './../resources/BenefitResource'
import EmailStorage from '@/resources/EmailStorage'
export default {
  components: { BenefitCard },
  data () {
    return {
      benefits: '',
      category: '',
      isCategoryHidden: true
    }
  },
  watch: {
    $route ({ query } = {}, from) {
      this.category = ''
      this.benefits = ''
      if (query.category !== undefined) {
        this.getBenefitsByCategory(query.category)
      } else {
        this.getBenefits()
      }
    }
  },
  methods: {
    async getBenefits () {
      this.navbarVisibility(false)
      this.isCategoryHidden = false
      this.$router.replace({query: {}})
      try {
        const { body: benefits } = await BenefitResource.getBenefits()
        this.benefits = benefits
      } catch (error) {
        console.error(error)
      }
    },
    async getBenefitsByCategory (category) {
      this.navbarVisibility(true)
      this.isCategoryHidden = true
      try {
        const { body: benefits } = await BenefitResource.getBenefitsByCategory(category)
        this.benefits = benefits
        this.category = decodeURI(category)
      } catch (error) {
        console.error(error)
      }
    },
    showBenefit (id) {
      this.router.push({ name: 'benefit', params: { id: id } })
    },
    navbarVisibility (hiddenNavbar) {
      this.$emit('nav-bar-visibility-change', hiddenNavbar)
    },
    saveEmail () {
      const emailURL = this.$route.query.email
      if (emailURL !== undefined) {
        EmailStorage.saveEmail(emailURL)
      }
      this.sendEmail()
    },
    sendEmail () {
      this.$emit('email-saved', EmailStorage.getEmail())
    }
  },
  mounted () {
    this.navbarVisibility(false)
    this.saveEmail()
    this.getBenefits()
  }
}
</script>

<style scoped>
  .centered {
    margin-top: 2%;
  }

  .ui.header {
    margin-left: 5%;
  }

  .container {
    width: 100%;
    height: 100%;
  }

  .benefit-card {
    cursor: pointer;
  }

  .breadcrumb {
    font-size: 24px;
    font-weight: bold;
    padding-left: 20px;
  }

  .tag.icon {
    font-size: 20px;
    margin-top: -14px;
  }
</style>
