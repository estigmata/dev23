<template>
  <div id="app">
    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
html, body {
  font-family: 'Encode Sans Condensed', sans-serif;
  height: 100%;
  margin: 0;
  padding: 0;
  width: 100%;
}

*, *:after, *:before {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
}

#app {
  height: 100%;
  width: 100%;
  margin: 0;
  padding: 0;
}
</style>
