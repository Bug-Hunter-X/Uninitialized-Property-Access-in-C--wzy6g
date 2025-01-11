# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property of a class before it has been assigned a value.  The `bug.cs` file contains the erroneous code, while `bugSolution.cs` provides the corrected version.

The issue arises when attempting to use a property's value before explicitly initializing it within the class constructor or before its first usage within a method. This often leads to unexpected behavior, exceptions, or compiler errors. The example shows how to correctly initialize the property to avoid this problem.
