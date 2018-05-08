<template>
  <div class="benefit-panel">
    <sui-grid stackable>
      <sui-grid-row>
        <sui-grid-column>
          <router-link class="menu-link" to="/">
            <sui-breadcrumb class="breadcrumb">
              <sui-breadcrumb-section>
                <sui-icon name="angle double left icon"></sui-icon>
                Catalogue
              </sui-breadcrumb-section>
            </sui-breadcrumb>
          </router-link>
        </sui-grid-column>
      </sui-grid-row>
      <sui-grid-row>
        <sui-grid-column :computer="1" :widescreen="5" :tablet="1">
        </sui-grid-column>
        <sui-grid-column :computer="8" :widescreen="4" :tablet="8" :mobile="16" >
          <Builder :model="banner" class="banner"></Builder>
        </sui-grid-column>
        <sui-grid-column :computer="1" :widescreen="5" :tablet="1">
        </sui-grid-column>
        <sui-grid-column :computer="5" :widescreen="2" :tablet="5" :mobile="16">
          <BenefitInformation v-if="isBenefitHidden" :advantage="benefit"></BenefitInformation>
        </sui-grid-column>
        <sui-grid-column :computer="1" :widescreen="5" :tablet="1">
        </sui-grid-column>
      </sui-grid-row>
    </sui-grid>
  </div>
</template>

<script>
import Builder from '../components/form-builder/GenericForm'
import BenefitInformation from '../components/BenefitInformation'
import BenefitResource from './../resources/BenefitResource'

export default {
  components: { Builder, BenefitInformation },
  data () {
    return {
      banner: '',
      benefit: {},
      isBenefitHidden: false
    }
  },
  async mounted () {
    this.$emit('nav-bar-visibility-change', true)
    const id = this.$route.params.id
    try {
      const {body} = await BenefitResource.getBenefit(id)
      this.benefit = body
      this.banner = this.benefit.banner.model
      if (this.banner !== 'undefined') {
        this.isBenefitHidden = true
      }
    } catch (err) {
      console.log(err)
    }
  }
}
</script>

<style scoped>
  .title {
    width: 100%;
    text-align: center;
    color: white;
  }

  .benefit-panel {
    width: 100%;
  }

  .banner {
    position: relative;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    max-width:550px;
    max-height:495px;
    width: auto;
    height: auto;
  }

  .breadcrumb {
    font-size: 24px;
    font-weight: bold;
    padding-left: 20px;
    padding-top: 23px;
  }

  @media only screen and (max-width: 549px) {
    .banner {
      zoom: 0.6;
    }
  }
  @media only screen and (min-width: 768px) and (max-width: 990px) {
    .banner {
        zoom: 0.7;
    }
  }
  @media only screen and (min-width: 990px) and (max-width: 1024px) {
    .banner {
        zoom: 0.8;
    }
  }
</style>
