import { createApp } from "vue";
import App from "./App.vue";

// Vuetify
import "vuetify/styles";
import { createVuetify } from "vuetify";
import * as components from "vuetify/components";
import * as directives from "vuetify/directives";

// i18n
import { createVueI18nAdapter } from "vuetify/locale/adapters/vue-i18n";
import { createI18n, useI18n } from "vue-i18n";
import { en, ja, de, fr } from "vuetify/locale";

const messages = {
  en: {
    $vuetify: {
      ...en,
      imageText: "Image analyser",
      dataIterator: {
        rowsPerPageText: "Items per page:",
        pageText: "{0}-{1} of {2}",
      },
    },
  },
  de: {
    $vuetify: {
      ...de,
      imageText: "Image analyser",
      dataIterator: {
        rowsPerPageText: "Items per page:",
        pageText: "{0}-{1} of {2}",
      },
    },
  },
  fr: {
    $vuetify: {
      ...fr,
      imageText: "Analyseur d'image",
      dataIterator: {
        rowsPerPageText: "Items per page:",
        pageText: "{0}-{1} of {2}",
      },
    },
  },
  ja: {
    $vuetify: {
      ...ja,
      test: "test",
      dataIterator: {
        rowsPerPageText: "Element per sida:",
        pageText: "{0}-{1} av {2}",
      },
    },
  },
};

const i18n = createI18n({
  locale: "en", // default language
  fallbackFormat: "en",
  messages,
});

const vuetify = createVuetify({
  components,
  directives,
  locale: {
    adapter: createVueI18nAdapter({ i18n, useI18n }),
  },
});

createApp(App).use(vuetify).use(i18n).mount("#app");
