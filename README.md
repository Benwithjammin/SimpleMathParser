Simple Math Parser
=========================

A simple string - math parser. There are three implementations but only one that supports nested parentheses

###The different implementations:

  1. ShuntingYardCalculator.cs an implementation of the shunting-yard algorithm. The core implementation is not my own, it is taken from here - http://www.codeproject.com/Tips/351042/Shunting-Yard-algorithm-in-Csharp. Dont re-invent the wheel, and re-invent it square shaped! - Does not work with multiple parentheses
  2. StackCalculator - an attempt at #1 without RPN, works without parentheses
  3. ListCalculator - after been blinkered toward RPN / Shunting yard with stack, just used a plain old list, indexes, indexOf and lastIndex of. Works with multiple brackets.

The main program.cs is currently using the working version. To switch either run the tests or grab a different calculator from the calculator factory.

###Running it

To get up and running:
  1. Clone this repo
  2. Enable nuget package restore in VS and build
  3. Run the MathParser .exe console application