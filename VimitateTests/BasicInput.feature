Feature: Basic input

Scenario: I can enter a single character
    When I press 'A'
    Then the current text is 'A'
