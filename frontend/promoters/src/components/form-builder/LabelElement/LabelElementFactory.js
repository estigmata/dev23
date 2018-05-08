import Vue from 'vue'
import LabelElementComponent from './LabelElementComponent.vue'

export default function (labelModel) {
  const Component = Vue.extend(LabelElementComponent)
  const instance = new Component({
    propsData: {
      styles: labelModel.styles,
      text: labelModel.text
    }
  })
  instance.$mount()
  return instance
}
