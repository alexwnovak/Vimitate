Feature: Basic input

@Acceptance
Scenario: I can enter a single character
    When I press A
    Then the current text is "A"
