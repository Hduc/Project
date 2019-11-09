import Vue from 'vue'
import Vuex from 'vuex'
Vue.use(Vuex)
import getters from './getters'
import mutations from './mutations'
import actions from './action'
export default new Vuex.Store({
    state: {
        tasks: [],
        newTask: '',
        notification: { group: 'foo', type: 'warn', title: 'thông báo', text: '', duration: 10000, speed: 1000 }
    },
    getters,
    mutations,
    actions
})
