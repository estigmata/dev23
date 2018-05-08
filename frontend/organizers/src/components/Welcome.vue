<template>
  <sui-grid class="welcome">
    <sui-grid-row>
      <sui-grid-column :width="1">
      </sui-grid-column>
      <sui-grid-column :width="5">
          <div class="message">
            <h2 is="sui-header">WELCOME TO ADVANTAGE</h2>
            <ul>
              <li>
                Create forms
              </li>
              <li>
                Manage your Promoters
              </li>
              <li>
                Manage your Employees
              </li>
            </ul>
          </div>
      </sui-grid-column>
    </sui-grid-row>
  </sui-grid>
</template>

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
  margin-left: 20%;
  margin-top: 30%;
  font-size: 18px;
  line-height: 35px;
  font-family: 'Lato', sans-serif;
}
</style>
