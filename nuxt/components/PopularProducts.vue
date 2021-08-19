<template>
  <div>
    <div class="container mt-5">
      <h1>All products</h1>
      <div class="row">
        <div class="col-3 mt-4" v-for="product in products" :key="product.id">
          <b-card
            :img-src="product.thumbnail"
            img-alt="Image"
            img-top
            tag="article"
            style="max-width: 20rem;"
            class="mb-2"
          >

<b-card-body class="p-1">
      <b-card-title class="text-center">{{product.title}}</b-card-title>
      <b-card-sub-title class="mb-2 text-center">{{ product.shortDescription }}</b-card-sub-title>
      <b-card-title class="text-center">{{product.price}} TL</b-card-title>
    </b-card-body>


            <b-button class="mt-2" :href="`/product/${product.id}`" variant="primary" block
              >Details</b-button
            >
          </b-card>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      products: []
    };
  },
  async fetch() {
    const { data } = await this.$axios.get(`http://localhost:8080/product/all`);
    // `todos` has to be declared in data()
    this.products = data;
  }
};
</script>

<style></style>
