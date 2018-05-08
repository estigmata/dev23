<template>
  <div class="container-main-navbar">
    <span class="user-profile" @click="displayRole">
      <img src="@/assets/default-avatar.jpg"
        class="ui avatar image" />
    </span>
    <div class="user-profile role" :class="{ show: show }">
      <b>Role:</b> Organizer
      <br />
      <b>{{ userEmail }}</b>
      <sui-divider />
      <span class="button-logout">
        <a class="logout sm" @click="logout">Log out</a>
      </span>
    </div>
    <div class="protected" :class="{ show: show }"></div>
    <div class="over-screen"
      :class="{ show: show }"
      @mouseover="displayRole"></div>
    <div class="ui inverted menu container-navbar">
      <div class="ui inverted left segment menu">
        <div class="ui inverted secondary menu">
          <img src="@/assets/advantage.svg" class="container-logo">
        </div>
      </div>
    </div>
    <div class="ui inverted pointing menu container-navbar">
      <div class="left menu">
        <router-link class="menu-link" to="/">
          <a class="item green"
          :class="{ active: activeButton === 'home' }"
          @click="selectNavbarButton('home')">
            Home
          </a>
        </router-link>
        <router-link class="menu-link" to="/form-editor">
          <a class="item green"
          :class="{ active: activeButton === 'form-editor' }"
          @click="selectNavbarButton('form-editor')">
            Form Editor
          </a>
        </router-link>
        <router-link class="menu-link" to="/sellers">
          <a class="item green"
          :class="{ active: activeButton === 'sellers' }"
          @click="selectNavbarButton('sellers')">
            Sellers
          </a>
        </router-link>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: ['userEmail'],
  data () {
    return {
      activeButton: 'home',
      show: false
    }
  },
  methods: {
    selectNavbarButton (tab) {
      this.activeButton = tab
    },
    logout () {
      localStorage.clear()
      window.location.href = `${process.env.CLIENT_URL}/login`
    },
    displayRole () {
      this.show = !this.show
    }
  },
  mounted () {
    switch (this.$route.name) {
      case 'SellersPage':
        this.activeButton = 'sellers'
        break
      case 'FormEditor':
        this.activeButton = 'form-editor'
        break
    }
  }
}
</script>

<style scoped>
  .title {
    width: 100%;
    text-align: center;
    color: white;
  }
  .navbar {
    background-color: green;
  }
  .router-container {
    margin-top: 5px;
  }

  .container-main-navbar {
    margin-bottom: 10px;
  }

  .container-navbar {
    border-radius: 0;
    margin: 0;
  }

  .container-logo {
    width: 220px;
  }

  .navbar-top span {
    float: right;
    padding-right: 10px;
    color: white;
    font-weight: bold;
  }

  .navbar-top span a {
    color: white;
    text-decoration-style: none;
  }

  .user-profile {
    cursor: default;
    position: absolute;
    top: 20px;
    right: 10px;
  }

  .user-profile img {
    border: 2px solid #666;
    border-radius: 50%;
    padding: 1px;
    height: 35px;
    width: 35px;
  }

  .user-profile.role {
    border: 1px solid #eee;
    background-color: #ddd;
    border-radius: 3px;
    display: none;
    font-size: 13px;
    padding: 10px;
    position: absolute;
    top: 55px;
    z-index: 1000;
  }

  .user-profile.role.show,
  .over-screen.show,
  .protected.show {
    display: block;
  }

  .protected {
    display: none;
    height: 150px;
    position: absolute;
    right: 0;
    width: 150px;
    z-index: 50;
  }

  .over-screen {
    display: none;
    position: fixed;
    padding:0;
    margin:0;

    top:0;
    left:0;

    width: 100%;
    height: 100%;
    z-index: 10;
  }

  .user-profile.role.show::after {
    content: '';
    position: absolute;
    top: 0%;
    right: 5%;
    margin-left: -8px;
    margin-top: -8px;
    width: 0; height: 0;
    border-bottom: 8px solid #ddd;
    border-right: 8px solid transparent;
    border-left: 8px solid transparent;
  }

  .button-logout {
    cursor: pointer;
    float: right;
  }

  .logout.sm {
    background-color: #db2828;
    border-radius: 3px;
    color: #ddd;
    font-size: 13px;
    height: 25px;
    line-height: 25px;
    padding: 5px 15px;
  }

  .logout.sm:hover {
    color: #fff;
  }

  .divider.ui {
    margin: 5px 0;
  }
</style>
