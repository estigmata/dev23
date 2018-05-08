<template>
  <sui-grid class="welcome">
    <div class="menu-link"></div>
    <sui-grid-row>
      <sui-grid-column :width="1">
      </sui-grid-column>
      <sui-grid-column :width="5">
          <div class="message">
            <h2 is="sui-header">WELCOME TO ADVANTAGE</h2>
            <ul>
              <li>
                Create Benefit's Banner
              </li>
              <li>
                Add your Stores Information
              </li>
              <li>
                Create your own Schedule
              </li>
              <li>
                Add your contact Information
              </li>
            </ul>
          </div>
      </sui-grid-column>
    </sui-grid-row>
  </sui-grid>
</template>

<script>
export default {
  data () {
    return {
    }
  }
}
</script>

<style scoped>
.welcome {
  height: 78.4%;
  width: 100%;
  background-image: url('../assets/background.png');
  background-size: 100% 100%;
  margin:0;
  padding: 0;
  overflow-y: hidden;
  color: white;
}
.message {
  opacity: 0.6;
  color: black;
  background-color: transparent;
  width: 100%;
  height: 100%;
  font-size: 18px;
  line-height: 35px;
  font-family: 'Lato', sans-serif;
}
</style>
