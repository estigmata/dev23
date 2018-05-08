<template>
  <div class="container">
    <sui-grid>
      <sui-grid-row>
        <sui-grid-column :computer="16">
          <sui-form @submit.prevent="preventLoadBenefits">
            <sui-form-field>
              <div class="container-combo-benefit">
                <div>
                  <label> Select your benefit to update or create a new benefit </label>
                  <select v-model="selectedBenefit" @change="getBenefit($event.target.value)">
                    <option value="-1">New benefit</option>
                    <option
                      v-for="(benefit, index) in benefitsList"
                      :key="index"
                      :value="benefit.id">
                        {{ benefit.name }}
                    </option>
                  </select>
                </div>
                <div>
                  <div v-if="selectedBenefit == -1">
                    <sui-button type="submit"
                      @click="save"
                      color="orange"
                      >Save Benefit
                    </sui-button>
                  </div>
                  <div v-else>
                    <sui-button type="submit"
                      @click="update"
                      color="orange">Update Benefit
                    </sui-button>
                    <sui-button type="submit"
                      @click="remove"
                      color="red">Delete Benefit
                    </sui-button>
                  </div>
                </div>
              </div>
            </sui-form-field>
          </sui-form>
        </sui-grid-column>
      </sui-grid-row>
    </sui-grid>
    <div class="container-tab">
      <div class="ui top attached tabular menu">
        <a
          class="item"
          data-tab="benefit-infromation"
          :class="{ active: activeTab === 'benefit-infromation' }"
          @click="selectTab('benefit-infromation')">General Information</a>
        <a
          class="item"
          data-tab="benefit-editor"
          :class="{ active: activeTab === 'benefit-editor' }"
          @click="selectTab('benefit-editor')">Banner Editor</a>
      </div>
      <div
        class="ui bottom attached tab segment"
        data-tab="benefit-infromation"
        :class="{ active: activeTab === 'benefit-infromation' }">
        <benefit :benefit="benefit" ref="benefitForm"></benefit>
      </div>
      <div
        class="ui bottom attached tab segment"
        data-tab="benefit-editor"
        :class="{ active: activeTab === 'benefit-editor' }">
        <form-editor ref="formEditor" :model="benefit"></form-editor>
      </div>
      <sui-container>
        <notifications position="bottom right"/>
      </sui-container>
    </div>
  </div>
</template>

<script>
import BenefitResource from '../resources/BenefitResource'
import UserResource from './../resources/UserResource'
import EmailStorage from './../resources/EmailStorage'
import PromoterResource from './../resources/PromoterResource'
import Benefit from '@/components/BenefitForm'
import { FormEditor } from 'vue-components-advantage'

export default {
  data () {
    return {
      activeTab: 'benefit-infromation',
      benefit: {},
      benefitsList: {},
      selectedBenefit: -1
    }
  },
  components: {
    FormEditor,
    Benefit
  },
  methods: {
    selectTab (tab) {
      this.activeTab = tab
    },
    preventLoadBenefits (event) {
      event.preventDefault()
    },
    async save () {
      const isFormValid = await this.$refs.benefitForm.$validator.validateAll()
      if (isFormValid) {
        const email = EmailStorage.getEmail()
        const { body } = await UserResource.getUserId(email)
        const { body: promoterProfile } = await PromoterResource.getProfile(body)
        const benefit = {
          ...this.$refs.benefitForm.getModel(),
          banner: {
            model: JSON.stringify(this.getModel())
          },
          promoterId: promoterProfile.id
        }
        try {
          const { status } = await BenefitResource.save(benefit)
          if (status === 201) {
            this.$notify({
              title: 'Success',
              text: 'The benefit have been Created',
              type: 'success'
            })
          }
        } catch (error) {
          this.$notify({
            title: 'An error ocurred',
            text: error,
            type: 'error'
          })
        }
      } else {
        this.$notify({
          title: 'An error ocurred',
          text: 'The benefit information is not correctly filled',
          type: 'error'
        })
      }
    },
    getModel () {
      return this.$refs.formEditor.getModel()
    },
    async getBenefit (benefitId) {
      try {
        await this.$refs.formEditor.cleanPanel()
        if (benefitId !== '-1') {
          const { body: benefit } = await BenefitResource.getBenefit(benefitId)
          this.benefit = benefit
        } else {
          this.benefit = null
        }
      } catch (error) {
        this.$notify({
          title: 'Notification',
          text: 'The data benefit could not be loaded.',
          type: 'error'
        })
      }
    },
    async getAllBenefits () {
      try {
        const promoterId = await this.getPromoterId()
        const {body: benefits} = await BenefitResource.getAllBenefits(promoterId)
        this.benefitsList = benefits
      } catch (error) {
        this.$notify({
          title: 'Notification',
          text: 'The data benefits could not be loaded',
          type: 'error'
        })
      }
    },
    async getPromoterId () {
      let email = EmailStorage.getEmail()
      try {
        const { body: userId } = await UserResource.getUserId(email)
        return userId
      } catch (error) {
        this.$notify({
          title: 'Notification',
          text: 'The promoter Id could not be loaded',
          type: 'error'
        })
      }
    },
    async remove () {
      try {
        const { status } = await BenefitResource.delete(this.selectedBenefit)
        if (status === 200) {
          this.$notify({
            title: 'Notification',
            text: 'The benefit was deleted succesfully',
            type: 'success'
          })

          this.getAllBenefits()
          this.benefit = null
          this.selectedBenefit = -1
        }
      } catch (error) {
        this.$notify({
          title: 'Notification',
          text: 'The benefit could not be deleted',
          type: 'error'
        })
      }
    },
    async update () {
      const isFormValid = await this.$refs.benefitForm.$validator.validateAll()
      if (isFormValid) {
        const email = EmailStorage.getEmail()
        const { body } = await UserResource.getUserId(email)
        const { body: promoterProfile } = await PromoterResource.getProfile(body)
        const benefit = {
          ...this.$refs.benefitForm.getModel(),
          banner: {
            model: JSON.stringify(this.getModel())
          },
          promoterId: promoterProfile.id
        }
        try {
          const { status } = await BenefitResource.update(this.selectedBenefit, benefit)
          if (status === 200) {
            this.$notify({
              title: 'Success',
              text: 'The benefit has been Updated',
              type: 'success'
            })
          }
        } catch (error) {
          this.$notify({
            title: 'An error ocurred',
            text: error,
            type: 'error'
          })
        }
      } else {
        this.$notify({
          title: 'An error ocurred',
          text: 'The benefit information is not correctly filled',
          type: 'error'
        })
      }
    }
  },
  mounted () {
    this.getAllBenefits()
  }
}
</script>

<style scoped>
.container {
  padding: 0 15px;
}

.seller-form-editor {
  margin: 0px 20px;
}

.button {
  margin-bottom: 20px;
}

.container-combo-benefit div {
  display: inline-block;
  margin-right: 5px;
  margin-left: 5px;
  margin-top: 5px;
  margin-bottom: 5px;
}

.container-combo-benefit select {
  margin-top: 5px;
}

</style>
