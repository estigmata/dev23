<template>
  <div>
    <input type="text" :style="styles">
  </div>
</template>

<script>
export default {
  name: 'InputComponent',
  props: ['styles']
}
</script>

<style scoped lang="less">
  input {
    position: absolute;
  }
</style>
