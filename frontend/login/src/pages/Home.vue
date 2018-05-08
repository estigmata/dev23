<template>
  <sui-container class="login-page">
    <sui-container class="login-container">
      <img src="../assets/advantage.svg">
      <sui-grid>
        <sui-grid-row>
          <sui-grid-column left>
            <sui-form @submit.prevent="login">
              <sui-form-field :class="{ 'error': errors.has('email') }">
                <label>Email</label>
                <input
                  name="email"
                  placeholder="example@jalasoft.com"
                  v-model="email"
                  v-validate.disable="'required|email'"
                  :class="{ 'input': true, 'error': errors.has('email') }" />
                  <span v-show="errors.has('email')" class="ui pointing red basic label">
                    {{ errors.first('email') }}
                  </span>
              </sui-form-field>
              <sui-form-field :class="{ 'error': errors.has('email') }">
                <label>Password</label>
                <input
                  name="password"
                  v-model="password"
                  type="password"
                  v-validate.disable="'required|min:7'"
                  :class="{ 'input': true, 'error': errors.has('password') }" />
                  <span v-show="errors.has('password')" class="ui pointing red basic label">
                    {{ errors.first('password') }}
                  </span>
              </sui-form-field>
              <sui-button class="button-login" :disabled="!isFormComplete">Sign in</sui-button>
            </sui-form>
            <sui-divider hidden/>
          </sui-grid-column>
        </sui-grid-row>
      </sui-grid>
    </sui-container>
    <sui-container>
      <notifications position="bottom right"/>
    </sui-container>
  </sui-container>
</template>

<script>
import UserResource from '../resources/UserResource'
export default {
  data () {
    return {
      email: '',
      password: '',
      dictionary: {
        en: {
          messages: {
            min () {
              return 'The password must be at least 7 characters.'
            },
            email () {
              return 'The email must be valid.'
            }
          }
        }
      }
    }
  },
  methods: {
    async login (event) {
      event.preventDefault()
      const isValid = await this.$validator.validateAll()
      if (isValid) {
        try {
          const {body} = await UserResource.getHomePageUrl(this.email, this.password)
          localStorage.setItem('userId', body.id)
          localStorage.setItem('url', body.url)
          localStorage.setItem('role', body.name)
          window.location.href = `${body.url}/#/?email=${this.email}`
        } catch (err) {
          this.$notify({
            text: 'That user is not registered',
            type: 'error'
          })
          console.log(err)
        }
      }
    }
  },
  computed: {
    isFormComplete () {
      return this.email && this.password
    }
  },
  mounted () {
    if (localStorage.getItem('userId')) {
      window.location.href = localStorage.getItem('url')
    } else {
      this.$validator.localize(this.dictionary)
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.login-container {
  width: 30%;
  top: 40%;
  left: 50%;
  transform: translate(-50%, -50%);
  position: absolute;
}

.button-login {
  background: black;
  color: white;
}

.button-login:hover {
  background: #F2711C;
  color: white;
}

.login-page {
  width: 100%;
  height: 100%;
  background-image: url("../assets/background-login.jpg");
  background-size: cover;
}
</style>
