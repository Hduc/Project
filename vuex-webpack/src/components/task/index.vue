<template>
  <div class="container-fuild">
    <br />
    <div class="row">
      <div class="col-md-6">
        <ListTask></ListTask>
      </div>
      <div class="col-md-6">
        <CompletedTask></CompletedTask>
      </div>
    </div>
    <GetTask></GetTask>
    <notifications group="foo" />
    <button @click="noti">click noti</button>
  </div>
</template>

<script>
import Vue from "vue";
import Notifications from "vue-notification";
import GetTask from "./GetTask.vue";
import ListTask from "./ListTask.vue";
import CompletedTask from "./CompletedTask.vue";
Vue.use(Notifications);
export default {
  components: {
    GetTask,
    ListTask,
    CompletedTask
  },
  methods: {
    noti() {
      this.$notify({
        group: "foo",
        type: "succ",
        title: "thông báo",
        text: "ssss",
        duration: 4000,
        speed: 1000
      });
    }
  },
  watch: {}
};
</script>

<style>
body {
  font-family: Helvetica, sans-serif;
}

.logo-title {
  font-weight: bold;
}

.my-task {
  color: #f4f7f9 !important;
  background-color: #656c7a !important;
}

.my-completed {
  color: #f4f7f9 !important;
  background-color: #656c7a !important;
}
.task-length {
  float: right !important;
}

.completed-length {
  float: right !important;
}

.list-group-item {
  background-color: wheat;
}

.complete-list {
  background-color: #26bf0a !important;
}

.remove-completed {
  float: right !important;
}

.slide-fade-enter-active {
  transition: all 0.3s ease;
}

.slide-fade-leave-active {
  transition: all 0.8s cubic-bezier(1, 0.5, 0.8, 1);
}

.slide-fade-enter, .slide-fade-leave-to
  /* .slide-fade-leave-active below version 2.1.8 */ {
  transform: translateX(10px);
  opacity: 0;
}
</style>