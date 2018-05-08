<template>
  <div>
    <form ref="container"></form>
  </div>
</template>

<script>
import ElementToFactoryMap from './ElementToFactoryMap.js'

export default {
  props: ['model'],
  mounted () {
    const modelJson = JSON.parse(this.model)
    modelJson.elements.forEach(element => {
      const componentInstance = ElementToFactoryMap[element.type](element)
      this.$refs.container.appendChild(componentInstance.$el)
    })
  }
}
</script>

<style scoped lang="less">
  form {
    position: relative;
  }
</style>
