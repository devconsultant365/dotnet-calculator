Feature: Calculator

  Scenario Outline: Add two whole numbers
    Given I have a whole number of <value1>
    And I have a whole number of <value2>
    When I add the numbers together
    Then The resulting number should be <sum>

    Examples:
      | value1 | value2 | sum |
      | 0      | 0      | 0   |
      | 1      | 2      | 3   |
      | -1     | -2     | -3  |

  Scenario: Add three whole numbers
    Given I have a whole number of 1
    And I have a whole number of 2
    And I have a whole number of 3
    When I add the numbers together
    Then The resulting number should be 6
    