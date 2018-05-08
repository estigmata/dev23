import Vue from 'vue'
import VueI18n from 'vue-i18n'

import en from './en/en.json'
import es from './es/es.json'

Vue.use(VueI18n)

const i18n = new VueI18n({
  locale: navigator.language,
  messages: {
    'en-US': en,
    'es': es
  }
})

export default i18n
