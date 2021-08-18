<template>
  <div>
    <ul class="list-unstyled">
        <div :v-for="item in items">
            <h1>test</h1>
        </div>
      <b-media tag="li" >
        <template #aside>
          <b-avatar variant="primary" text="BV"></b-avatar>
        </template>
        <h5 class="mt-0 mb-1 text-muted">List-based media object</h5>
        <p class="mb-0">
          Cras sit amet nibh libero, in gravida nulla. Nulla vel metus
          scelerisque ante sollicitudin. Cras purus odio, vestibulum in
          vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi
          vulputate fringilla. Donec lacinia congue felis in faucibus.
        </p>
      </b-media>
    </ul>
  </div>
</template>

<script>
export default {
  async asyncData({ $axios, params }) {
    const response = await $axios.get(`comment/3`);
    console.log(response);
    const items = response.data;
    return {
      items
    };
  },
  data() {
    return {}
  },
};
</script>

<style></style>
