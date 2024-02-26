Feature: The analyse button
  The webpage consits of one button, that upon clicking, will ask the backend to analyse the image and store it on a bucket

  Scenario: I press the button when it's enabled
    # when the button is enabled, it means an image as been selected
    When I click on the button
    Then The result text area will show informations (labels and confidences) about the image

  Scenario: I press the button when it's disabled
    # when the button is disabled, it means an image as not been selected yet
    When I click on the button 
    Then Nothing happens
