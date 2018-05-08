<template>
  <div>
    <select v-model="selectedForm">
      <option v-for="form in forms" :key="form.id" :value="form.id">
        {{ form.name }}
      </option>
    </select>
    <div>
      <button @click="generateForm(selectedForm)" :disabled="selectedForm === null">Go to Form</button>
    </div>
  </div>
</template>

<script>
import FormResource from '../resources/FormResource'
export default {
  data () {
    return {
      selectedForm: null,
      forms: []
    }
  },
  methods: {
    generateForm (formId) {
      this.$router.push({name: 'Form', params: { id: formId }})
    }
  },
  async mounted () {
    try {
      const { body } = await FormResource.getAllForms()
      this.forms = body
    } catch (error) {
      console.error(error)
    }
  }
}
</script>

<style scoped lang="less">

</style>
