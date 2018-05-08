<template>
  <div>
    <GenericForm v-if="modelIsRetrieved" :model="model"></GenericForm>
  </div>
</template>

<script>
import FormResource from '../resources/FormResource'
import GenericForm from '../components/GenericForm'
export default {
  components: {
    GenericForm
  },
  data () {
    return {
      model: '',
      modelIsRetrieved: false
    }
  },
  methods: {
  },
  async mounted () {
    const id = this.$route.params.id
    try {
      const { body } = await FormResource.getForm(id)
      this.model = body
      this.modelIsRetrieved = true
    } catch (error) {
      console.error(error)
    }
  }
}
</script>

<style scoped>

</style>
