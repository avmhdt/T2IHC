<template>
  <div id="app">
    <router-view />
  </div>
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: rgba(0, 0, 0, 0.9);
}

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}

button.primary {
  background-color: #000;
  border: none;
  color: #fff;
  font-size: 14px;
  padding: 8px 20px;
}
button.secondary {
  background-color: #fff;
  color: #000;
  padding: 10px 20px;
  border: 0.5px solid rgba(0, 0, 0, 0.1);
  box-shadow: 0 2px 3px rgba(0, 0, 0, 0.2);
  font-weight: bold;
}

button:hover {
  cursor: pointer;
}
</style>
