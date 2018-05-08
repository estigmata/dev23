<template>
  <div>
    <sui-form>
      <sui-form-field required>
        <label>Name</label>
        <input v-model="name"
          type="text"
          name="benefitName"
          v-validate="'required'"
          :class="{'input': true, 'is-danger': errors.has('benefitName')}"
          placeholder="Enter Benefit Name" >
        <span v-show="errors.has('benefitName')" class="ui pointing red basic label">
          {{ errors.first('benefitName') }}
        </span>
      </sui-form-field>
      <sui-form-field required>
        <label>Description</label>
        <textarea v-model="description"
          name="benefitDescription"
          v-validate="'required'"
          :class="{'input': true, 'is-danger': errors.has('benefitDescription')}"
          placeholder="Enter a description for the benefit" rows="5" maxlength="300"></textarea>
        <span v-show="errors.has('benefitDescription')" class="ui pointing red basic label">
          {{ errors.first('benefitDescription') }}
        </span>
      </sui-form-field>
      <sui-form-field required>
        <label>Main Text (This information will be show in catalogue)</label>
        <textarea v-model="mainText"
          name="benefitMainText"
          v-validate="'required'"
          :class="{'input': true, 'is-danger': errors.has('benefitMainText')}"
          placeholder="Enter a main text" rows="2" maxlength="90"></textarea>
        <span v-show="errors.has('benefitMainText')" class="ui pointing red basic label">
          {{ errors.first('benefitMainText') }}
        </span>
      </sui-form-field>
      <sui-form-field required>
        <label>Status</label>
        <sui-dropdown
          placeholder="Status"
          selection
          :options="options"
          v-model="status"
        />
      </sui-form-field>
    </sui-form>
  </div>
</template>

<script>
export default {
  props: ['benefit'],
  data () {
    return {
      name: '',
      description: '',
      status: 1,
      mainText: '',
      options: [{
        text: 'Active',
        value: 1
      },
      {
        text: 'Inactive',
        value: 0
      }]
    }
  },
  methods: {
    getModel () {
      const model = {
        name: this.name,
        description: this.description,
        status: this.status,
        mainText: this.mainText
      }

      return model
    }
  },
  watch: {
    benefit () {
      if (this.benefit) {
        this.name = this.benefit.name
        this.description = this.benefit.description
        this.status = this.benefit.status ? 1 : 0
        this.mainText = this.benefit.mainText
      } else {
        this.name = ''
        this.description = ''
        this.status = ''
        this.mainText = ''
        this.$validator.reset()
      }
    }
  }
}
</script>

<style scoped>
  textarea {
    resize: none !important;
  }
  .danger {
    color: #f42f0c;
  }
  .icon-danger {
    display: flex !important;
    color: #f42f0c;
  }
  .container-danger {
    display: -webkit-box;
    margin: 5px;
  }
</style>
