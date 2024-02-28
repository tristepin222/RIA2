<template>
  <v-card class="mx-auto" width="400" prepend-icon="mdi-home">
    <v-select :model-value="languages[0]" :items="languages" item-title="text">
      <template v-slot:item="{ props, item }">
        <v-list-item
          v-bind="props"
          :subtitle="item.raw.text"
          @click="changeLanguage(item.value)"
        ></v-list-item>
      </template>
    </v-select>
  </v-card>
</template>
<script>
export default {
  data() {
    return {
      selectedLanguage: "English",
      languages: [
        { text: "French", value: "fr" },
        { text: "German", value: "de" },
        { text: "English", value: "en" },
        { text: "Japanese", value: "ja" },
      ],
    };
  },
  methods: {
    changeLanguage(language) {
      this.selectedLanguage = language;
      this.$root.$i18n.locale = language;
    },
  },
};
</script>
