import Vue from 'vue'
import App from './App'
import router from './router'
import store from './vuex/store'

new Vue({
  el: '#app',
  router,
  store,
  components: { App },
  template: '<App/>'
})
