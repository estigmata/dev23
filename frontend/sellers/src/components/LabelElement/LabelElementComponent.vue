<template>
  <div>
    <label :style="styles">{{ text }}</label>
  </div>
</template>

<script>
export default {
  name: 'LabelComponent',
  props: ['styles', 'text']
}
</script>

<style scoped lang="less">
  label {
    position: absolute;
  }
</style>
