<template>
  <div>
    <div class="container-main-navbar">
      <span class="user-profile" @click="displayRole">
        <img src="@/assets/default-avatar.jpg"
          class="ui avatar image" />
      </span>
      <div class="user-profile role" :class="{ show: show }">
        <b>Role:</b> Employee
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
      <div v-if="!hideMenuBar"
      class="ui inverted pointing menu container-navbar">
        <div class="left menu">
          <div class="mega-dropdown">
            <a class="item blue">
              Categories
              <i class="dropdown icon"></i>
            </a>
            <div class="megamenu">
              <category-list
               :categories="categories"
               @emitCategory="getCategory"
               class="categories">
              </category-list>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import CategoryList from '@/components/CategoryList'
export default {
  components: { CategoryList },
  data () {
    return {
      activeButton: 'home',
      show: false
    }
  },
  props: ['categories', 'hideMenuBar', 'userEmail'],
  methods: {
    getCategory (category) {
      if (this.$route.path !== '/') {
        this.$router.push({ name: 'home', query: { category } })
      }
      this.$router.push({ query: Object.assign({}, this.$route.query, { category: encodeURIComponent(category) }) })
    },
    selectNavbarButton (button) {
      this.activeButton = button
    },
    logout () {
      localStorage.clear()
      window.location.href = `${process.env.CLIENT_URL}/login`
    },
    displayRole () {
      this.show = !this.show
    }
  }
}
</script>

<style scoped>
  .title {
    width: 100%;
    text-align: center;
    color: white;
    padding-top: 10px;
  }

  .navbar-top {
    background-color: #2196F3;
    height: 50px;
    line-height: 50px;
  }

  .router-container {
    margin-top: 5px;
  }

  .megamenu {
    background-color: #EFEFEF;
    position: absolute;
    left: 0;
    display: none;
    margin-top: -5px;
    width: 100%;
    border: 1px solid black;
    box-sizing: border-box;
    height: 20%;
    padding-top: 10px;
    overflow: auto;
  }

  .mega-dropdown:hover > .megamenu {
    display: block;
    z-index: 100;
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
    font-weight: bolder;
    cursor: pointer;
    color: white;
    float: right;
    margin-right: 10px;
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
    width: 35 px;
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
