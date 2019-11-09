<template>
  <div>
    <ul>
      <li v-for="(value,key) in listdata" :key="key">Môn {{key}}:{{value}}</li>
    </ul>
    <div v-for="(item,index) in datas" :key="index">
      <span>{{item.id}}</span>
      <span>{{item.name}}</span>
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      datas: [
        { id: 1, name: "item1" },
        { id: 2, name: "item2" },
        { id: 3, name: "item3" }
      ],
      listdata: {
        toan: 9.0,
        van: 10,
        ly: 7.0
      }
    };
  }
};
</script>