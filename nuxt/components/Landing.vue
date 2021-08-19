<template>
  <div class="container-fluid landing-container">
    <div class="row">
      <div class="col-1"></div>
      <div class="col-2 d-flex align-items-center justify-content-center">
        <img class="img-fluid" src="/img/laptop-left.png" />
      </div>
      <div class="col-6 d-flex align-items-center justify-content-center">
        <div>
          <h1 class="text-center">
            Welcome to MicroShop!
          </h1>
          <b-input-group class="mt-3">
            <template #append class="landing-input">
                  <b-button variant="primary">Search</b-button>
            </template>
            <b-form-input class="landing-input"></b-form-input>
          </b-input-group>
        </div>
      </div>
      <div class="col-2 d-flex align-items-center justify-content-center">
        <img class="img-fluid" src="/img/laptop-right.png" />
      </div>
      <div class="col-1"></div>
    </div>
  </div>
</template>

<script>
export default {};
</script>

<style scoped>
.landing-container {
    margin-top: 20vh !important; 
}
.landing-input {
  border: 2px solid gainsboro;
  color: gray;
  background: rgb(240, 240, 240);
  border-radius: 5px;
  padding: 2px 10px;
}
</style>
