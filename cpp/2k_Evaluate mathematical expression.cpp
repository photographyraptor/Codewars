/*
Instructions
Given a mathematical expression as a string you must return the result as a number.

Numbers
Number may be both whole numbers and/or decimal numbers. The same goes for the returned result.

Operators
You need to support the following mathematical operators:

Multiplication *
Division / (as floating point division)
Addition +
Subtraction -
Operators are always evaluated from left-to-right, and * and / must be evaluated before + and -.

Parentheses
You need to support multiple levels of nested parentheses, ex. (2 / (2 + 3.33) * 4) - -6

Whitespace
There may or may not be whitespace between numbers and operators.

An addition to this rule is that the minus sign (-) used for negating numbers and parentheses will never be separated by whitespace. I.e all of the following are valid expressions.

1-1    // 0
1 -1   // 0
1- 1   // 0
1 - 1  // 0
1- -1  // 2
1 - -1 // 2
1--1   // 2

6 + -(4)   // 2
6 + -( -4) // 10
And the following are invalid expressions

1 - - 1    // Invalid
1- - 1     // Invalid
6 + - (4)  // Invalid
6 + -(- 4) // Invalid
Validation
You do not need to worry about validation - you will only receive valid mathematical expressions following the above rules.
*/

#include <string>
#include <stdlib.h>

bool isResolved(std::string* exp) {
  std::string::const_iterator it = exp->begin();
  while (it != exp->end() && std::isdigit(*it)) ++it;
  if (!exp->empty() && it == exp->end()) {
    return true;
  }
  return false;
}

void simplifyExpression(std::string* exp) {
  *exp = "22";
  //look for number +-/* number en un regex, resolver y modificar exp
  //falta prioridad entre ()
}

void calcExpresion(std::string* exp) {
  std::cout << *exp << std::endl;
  if (!isResolved(exp)) {
    simplifyExpression(exp);
    calcExpresion(exp);
  }
}

void trimExpression(std::string* exp) {
  std::cout << *exp << std::endl;
  exp->erase(std::remove_if(exp->begin(), exp->end(),
                            [](char c) {
                                return (c == ' ');
                            }),
                            exp->end());
}

double calc(std::string exp) {
  trimExpression(&exp);
  calcExpresion(&exp);
  return atof(exp.c_str());
}