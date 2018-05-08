<template>
  <sui-container>
    <sui-form @submit.prevent="validateBeforeSubmit">
      <sui-header size="medium">Company</sui-header>
      <sui-divider section />
      <sui-form-field>
        <label>Name</label>
        <input v-model="promoter.name"
          name="companyName"
          v-validate="'required|alpha_spaces'"
          :class="{'input': true, 'is-danger': errors.has('companyName')}"
          type="text"
          placeholder="Company Name">
        <div class="container-danger" v-show="errors.has('companyName')">
          <icon class="icon-danger" name="exclamation-triangle" scale="1"></icon>
          <span class="danger">{{ errors.first('companyName') }}</span>
        </div>
      </sui-form-field>
      <sui-form-field>
        <label>Category</label>
        <select v-model="category"
          name="companyCategory"
          v-validate="'required'"
          :class="{'input': true, 'is-danger': errors.has('companyCategory')}">
          <option disabled
            :value="category"
            :key="category.id">
              {{ category.name }}
          </option>
          <option v-for="category in categories"
            :value="category"
            :key="'c' + category.id">
              {{ category.name }}
          </option>
        </select>
        <div class="container-danger" v-show="errors.has('companyCategory')">
          <icon class="icon-danger" name="exclamation-triangle" scale="1"></icon>
          <span class="danger">{{ errors.first('companyCategory') }}</span>
        </div>
      </sui-form-field>
      <sui-form-field>
        <label>Logo</label>
        <ImagePicker :showPreview="true" ref="imagePickerComponent" @onImageLoad="onImageLoad"></ImagePicker>
        <div class="container-danger" v-show="!isValidImage">
          <icon class="icon-danger" name="exclamation-triangle" scale="1"></icon>
          <span class="danger">The image field is required.</span>
        </div>
      </sui-form-field>
      <sui-header size="medium">Contact</sui-header>
      <sui-divider section />
      <sui-form-field>
        <label>Name</label>
        <input v-model="promoter.contact.name"
          name="contactName"
          v-validate="'required|alpha_spaces'"
          :class="{'input': true, 'is-danger': errors.has('contactName')}"
          type="text"
          placeholder="Contact Name">
        <div class="container-danger" v-show="errors.has('contactName')">
          <icon class="icon-danger" name="exclamation-triangle" scale="1"></icon>
          <span class="danger">{{ errors.first('contactName') }}</span>
        </div>
      </sui-form-field>
      <sui-form-field>
        <label>Telephone</label>
        <input v-model="promoter.contact.phone"
          name="contactTelephone"
          v-validate="'required|numeric'"
          :class="{'input': true, 'is-danger': errors.has('contactTelephone')}"
          type="text"
          placeholder="Contact Telephone">
        <div class="container-danger" v-show="errors.has('contactTelephone')">
          <icon class="icon-danger" name="exclamation-triangle" scale="1"></icon>
          <span class="danger">{{ errors.first('contactTelephone') }}</span>
        </div>
      </sui-form-field>
      <sui-form-field>
        <label>Email</label>
        <input v-model="promoter.contact.email"
          name="contactEmail"
          v-validate="'required|email'"
          :class="{'input': true, 'is-danger': errors.has('contactEmail')}"
          type="text"
          placeholder="Contact Email">
        <div class="container-danger" v-show="errors.has('contactEmail')">
          <icon class="icon-danger" name="exclamation-triangle" scale="1"></icon>
          <span class="danger">{{ errors.first('contactEmail') }}</span>
        </div>
      </sui-form-field>
      <sui-form-field>
        <label>Keywords</label>
        <sui-container>
          <tags :suggestions="suggestions" :oldTags="oldTags" ref="tags"></tags>
        </sui-container>
      </sui-form-field>
      <sui-button class="form-button" type="submit">Save</sui-button>
    </sui-form>
    <sui-container>
      <notifications position="bottom right"/>
    </sui-container>
  </sui-container>
