# F# Mutable Variable Swap Bug

This repository demonstrates a common error in F# involving mutable variables and function arguments. The issue arises when attempting to swap mutable variables within a function, where changes made to the function parameters do not affect the variables in the calling scope.

## Bug Description

The code attempts to swap the values of two mutable variables using a function, but the original variables remain unchanged after the function call. This occurs because F# passes mutable variables by value, creating copies of the variables within the function's scope.

## Solution

The bug can be resolved by passing the variables to the function as `ref` cells, allowing the function to directly modify the original variables.