# Strategy Pattern

The **Strategy Pattern** is a behavioral design pattern that allows you to define a family of algorithms, put each of them into a separate class, and make them interchangeable.

Instead of implementing many conditional statements inside one class, the Strategy Pattern lets you move different behaviors into separate strategy classes.

## Why use it?

The Strategy Pattern is useful when an object should be able to change its behavior without changing its own code.

It helps to:

- reduce complex `if` / `switch` statements,
- keep algorithms separated and easier to test,
- follow the Open/Closed Principle,
- make code easier to extend with new behaviors.

## Example

A common example is a payment system.

Different payment methods can be implemented as separate strategies:

- credit card payment,
- PayPal payment,
- bank transfer payment.

The main checkout logic does not need to know how each payment method works. It only uses a common strategy interface.

## Structure in this project

This directory contains examples of the Strategy Pattern implemented in C#.

The examples show the difference between a naive solution and a pattern-based solution.