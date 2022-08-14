Feature: Basic input

@Acceptance
Scenario: I can enter all lowercase letters
    When I press the following key, it gets inserted into the text:
    | key | expected |
    | A   | a        |
    | B   | b        |
    | C   | c        |
    | D   | d        |
    | E   | e        |
    | F   | f        |
    | G   | g        |
    | H   | h        |
    | I   | i        |
    | J   | j        |
    | K   | k        |
    | L   | l        |
    | M   | m        |
    | N   | n        |
    | O   | o        |
    | P   | p        |
    | Q   | q        |
    | R   | r        |
    | S   | s        |
    | T   | t        |
    | U   | u        |
    | V   | v        |
    | W   | w        |
    | X   | x        |
    | Y   | y        |
    | Z   | z        |

@Acceptance
Scenario: I can enter all uppercase letters
    When I press the following key, it gets inserted into the text:
    | key     | expected |
    | Shift+A | A        |
    | Shift+B | B        |
    | Shift+C | C        |
    | Shift+D | D        |
    | Shift+E | E        |
    | Shift+F | F        |
    | Shift+G | G        |
    | Shift+H | H        |
    | Shift+I | I        |
    | Shift+J | J        |
    | Shift+K | K        |
    | Shift+L | L        |
    | Shift+M | M        |
    | Shift+N | N        |
    | Shift+O | O        |
    | Shift+P | P        |
    | Shift+Q | Q        |
    | Shift+R | R        |
    | Shift+S | S        |
    | Shift+T | T        |
    | Shift+U | U        |
    | Shift+V | V        |
    | Shift+W | W        |
    | Shift+X | X        |
    | Shift+Y | Y        |
    | Shift+Z | Z        |

@Acceptance
Scenario: I can enter all digits
    When I press the following key, it gets inserted into the text:
    | key | expected |
    | D0  | 0        |
    | D1  | 1        |
    | D2  | 2        |
    | D3  | 3        |
    | D4  | 4        |
    | D5  | 5        |
    | D6  | 6        |
    | D7  | 7        |
    | D8  | 8        |
    | D9  | 9        |

@Acceptance
Scenario: I can enter all the numeric symbols
    When I press the following key, it gets inserted into the text:
    | key       | expected |
    | Shift+D0  | )        |
    | Shift+D1  | !        |
    | Shift+D2  | @        |
    | Shift+D3  | #        |
    | Shift+D4  | $        |
    | Shift+D5  | %        |
    | Shift+D6  | ^        |
    | Shift+D7  | &        |
    | Shift+D8  | *        |
    | Shift+D9  | (        |

@Acceptance
Scenario: I can enter all regular symbols
    When I press the following key, it gets inserted into the text:
    | key          | expected |
    | Hyphen       | -        |
    | Equals       | =        |
    | LeftBracket  | [        |
    | RightBracket | ]        |
    | Backslash    | \        |
    | Semicolon    | ;        |
    | Apostrophe   | '        |
    | Comma        | ,        |
    | Period       | .        |
    | ForwardSlash | /        |

@Acceptance
Scenario: I can enter all symbols when pressing shift
    When I press the following key, it gets inserted into the text:
    | key                | expected |
    | Shift+Hyphen       | _        |
    | Shift+Equals       | +        |
    | Shift+LeftBracket  | {        |
    | Shift+RightBracket | }        |
    | Shift+Backslash    | \|       |
    | Shift+Semicolon    | :        |
    | Shift+Apostrophe   | "        |
    | Shift+Comma        | <        |
    | Shift+Period       | >        |
    | Shift+ForwardSlash | ?        |

