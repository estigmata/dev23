<template>
  <div :style="containerStyle">
    <form ref="container"></form>
  </div>
</template>

<script>
import ElementToFactoryMap from './ElementToFactoryMap.js'

export default {
  props: ['model'],
  data () {
    return {
      containerStyle: {}
    }
  },
  watch: {
    model: function (value) {
      const modelJson = JSON.parse(value)
      this.containerStyle = modelJson.styles
      modelJson.elements.forEach(element => {
        const componentInstance = ElementToFactoryMap[element.type](element)
        this.$refs.container.appendChild(componentInstance.$el)
      })
    }
  }
}
</script>

<style scoped>
  form {
    position: relative;
  }
</style>
