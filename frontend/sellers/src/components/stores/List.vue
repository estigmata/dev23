<template>
  <sui-container>
    <sui-form>
      <sui-grid>
        <sui-grid-row :columns="4">
          <sui-grid-column :width="5">
            <sui-form-field :class="{ 'error': errors.has('name') }">
              <p>
                <input id="storeName"
                  name="name"
                  placeholder="Store No."
                  ref="name"
                  tabindex="1"
                  @focus="getStoreNewName"
                  v-model="name"
                  v-validate="'required'"
                  :class="{'input': true, 'error': errors.has('name') }" />
                  <span v-show="errors.has('name')" class="ui pointing red basic label">
                    {{ errors.first('name') }}
                  </span>
              </p>
            </sui-form-field>
          </sui-grid-column>
          <sui-grid-column :width="6">
            <sui-form-field :class="{ 'error': errors.has('address') }">
              <p>
                <input name="address"
                  placeholder="Address"
                  ref="address"
                  tabindex="2"
                  type="text"
                  v-model="address"
                  v-validate="'required'" />
                <span v-show="errors.has('address')" class="ui pointing red basic label">
                  {{ errors.first('address') }}
                </span>
              </p>
            </sui-form-field>
          </sui-grid-column>
          <sui-grid-column :width="3">
            <sui-form-field :class="{ 'error': errors.has('phone') }">
              <p>
                <input name="phone"
                  placeholder="Phone"
                  ref="phone"
                  tabindex="3"
                  v-model="phone"
                  v-validate="'numeric|min:7|max:8'" />
                <span v-show="errors.has('phone')" class="ui pointing red basic label">
                  {{ errors.first('phone') }}
                </span>
              </p>
            </sui-form-field>
          </sui-grid-column>
          <sui-grid-column :width="2">
            <sui-button-group>
              <sui-button color="green" :disabled="!isComplete" icon="check" @click="validateBeforeSubmit" />
              <sui-button color="red" icon="times" @click="clearForm" />
            </sui-button-group>
          </sui-grid-column>
        </sui-grid-row>
        <table class="ui red table selectable">
          <thead>
            <tr>
              <th>
                Name
              </th>
              <th>
                Address
              </th>
              <th>
                Phone
              </th>
            </tr>
          </thead>
          <tbody v-for="store in stores" :key="store.id">
            <tr>
              <td>{{ store.name }}</td>
              <td>{{ store.address }}</td>
              <td>{{ store.phone }}</td>
            </tr>
          </tbody>
        </table>
      </sui-grid>
    </sui-form>
  </sui-container>
</template>

<script>
import Email from '@/resources/EmailStorage'
import Users from '@/resources/UserResource'
import Promoter from '@/resources/PromoterResource'
import Stores from '@/resources/Stores'

export default {
  data () {
    return {
      stores: [],
      name: '',
      address: '',
      phone: '',
      promoterId: ''
    }
  },
  methods: {
    isStoreNameDuplicate () {
      return this.stores.find(store => store.name === this.name)
    },
    async getPromoterId () {
      const email = Email.getEmail()
      const { body } = await Users.getUserId(email)
      const profile = await Promoter.getProfile(body)
      const promoter = profile.json()
      return promoter
    },
    async getListOfStores () {
      const stores = await Stores.getAllStores(this.promoterId)
      return stores.json()
    },
    getStoreNewName () {
      if (this.name === '') {
        this.name = 'Sucursal ' + (this.stores.length + 1)
      }
      this.errors.clear()
    },
    clearFields () {
      this.name = ''
      this.address = ''
      this.phone = ''
    },
    clearForm (event) {
      event.preventDefault()
      this.clearFields()
      this.$validator.reset()
      this.$refs.name.focus()
    },
    async validateBeforeSubmit (event) {
      event.preventDefault()
      const validate = await this.$validator.validateAll()
      if (validate && !this.isStoreNameDuplicate()) {
        const newStore = {
          name: this.name,
          address: this.address,
          phone: this.$refs.phone.value
        }
        const response = await Stores.save(this.promoterId, newStore)
        try {
          this.stores.push(response.body)
          this.clearFields()
          this.$validator.reset()
        } catch (error) {
          console.error(error)
        }
        this.$refs.name.focus()
      }
    }
  },
  computed: {
    isComplete () {
      return !this.isStoreNameDuplicate() && this.name && this.address
    }
  },
  async mounted () {
    try {
      this.promoterId = (await this.getPromoterId()).id
    } catch (error) {
      console.error(error)
    }
    try {
      this.stores = await this.getListOfStores()
    } catch (error) {
      console.error(error)
    }
    this.$refs.name.focus()
  }
}
</script>
