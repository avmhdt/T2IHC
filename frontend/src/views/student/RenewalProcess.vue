<template>
  <div class="renewal">
    <InternDetails :showTable="false" :name="name" />
    <div class="submit-renewal">
      <p>Renovar Estágio</p>
      <div class="input-file">
        <input type="file" name="file" id="file" ref="file" required />
        <!-- <label for="file">Selecionar arquivo</label> -->
      </div>
      <textarea
        name=""
        id=""
        cols="30"
        rows="10"
        placeholder="Comentários"
      ></textarea>
      <button class="primary">Submeter pedido</button>
    </div>
  </div>
</template>

<script>
import InternDetails from '@/views/student/InternDetails.vue'
export default {
  name: 'RenewalProcess',
  props: {
    name: String
  },
  data () {
    return {}
  },
  components: {
    InternDetails
  },
  methods: {},
  created () {}
}
</script>

<style>
.submit-renewal {
  display: flex;
  flex-direction: column;
  width: 78%;
  background-color: #bdbfc1;
  border-radius: 8px;
  box-shadow: 2px 2px 5px rgba(0, 0, 0, 0.45);
  padding: 30px;
  display: block;
  margin: 0 auto;
  margin-top: 40px;
  position: relative;
  margin-top: 80px;
}
.submit-renewal p {
  text-align: left;
  margin-left: -20px;
}
.submit-renewal p:first-of-type {
  margin-top: -60px;
}

.input-file {
  width: 93%;
  background-color: #fff;
  margin-bottom: 30px;
  margin-left: 40px;
  padding: 10px;
  margin-top: 30px;
}
.input-file input {
  border: none;
  width: 100%;
}

.submit-renewal button {
  position: absolute;
  bottom: 0;
  right: 0;
  margin-right: 70px;
  margin-bottom: 15px;
  padding: 12px 50px;
}
textarea {
  padding: 30px;
  outline: none;
  width: 90%;
  margin-bottom: 60px;
  border: 1px solid #bfbfbf;
}
</style>
