<template>
  <div>
    <nav aria-label="breadcrumb">
      <ol class="breadcrumb">
        <li v-for="(item,index) in datas" class="breadcrumb-item" :key="index">
          <span v-if="datas.length-1==index">{{item.Name}}</span>
          <router-link v-else :to="item.Link">{{item.Name}}</router-link>
        </li>
      </ol>
    </nav>
  </div>
</template>
<script>
export default {
  data() {
    return {
      datas: [
        { Name: "Home", Link: "/" },
        { Name: "Task", Link: "/task" },
        { Name: "Product", Link: "/Product" }
      ]
    };
  }
};
</script>