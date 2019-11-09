import Vue from "vue";
import Router from "vue-router";
import Index from "@/components/Index";
import Bt1 from "@/components/Bt_1";
import Bt2 from "@/components/Bt_2";
import Bt3 from "@/components/Bt_3";
import Bt4 from "@/components/Bt_4";
import Bt5 from "@/components/Bt_5";
import Bt6 from "@/components/Bt_6";

import Task from "@/components/task/index";
Vue.use(Router);

export default new Router({
  routes: [
    {
      path: "/",
      name: "index",
      component: Index
    },
    {
      path: "/bt1",
      name: "bt1",
      component: Bt1
    },
    {
      path: "/bt2",
      name: "bt2",
      component: Bt2
    },
    {
      path: "/bt3",
      name: "bt3",
      component: Bt3
    },
    {
      path: "/bt4",
      name: "bt4",
      component: Bt4
    },
    {
      path: "/bt5",
      name: "bt5",
      component: Bt5
    },
    {
      path: "/bt6",
      name: "bt6",
      component: Bt6
    },
    {
      path: "/task",
      name: "task",
      component: Task
    }
  ]
});
