<template>
  <div class="panel">
    <sui-card class="fluid">
      <sui-card-content>
        <sui-image
         :src="advantage.promoter.image.imageSerialized"
         class="imageCard floated left"
         size="tiny"/>
        <sui-card-header>
          {{ advantage.promoter.name }}
        </sui-card-header>
        <sui-card-meta>
          <sui-icon size="standard"
           :name="advantage.promoter.category.icon"/>
          {{ advantage.promoter.category.name }}
        </sui-card-meta>
        <sui-card-header>
          {{ advantage.name }}
        </sui-card-header>
        <sui-card-meta>
          {{ advantage.mainText }}
        </sui-card-meta>
      </sui-card-content>
      <sui-card-content extra>
        <sui-container text-align="center">
          <sui-button-group>
            <sui-button basic>
              <sui-button-content @click="showCard('Info')">
                <sui-icon size="large" name="info circle" :class="{ active: selectedCard === 'Info' }"/>
              </sui-button-content>
            </sui-button>
            <sui-button basic>
              <sui-button-content @click="showCard('Stores')">
                <sui-icon size="large" name="home" :class="{ active: selectedCard === 'Stores' }"/>
              </sui-button-content>
            </sui-button>
            <sui-button basic>
              <sui-button-content @click="showCard('Contact')">
                <sui-icon size="large" name="user" :class="{ active: selectedCard === 'Contact' }"/>
              </sui-button-content>
            </sui-button>
          </sui-button-group>
        </sui-container>
      </sui-card-content>
    </sui-card>
    <sui-card class="details fluid info">
      <sui-card-content v-if="selectedCard === 'Info'">
        <sui-card-header>Description</sui-card-header>
        <sui-card-description>
          <label> {{ advantage.description }} </label>
        </sui-card-description>
        <sui-container class="section-tags">
          <sui-divider/>
          <sui-container >
            <h3 is="sui-header">Tags</h3>
          </sui-container>
          <div class="container-tags-detail">
            <div v-for="(tag, index) in advantage.promoter.promoterTag"
             :key='index'>
              <span> {{ tag.tag.name}} </span>
            </div>
          </div>
        </sui-container>
      </sui-card-content>
      <sui-card-content v-if="selectedCard === 'Stores'">
        <sui-card-description class="stores-card">
          <sui-header size="medium">Stores</sui-header>
          <sui-divider section />
          <sui-form v-for="store in advantage.promoter.stores"
           :key="store.id">
            <sui-form-field>
              <sui-header size="small">{{ store.name }}</sui-header>
            </sui-form-field>
            <sui-form-field>
              <label>Address:</label>
              <div>{{ store.address }}</div>
            </sui-form-field>
            <sui-form-field>
              <label>Telephone:</label>
              <div>{{ store.phone }}</div>
            </sui-form-field>
            <sui-divider/>
          </sui-form>
        </sui-card-description>
      </sui-card-content>
      <sui-card-content v-if="selectedCard === 'Contact'">
        <sui-card-description>
          <sui-header size="medium">Contact</sui-header>
          <sui-divider section />
        </sui-card-description>
        <sui-card-description>
          <sui-form>
            <sui-form-field>
              <label>Name:</label>
              <div>{{ advantage.promoter.contact.name }}</div>
            </sui-form-field>
            <sui-form-field>
              <label>Telephone:</label>
              <div>{{ advantage.promoter.contact.phone }}</div>
            </sui-form-field>
            <sui-form-field>
              <label>Email:</label>
              <div>{{ advantage.promoter.contact.email }}</div>
            </sui-form-field>
          </sui-form>
        </sui-card-description>
      </sui-card-content>
    </sui-card>
  </div>
</template>

<script>
export default {
  props: ['advantage'],
  data () {
    return {
      selectedCard: 'Info'
    }
  },
  methods: {
    showCard (cardName) {
      this.selectedCard = cardName
    }
  }
}
</script>

<style scoped>
.details {
  display: block;
}

.active {
  color: #2196F3;
}

.panel {
  width: 100%;
  height: 100%;
}

.info {
  max-height: 300px;
  overflow-x: hidden;
  overflow-y: auto;
}

.imageCard {
  max-width: 45%;
}

.stores-card form:last-child > div:last-child {
  display: none;
}

@media only screen and (max-width: 549px) {
  .details {
    height: auto;
  }
}

.section-tags {
  padding-bottom: 10px;
}

.section-tags sui-header {
  font-family: lato;
}

.container-tags-detail div {
  display: inline-block;
  padding-left: 10px;
  padding-right: 10px;
  background-color: #2196F3;
  margin-left: 2px;
  margin-right: 2px;
  margin-top: 2px;
  border-radius: 15px;
  color: white;
}
</style>
