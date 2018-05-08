<template>
  <sui-card>
    <sui-container class="container-card">
      <div @click="showBenefit(benefit.id)" class="left container-logo">
        <div v-show="isNew" class="ribbon">
          <span>NEW</span>
        </div>
        <div>
          <sui-image :src="logo" centered/>
        </div>
      </div>
      <div class="left container-info">
        <sui-card-content>
          <sui-card-header class="center aligned tittle">
            {{ tittle }}
          </sui-card-header>
          <div class="left container-status">
            <sui-icon name="clock outline font-icon" />
            <label v-bind:class="[isOpen.item1 ? 'label-open': 'label-close']">
                {{ isOpen.item2 }}
            </label>
          </div>
          <sui-card-description class="description">
            {{ mainText }}
          </sui-card-description>
          <div class="container-tags">
            <div v-for="(tag, index) in tags" v-if="index < 5" :key='index'>
              <span>{{ tag }}</span>
            </div>
            <div v-if="tags.length - 5 > 0">
              <span>+{{ tags.length - 5 }}</span>
            </div>
          </div>
        </sui-card-content>
        <div @click="showBenefit(benefit.id)" class="container-icon right floated">
          <icon name="info-circle" scale="1.5"></icon>
        </div>
      </div>
    </sui-container>
  </sui-card>
</template>

<script>
export default {
  props: ['benefit'],
  data () {
    return {
      logo: this.benefit.promoter.logo,
      description: this.benefit.description,
      tittle: this.benefit.promoter.name.toUpperCase(),
      mainText: this.benefit.mainText,
      isOpen: this.benefit.promoter.isOpen,
      tags: this.benefit.promoter.tags,
      isNew: this.benefit.isNew
    }
  },
  methods: {
    showBenefit (id) {
      this.$router.push({ name: 'benefit', params: { id: id } })
    }
  },
  filters: {
    truncate (value, limit = 37) {
      if (!value) return ''
      if (value.length > limit) {
        return value.slice(0, limit) + '...'
      }
      return value
    }
  }
}
</script>

<style scoped>

.card {
  width: 400px !important;
}
.card .image {
  height: auto;
  width: auto;
  max-width: 100%;
}

.card .container {
  display: flex !important;
  height: auto;
  border: none;
  position: relative;
  height: 215px;
  cursor: default;
}

.description {
  font-size: small;
  margin-top: 5px;
  margin-bottom: 5px;
}

.tittle {
  font-weight: bold;
  font-size: larger;
  margin: 10px;
}

.container-tags div {
  display: inline-block;
  padding-left: 15px;
  padding-right: 15px;
  background-color: #2196F3;
  margin-left: 2px;
  margin-right: 2px;
  margin-top: 2px;
  border-radius: 15px;
  color: white;
}

.container-tags div span {
  font-size: x-small;
}

.float {
  float: left;
  height: 45%;
  width: 100%;
  margin-bottom: -50px;
}

.container-info, .container-logo {
  width: 50%;
}

.container-logo {
  cursor: pointer;
  background-repeat: no-repeat;
  background-size: cover;
  padding-left: 5px;
}

.container-info {
  margin-left: 50px;
  position: relative;
}

.container-info .content {
  height: 100%;
}

.container-icon {
  bottom: 10px;
  cursor: pointer;
  position: absolute;
  right: 10px;
}

.container-status{
  margin-top: 5px;
  margin-bottom: 5px;
}

.container-status:after {
  clear: both;
  content: ".";
  display: block;
  height: 0;
}

.font-icon {
  font-weight: bolder;
}

.label-open {
  color: green;
  font-weight: bolder;
}

.label-close {
  color: red;
  font-weight: bolder;
}

.container-logo {
  position: relative;
}

.container-logo div {
  position: absolute;
  width: 100%;
  top: 50%;
  transform: translateY(-50%);
}

.ribbon {
  position: absolute;
  left: -5px;
  top: -5px;
  z-index: 1;
  overflow: hidden;
  width: 75px;
  height: 226px;
  text-align: right;
}

.ribbon span {
  font-size: 10px;
  font-weight: bold;
  color: #FFF;
  text-transform: uppercase;
  text-align: center;
  line-height: 20px;
  transform: rotate(-45deg);
  -webkit-transform: rotate(-45deg);
  width: 100px;
  display: block;
  background: #79A70A;
  background: linear-gradient(#9BC90D 0%, #79A70A 100%);
  box-shadow: 0 3px 10px -5px rgba(0, 0, 0, 1);
  position: absolute;
  top: 19px; left: -21px;
}

.ribbon span::before {
  content: "";
  position: absolute;
  left: 0px;
  top: 100%;
  z-index: -1;
  border-left: 3px solid #79A70A;
  border-right: 3px solid transparent;
  border-bottom: 3px solid transparent;
  border-top: 3px solid #79A70A;
}

.ribbon span::after {
  content: "";
  position: absolute;
  right: 0px;
  top: 100%;
  z-index: -1;
  border-left: 3px solid transparent;
  border-right: 3px solid #79A70A;
  border-bottom: 3px solid transparent;
  border-top: 3px solid #79A70A;
}

.container-card {
  margin: 0px !important;
}

@media (max-width: 480px) {
  .container-tags {
    display: none;
  }  
}

</style>
