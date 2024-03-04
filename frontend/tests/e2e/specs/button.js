// eslint-disable-next-line no-unused-vars
const { Given, When, Then } = require("cypress-cucumber-preprocessor/steps")
require ("cypress-file-upload")

before(function () {
  cy.visit("/")
});

Given("The form is loaded", function (){
  cy.get("form").should("be.visible")
});

Given("I drag an drop a file", function (){
  GetButton().should("be.disabled")
});

When("Check GUI language", function () {
  ClickButton()
});

Then("The result text area will show informations", function (){
  GetArea()
});

Then("Language is updated", function (){

});