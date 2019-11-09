<template>
  <div id="get-tasks">
    <form @submit.prevent="addTask">
      <input class="form-control" :value="newTask" @change="getTask" placeholder="I need to..." />
      <br />
      <button type="submit" class="btn btn-primary">
        <i class="fa fa-plus"></i> New Task
      </button>
    </form>
  </div>
</template>

<script>
import Vuex from "vuex";
export default {
  methods: {
    getTask(e) {
      this.$store.dispatch("getTask", e.target.value);
    },
    addTask(e) {
      this.$store.dispatch("addTask");
      this.$store.dispatch("clearTask");
      this.$store.dispatch("setNotifications", {
        type: "succ",
        text: "Thông báo <b>aa</b>"
      });
    }
  },
  computed: {
    newTask() {
      return this.$store.getters.newTask;
    }
  }
};
</script>