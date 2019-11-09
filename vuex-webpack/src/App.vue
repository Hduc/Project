<template>
  <div class="container-fluid">
    <carousel-full />
    <section>
      <navbar />
    </section>
    <div class="row mt-6">
      <div class="col-sm-2">
        <menu-left />
      </div>
      <div class="col-sm-10">
        <div class="row">
          <div class="col-sm-12">
            <breadcrumb />
          </div>
          <div class="col-sm-12">
            <router-view />
          </div>
        </div>
      </div>
    </div>
    <section>
      <footer-content />
    </section>
  </div>
</template>
<script>
import Vue from "vue";
import jquery from "jquery/dist/jquery";
import bootstrap from "bootstrap/dist/js/bootstrap.bundle.min";

import Breadcrumb from "@/components/commons/Breadcrumb";
import Navbar from "@/components/commons/Navbar";
import FooterContent from "@/components/commons/Footer";
import MenuLeft from "@/components/commons/MenuLeft";
import carouselFull from "@/components/commons/carouselFull";
export default {
  data() {
    return {};
  },
  components: { carouselFull, Breadcrumb, Navbar, FooterContent, MenuLeft }
};
</script>
<style>
@import url("bootstrap/dist/css/bootstrap.min.css");
@import url("bootstrap/dist/css/bootstrap-grid.min.css");
.mt-6 {
  margin-top: 3.5rem;
}
</style>