</template>
<script>
import { ImagePicker } from 'vue-components-advantage'
import TagsResource from '@/resources/TagsResource'
import CategoryResource from '@/resources/CategoryResource'
import PromoterResource from '@/resources/PromoterResource'
import UserResource from '@/resources/UserResource'
import EmailStorage from '@/resources/EmailStorage'
import Tags from '@/components/TagComponent'
export default {
  components: {
    ImagePicker,
    Tags
  },
  data () {
    return {
      categories: [],
      suggestions: [
        {
          data: []
        }
      ],
      promoter: {
        id: '',
        name: '',
        categoryID: '',
        contact: {
          id: '',
          name: '',
          phone: '',
          email: ''
        },
        image: {
          id: '',
          serializedImage: ''
        }
      },
      category: {},
      oldTags: [],
      isValidImage: true
    }
  },
  methods: {
    async validateBeforeSubmit () {
      try {
        const isFormValid = await this.$validator.validateAll()
        if (isFormValid && this.isValidImage) {
          this.promoter.categoryID = this.category.id
          this.promoter.promoterTag = this.$refs.tags.getTags()
          await TagsResource.deleteAllTags(this.promoter.id)
          await PromoterResource.updateProfile(this.promoter)
          this.$notify({
            title: 'Notification',
            text: 'The profile was updated successfully',
            type: 'success'
          })
        } else {
          this.$notify({
            title: 'Notification',
            text: 'The provided information contains errors',
            type: 'error'
          })
        }
      } catch (error) {
        console.error(error)
        this.$notify({
          title: 'Notification',
          text: 'The profile could not be updated due to an application error',
          type: 'error'
        })
      }
    },
    onImageLoad (imageObject) {
      const { imageBase64: image, isValid } = imageObject
      this.promoter.image.serializedImage = image
      this.isValidImage = isValid
    },
    async getAllCategories () {
      try {
        const { body: categories } = await CategoryResource.getAllCategories()
        this.categories = categories
      } catch (error) {
        console.error(error)
        this.$notify({
          title: 'Notification',
          text: 'The data categories could not be loaded.',
          type: 'error'
        })
      }
    },
    async getAllTags () {
      try {
        const { body: tag } = await TagsResource.getAllTags()
        this.suggestions[0].data = this.diffArray(tag, this.oldTags, (val1, val2) => {
          return val1.name === val2.name
        })
      } catch (error) {
        this.$notify({
          title: 'Notification',
          text: 'The data tags could not be loaded.',
          type: 'error'
        })
      }
    },
    async getPromoterProfile (userId) {
      try {
        const { body: promoter } = await PromoterResource.getProfile(userId)
        this.promoter = promoter
        this.category = promoter.category
        this.oldTags = promoter.tags
        this.$refs.tags.setTags(this.oldTags)
        if (promoter.image.imageSerialized !== '') {
          this.$refs.imagePickerComponent.loadImage(promoter.image.imageSerialized)
        }
      } catch (error) {
        console.error(error)
        this.$notify({
          title: 'Notification',
          text: 'The data information could not be loaded.',
          type: 'error'
        })
      }
    },
    async getUserId () {
      try {
        const email = EmailStorage.getEmail()
        const { body: userId } = await UserResource.getUserId(email)
        return userId
      } catch (error) {
        console.error(error)
        this.$notify({
          title: 'Notification',
          text: error,
          type: 'error'
        })
      }
    },
    async loadInformation () {
      const userId = await this.getUserId()
      await this.getAllCategories()
      await this.getPromoterProfile(userId)
      await this.getAllTags()
    },
    diffArray (arrayTag, arrayOldTag, condition) {
      arrayOldTag.forEach((tag) => {
        arrayTag.forEach((oldTag, index) => {
          if (condition(tag, oldTag)) {
            arrayTag.splice(index, 1)
          }
        })
      })
      return arrayTag
    }
  },
  mounted () {
    this.loadInformation()
  }
}
</script>

<style scoped>
  .title {
    width: 100%;
    text-align: center;
  }
  .danger {
    color: red;
  }
  .icon-danger {
    display: flex !important;
    color: red;
  }
  .container-danger {
    display: -webkit-box;
  }
  .form-button {
    background-color: #f2711c;
    color: #fff;
  }
  .form-button:hover {
    background-color: #f26202;
    color: #fff;
  }
</style>
