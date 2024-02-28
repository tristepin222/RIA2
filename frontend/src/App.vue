<template>
  <LanguageList />
  <ImageForm />
</template>

<script>
import ImageForm from "./components/ImageForm";
import LanguageList from "./components/LanguageList";

export default {
  name: "App",
  components: {
    ImageForm,
    LanguageList,
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
