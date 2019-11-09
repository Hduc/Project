<template>
  <div>
    {{counter}}
    <button @click="btnClick()">add</button>
  </div>
</template>
<script>
export default {
  data() {
    return {
      counter: 0
    };
  },
  methods: {
    btnClick() {
      this.counter++;
    }
  }
};
</script>