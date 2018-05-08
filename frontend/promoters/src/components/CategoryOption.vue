<template>
  <sui-container @click="emitCategory()" class="category pointer">
    <sui-grid :columns="3">
      <sui-grid-row>
        <sui-grid-column :width="4">
          <sui-icon size="large" :name="category.icon" left/>
        </sui-grid-column >
        <sui-grid-column :width="8">
          <span>{{ category.name }}</span>
        </sui-grid-column>
        <sui-grid-column :width="3" v-show="category.newBenefitsQuantity !== 0">
          <div class="new-benefits">
            <span id="new-benefit-quantity">{{ category.newBenefitsQuantity }}</span>
          </div>
        </sui-grid-column>
      </sui-grid-row>
    </sui-grid>
  </sui-container>
</template>

<script>
export default {
  props: ['category'],
  methods: {
    emitCategory () {
      this.$emit('emitCategory', this.category.name)
    }
  }
}
</script>

<style scoped>
.new-benefits {
  background-color: #2185d0;
  height: 16px;
  width: 16px;
  border-radius: 4px;
  text-align: center;
}

#new-benefit-quantity {
  color: aliceblue;
}

.category:hover {
  background-color: #2185d0;
  color: white;
}

.category {
  padding-top: 10px;
}

.pointer {
  cursor: pointer;
}
</style>
