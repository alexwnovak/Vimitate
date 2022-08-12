Feature: Basic input

@Acceptance
Scenario: I can enter any of the supported text characters
    When I press the following, the text matches the expected value:
    | key | expected |
    | A   | A        |
    | B   | B        |
    | C   | C        |
