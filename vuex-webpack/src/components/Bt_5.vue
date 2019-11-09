<template>
  <div>
    <button @click="changeTabs('login')">đăng nhập</button>
    <button @click="changeTabs('register')">đăng ký</button>
    <br />
    <div class="login" v-if="tabs=='login'">
      <form>
        <input type="text" />
        <input type="text" />
        <button type="submit">đăng nhập</button>
      </form>
    </div>
    <div class="register" v-else>
      <form>
        <input type="text" />
        <input type="text" />
        <button type="submit">đăng ký</button>
      </form>
    </div>
    <br />v-Show
    <label v-show="tabs=='login'">login</label>
    <label v-show="tabs=='register'">register</label>
  </div>
</template>
<script>
export default {
  data() {
    return {
      tabs: "login"
    };
  },
  methods: {
    changeTabs(e) {
      this.tabs = e;
    }
  }
};
</script>