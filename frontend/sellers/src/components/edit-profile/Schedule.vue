<template>
  <sui-table-row v-if="editModeActive">
    <sui-table-cell textAlign="right" verticalAlign="middle">
      <input class="edit-schedule" v-model="from" />
      <input class="edit-schedule" v-model="to" />
    </sui-table-cell>
    <sui-table-cell textAlign="right" collapsing verticalAlign="middle">
      <sui-icon name="check circle outline" @click="saveEdit" />
      <sui-icon name="times circle outline" @click="cancelEdit" />
    </sui-table-cell>
  </sui-table-row>
  <sui-table-row v-else>
    <sui-table-cell textAlign="right" class="stack-span" verticalAlign="middle">
      <span>{{ range.from | hhmm }}</span>
      <span class="hide">-</span>
      <span>{{ range.to | hhmm }}</span>
    </sui-table-cell>
    <sui-table-cell textAlign="right" collapsing verticalAlign="middle">
      <sui-icon name="edit" @click="enterEditMode" />
      <sui-icon name="trash" @click="deleteRange"/>
    </sui-table-cell>
  </sui-table-row>
</template>

<script>
export default {
  props: [
    'range'
  ],
  data () {
    return {
      editModeActive: false,
      from: '',
      to: ''
    }
  },
  methods: {
    enterEditMode () {
      this.from = this.range.from.substring(0, 5)
      this.to = this.range.to.substring(0, 5)
      this.editModeActive = true
    },
    exitEditMode () {
      this.editModeActive = false
    },
    saveEdit () {
      this.exitEditMode()
      this.range.from = this.from
      this.range.to = this.to
      this.$emit('update:range', this.range)
    },
    cancelEdit () {
      this.exitEditMode()
      this.from = ''
      this.to = ''
    },
    deleteRange () {
      this.$emit('update:range', null)
    }
  },
  filters: {
    hhmm (time) {
      return time.substring(0, 5)
    }
  }
}
</script>

<style scoped>
.icon {
  cursor: pointer;
  font-size: 16px;
}

.icon:hover {
  color: #f60;
}

.edit-schedule {
  border: 1px solid #ccc;
  border-radius: 3px;
  height: 19px;
  width: 40px;
}

.stack-span span{
  display: contents;
}

@media (max-width: 1124px) {
  .hide {
    display: none !important;
  }
  .stack-span span{
    display: block;
  }
}
</style>
