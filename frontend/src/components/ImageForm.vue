<template>
  <v-card class="mx-auto" width="400" prepend-icon="mdi-home">
    <template v-slot:title>{{ $t("$vuetify.imageText") }}</template>
    <v-card-text>
      <v-form v-model="valid">
        <v-file-input prepend-icon="" label="File input"></v-file-input>
        <v-btn type="submit" block class="mt-2" disabled>Analyse</v-btn>
        <p class="my-10">Result</p>
        <v-textarea label="Label" disabled></v-textarea>
      </v-form>
    </v-card-text>
  </v-card>
</template>
