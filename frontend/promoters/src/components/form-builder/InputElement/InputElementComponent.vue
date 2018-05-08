<template>
  <div>
    <input type="text" :style="styles">
  </div>
</template>

<script>
export default {
  name: 'LabelComponent',
  props: ['styles']
}
</script>

<style scoped>
  input {
    position: absolute;
  }
</style>
