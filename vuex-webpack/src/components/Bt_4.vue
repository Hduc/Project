<template>
  <div>
    <div
      class="demo"
      :class="{active:isActive,error:isError}"
      :style="{ color: activeColor, fontSize: fontSize + 'px' }"
    >ràng buộc class</div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      isActive: false,
      isError: true,
      activeColor: "red",
      fontSize: 40
    };
  }
};
</script>