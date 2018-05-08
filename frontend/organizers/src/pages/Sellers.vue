<template>
  <div>
    <h3>Client list</h3>
    <sui-container>
      <sui-table celled class="green">
        <sui-table-header>
          <sui-table-row>
            <sui-table-header-cell class="collapsing">
              Company name
              <i class="caret up icon" @click="sortSellersBy('company', 'asc')"></i>
              <i class="caret down icon" @click="sortSellersBy('company', 'desc')"></i>
            </sui-table-header-cell>
            <sui-table-header-cell class="collapsing">
              Phone
              <i class="caret up icon" @click="sortSellersBy('phone', 'asc')"></i>
              <i class="caret down icon" @click="sortSellersBy('phone', 'desc')"></i>
            </sui-table-header-cell>
            <sui-table-header-cell class="collapsing">
              Address
              <i class="caret up icon" @click="sortSellersBy('address', 'asc')"></i>
              <i class="caret down icon" @click="sortSellersBy('address', 'desc')"></i>
            </sui-table-header-cell>
            <sui-table-header-cell class="collapsing">
              Contact name
              <i class="caret up icon" @click="sortSellersBy('contact', 'asc')"></i>
              <i class="caret down icon" @click="sortSellersBy('contact', 'desc')"></i>
            </sui-table-header-cell>
          </sui-table-row>
        </sui-table-header>

        <sui-table-body v-if="sellersList.length">
          <sui-table-row v-for="seller in sellersList" :key="seller.id">
            <sui-table-cell>{{ seller.company }}</sui-table-cell>
            <sui-table-cell>{{ seller.phone }}</sui-table-cell>
            <sui-table-cell>{{ seller.address }}</sui-table-cell>
            <sui-table-cell>{{ seller.contact }}</sui-table-cell>
          </sui-table-row>
        </sui-table-body>
      </sui-table>
    </sui-container>
  </div>
</template>

<script>
import SellerServices from '@/resources/Sellers.js'

export default {
  data () {
    return {
      sellersList: []
    }
  },
  methods: {
    sortSellersBy (fieldname, asc) {
      if (asc === 'asc') {
        this.sellersList.sort((previousElement, nextElement) => {
          if (fieldname === 'phone') {
            return ((previousElement[fieldname] < nextElement[fieldname]) ? -1
              : ((previousElement[fieldname] > nextElement[fieldname]) ? 1 : 0))
          } else {
            return ((previousElement[fieldname].toUpperCase() < nextElement[fieldname].toUpperCase()) ? -1
              : ((previousElement[fieldname].toUpperCase() > nextElement[fieldname].toUpperCase()) ? 1 : 0))
          }
        })
      } else {
        this.sellersList.sort((previousElement, nextElement) => {
          if (fieldname === 'phone') {
            return ((previousElement[fieldname] < nextElement[fieldname]) ? 1
              : ((previousElement[fieldname] > nextElement[fieldname]) ? -1 : 0))
          } else {
            return ((previousElement[fieldname].toUpperCase() < nextElement[fieldname].toUpperCase()) ? 1
              : ((previousElement[fieldname].toUpperCase() > nextElement[fieldname].toUpperCase()) ? -1 : 0))
          }
        })
      }
    },
    async getSellers () {
      try {
        const {body} = await SellerServices.getAll()
        this.sellersList = body
      } catch (error) {
        console.log(error)
      }
    }
  },
  mounted () {
    this.getSellers()
  }
}
</script>

<style scoped>
h3 {
  text-align: center;
}

.caret.up.icon,
.caret.down.icon {
  cursor: pointer;
}

th.collapsing {
  background: #eee !important;
}
</style>
