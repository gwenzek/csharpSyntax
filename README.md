# csharpSyntax
C# syntax for Sublime Text with tests.

This repository is a work repository.
When the syntax is ready to be released, I make pull request to the [Sublime package](https://github.com/sublimehq/Packages) repository.

If you want to contribute clone it in your `Packages/User` folder.
The syntax should appear in the `Set syntax:` list under the name `C sharp, C#`

# Features:

* Detection of variables declaration (that's a lot !)
* Detection of tag: `[TestMethod]`
* Support for new C# 6 syntax: `$"{1 + 2}"`, "x?.y", ...
* Detection of operators
* Detection of generics type
* Detection of labels
* Detection of function calls
* ...

# Tests:
The tests folder include some tests, that should allow you to see the new syntax in action.
If you find a bug, don't hesitate to create a new test that highlight it.
