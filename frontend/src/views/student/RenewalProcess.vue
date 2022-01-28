<template>
  <div>
    <InternDetails :showTable="false" />
    <div class="submit-renewal">
      <p>Renovar Estágio</p>

      <p>Submeter Pedido de Renovação</p>
      <div>
        <input type="file" name="file" id="file" ref="file" required />
        <label for="file">Selecionar arquivo</label>
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
  props: {},
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
  max-width: 80%;
  background-color: #bdbfc1;
  border-radius: 8px;
  box-shadow: 2px 2px 5px rgba(0, 0, 0, 0.45);
  padding: 30px;
  margin-top: 40px;
}
.submit-renewal p {
  align-self: flex-start;
}
.submit-renewal p:first-of-type {
  margin-top: -60px;
}

.submit-renewal button {
  align-self: flex-end;
  margin-top: 40px;
}
textarea {
  padding: 30px;
  outline: none;
}
</style>
