<template>
  <sui-container>
    <sui-grid :columns="5">
      <template>
        <sui-grid-column v-for="(category, index) in categories" :key='index'>
          <category-option :category='category' @emitCategory="sendCategory"></category-option>
        </sui-grid-column>
      </template>
    </sui-grid>
  </sui-container>
</template>
<script>
import CategoryOption from './CategoryOption.vue'
export default {
  props: ['categories'],
  components: { CategoryOption },
  methods: {
    sendCategory (category) {
      this.$emit('emitCategory', category)
    }
  }
}
</script>
<style>

</style>
