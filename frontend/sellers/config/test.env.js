'use strict'
const merge = require('webpack-merge')
const devEnv = require('./dev.env')

module.exports = merge(devEnv, {
  NODE_ENV: '"testing"',
  BASE_URL: '"http://10.28.115.118:52103/api/v1"',
  CLIENT_URL: '"http://10.28.115.118"'
})
