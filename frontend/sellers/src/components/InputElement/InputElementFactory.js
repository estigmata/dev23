import Vue from 'vue'
import InputElementComponent from './InputElementComponent.vue'

export default function (inputModel) {
  const Component = Vue.extend(InputElementComponent)
  const instance = new Component({
    propsData: {
      styles: inputModel.styles
    }
  })
  instance.$mount()
  return instance
}
