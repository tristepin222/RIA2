// eslint-disable-next-line no-unused-vars
const { Given, When, Then } = require("cypress-cucumber-preprocessor/steps");

function click_button(n = 1, fast = true) {
  // eslint-disable-next-line for-direction
  cy.get("button").should('countains.text', "Analyse").as("analyse_button");
  if (fast) {
    for (let i = 0; i < n; i++) {
      cy.get("@analyse_button").click();
    }
  } else {
    for (let i = 0; i < n; i++) {
      cy.wait(2001).get("@analyse_button").click();
    }
  }
}
before(function () {
  cy.visit("/");
});

When("I click on the button", function () {
  click_button();
});
