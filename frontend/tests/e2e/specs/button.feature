Feature: E2e tests
  The webpage consits of one button, that upon clicking, will ask the backend to analyse the image and store it on a bucket

  Scenario: Default values - Good format image
    # when the button is enabled, it means an image as been selected
    Given The form is loaded # default values are displayed
    When I drag an drop a file # send form
    Then The result text area will show informations # only the response zone is updated

  Scenario: Multilanguages
    # when the button is disabled, it means an image as not been selected yet
    Given The form is loaded
    When Check GUI language
    Then Language is updated # without reloading the page
