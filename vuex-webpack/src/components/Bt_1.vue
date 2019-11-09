<template>
  <div class="index">
    <label>Giỏ hàng ({{CountCart}})</label>
    <label>tên sản phẩn :</label>
    <a :href="url" :target="target">{{ title }}</a>
    <br />
    <label>giá :</label>
    <span>{{ fomatPrice() }}</span>
    <br />
    <label>số lượng còn lại {{count}}</label>
    <label>màu sản phẩn:{{ projectColor }}</label>
    <button @click="ChangeColorProject('red')">red</button>
    <button @click="ChangeColorProject('yellow')">yellow</button>
    <button @click="ChangeColorProject('gray')">gray</button>
  </div>
</template>

<script>
export default {
  data() {
    return {
      price: 10000,
      title: "Iphone Xs Max",
      url: "https://viblo.asia/p/vuex-va-vi-du-don-gian-GrLZDpzgZk0",
      target: "_bland",
      count: 0,
      projectColor: "",
      CountCart: 0,
      project: {
        red: 8,
        yellow: 5,
        gray: 0
      }
    };
  },
  methods: {
    fomatPrice() {
      console.log(this);
      return new Intl.NumberFormat("de-DE", {
        style: "currency",
        currency: "VND"
      }).format(this.price);
    },
    ChangeColorProject(e) {
      this.projectColor = e;
      this;
    }
  }
};
</script>
