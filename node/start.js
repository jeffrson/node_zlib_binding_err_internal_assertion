'use strict'

const WebSocket = require('ws')
const ws = new WebSocket('ws://127.0.0.1:8888/svc')

ws.onopen = function(event) {
  ws.onmessage = function(event) {
    console.log(event.data)
  }
}
