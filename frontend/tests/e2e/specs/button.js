// eslint-disable-next-line no-unused-vars
const { Given, When, Then } = require("cypress-cucumber-preprocessor/steps")
require ("cypress-file-upload")

function UploadImage(){
  cy.fixture('example.jpg').then((fileContent) => {
    cy.get('input[name="file-input"]').attachFile({
      fileContent: fileContent.toString(),
      fileName: 'example.jpg',
      mimeType: 'image/jpeg'
    })
  })
}

function GetButton(){
  return cy.get("button").should('contains.text', "Analyse").as("analyse_button")
}

function ClickButton() {
  // eslint-disable-next-line for-direction
  GetButton();
  cy.get("@analyse_button").click()
  
}

function GetArea() {
  return cy.get("textarea").as("text_area").should("not.have.value", "")
}

before(function () {
  cy.visit("/")
});

Given("The button is enabled", function (){
  UploadImage()
  GetButton().should("not.be.disabled")
});

Given("The button is disabled", function (){
  GetButton().should("be.disabled")
});

When("I click on the button", function () {
  ClickButton()
});

Then("The result text area will show informations", function (){
  GetArea()
});

Then("Nothing happens", function (){

});