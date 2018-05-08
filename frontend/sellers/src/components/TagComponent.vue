<template>
  <div>
    <div v-show="isTagEnable" @click="onTagClick" class="container-add-tag">
        <span>Add tag</span>
      </div>
    <div v-show="!isTagEnable" class="container-autocomplete">
      <vue-autosuggest
      :suggestions="filteredOptions"
      @focus="onTagFocus"
      @keyup="onTagKeyUp"
      :onSelected="onTagSelected"
      :renderSuggestion="renderSuggestion"
      :getSuggestionValue="getSuggestionValue"
      :inputProps="{ onInputChange: this.onInputChange,
        autocomplete: 'off',
        placeholder: 'Tags',
        autofocus: !isTagEnable }"/>
    </div>
    <div class="container-tags">
      <div :tabindex=index v-for="(tag, index) in newTags" :key="'nt' + index" @keyup="deleteTag">
        <span>{{ tag.name }}</span>
      </div>
    </div>
  </div>
</template>

<script>
import { constants } from '@/components/edit-profile/constants/PromoterInformationConstants.js'
export default {
  props: [
    'suggestions'
  ],
  data () {
    return {
      newTags: [],
      isTagEnable: true,
      filteredOptions: [],
      text: ''
    }
  },
  methods: {
    onInputChange (text, oldText) {
      this.text = text
      const filteredData = this.filterData()
      this.filteredOptions = [{ data: filteredData }]
    },
    onTagSelected (item) {
      if (item !== null) {
        var tagExistInNewTags = false
        const { item: newTag } = item
        tagExistInNewTags = this.newTags.some((tag) => {
          return tag.name === newTag.name
        })
        if (tagExistInNewTags === false) {
          this.newTags.push(newTag)
          var index = this.suggestions[0].data.indexOf(newTag)
          if (index !== -1) {
            this.suggestions[0].data.splice(index, 1)
          }
          this.isTagEnable = !this.isTagEnable
        }
      }
    },
    renderSuggestion (suggestion) {
      const character = suggestion.item
      return (
        <div class="container-suggestion">
          <span>{ character.name }</span>
        </div>
      )
    },
    getSuggestionValue () {
      return ''
    },
    onTagFocus () {
      const filteredData = this.filterData()
      this.filteredOptions = [{ data: filteredData }]
    },
    onTagKeyUp (event) {
      if (event.keyCode === constants.ENTER_KEY_CODE) {
        var text = this.text.toUpperCase()
        var tagExistInNewTags = false
        var tagExistInSuggestionsTags = false
        var indexTagSuggestions
        if (text !== '') {
          const newTag = {
            id: -1,
            name: text
          }
          tagExistInNewTags = this.newTags.some((tag) => {
            return tag.name === newTag.name
          })
          tagExistInSuggestionsTags = this.suggestions[0].data.some((tag, index) => {
            if (tag.name === newTag.name) {
              newTag.id = tag.id
              indexTagSuggestions = index
              return tag.name === newTag.name
            }
          })
          if (tagExistInSuggestionsTags && tagExistInNewTags === false) {
            this.newTags.push(newTag)
            this.suggestions[0].data.splice(indexTagSuggestions, 1)
          } else if (tagExistInNewTags === false) {
            this.newTags.push(newTag)
          }
          this.isTagEnable = !this.isTagEnable
        }
      }
    },
    filterData () {
      return this.suggestions[0].data.filter(option => {
        return option.name.toLowerCase().indexOf(this.text.toLowerCase()) > -1
      })
    },
    onTagClick () {
      this.isTagEnable = !this.isTagEnable
    },
    getTags () {
      return this.newTags.map(({ id, name }) => {
        return {
          tagId: id,
          ...((id === -1) ? { tag: { name } } : {})
        }
      })
    },
    setTags (oldTags) {
      this.newTags = oldTags
    },
    deleteTag (event) {
      if (event.keyCode === constants.SUPR_KEY_CODE) {
        const tag = event.target.innerText
        this.newTags.forEach((tags, index) => {
          if (tags.name === tag) {
            if (tags.id !== -1) {
              this.suggestions[0].data.push(tags)
            }
            this.newTags.splice(index, 1)
          }
        })
      }
    }
  }
}
</script>

<style>
  .container-autocomplete {
    width: 200px;
  }
  .autosuggest__results-container {
    background-color: white;
  }
  .autosuggest__results-container ul {
    margin: 0;
    padding: 0;
    list-style: none;
    border: 1px solid black;
    max-height: 150px;
    overflow-y: auto;
  }
  .autosuggest__results-container ul li {
    padding: 5px;
    padding-left: 10px;
  }
  .autosuggest__results-container ul li:hover {
    background-color: gray;
    cursor: pointer;
  }
  .container-add-tag {
    display: inline-block;
    padding-left: 10px;
    padding-right: 10px;
    padding-top: 5px;
    padding-bottom: 5px;
    background-color: #e0e1e2;
    cursor: default;
    margin-left: 2px;
    margin-right: 2px;
    margin-bottom: 5px;
  }
  .container-add-tag:hover {
    background-color: #cacbcd;
    cursor: pointer;
  }
  .container-add-tag span {
    font-weight: 700;
  }
  .container-tags div {
    display: inline-block;
    padding-left: 10px;
    padding-right: 10px;
    padding-top: 5px;
    padding-bottom: 5px;
    background-color: #e0e1e2;
    cursor: pointer;
    margin-left: 2px;
    margin-right: 2px;
    margin-bottom: 3px;
    margin-top: 3px;
  }
  .container-tags div:hover {
    background-color: #cacbcd;
  }
</style>
