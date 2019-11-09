<template>
  <div>
    <div class="cart" @mousemove="handleCartMouseMove">
      <p>clientX={{clientX}}</p>
      <br />
      <p>clientX={{clientY}}</p>
      <div class="cart-child" @mousemove.stop="handleCartMouseMoveChild"></div>
    </div>
    <form action @submit.prevent="handleSumitForm">
      <input type="text" name="userName" v-model="userName" />
      <input type="text" name="pass" v-model="passWord" />
      <button type="submit" @keyup.13="submit">Gửi</button>
    </form>
    xin chào {{ userName}}
  </div>
</template>
<script>
export default {
  data() {
    return {
      clientX: 0,
      clientY: 0,
      userName: "",
      passWord: ""
    };
  },
  methods: {
    handleSumitForm(e) {
      console.log(e);
    },
    handleCartMouseMove(e) {
      console.log(e);
      this.clientX = e.clientX;
      this.clientY = e.clientY;
    },
    handleCartMouseMoveChild(e) {
      console.log("child " + e);
    }
  }
};
</script>
<style >
.cart {
  width: 200px;
  height: 200px;
  position: relative;
  background-color: blue;
}
.cart-child {
  width: 50px;
  height: 50px;
  position: absolute;
  top: 0;
  right: 0;
  background-color: red;
}
</style>
