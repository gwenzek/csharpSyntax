/// SYNTAX TEST "Packages/User/csharpSyntax/csharp.sublime-syntax"

using (Font font3 = new Font("Arial", 10.0f))
/// <- keyword.control.trycatch.using.cs
///   ^ punctuation.definition.expression.trycatch.using
///     ^ variable.other.type
///               ^ keyword.operator.assignment
///                                         ^ punctuation.definition.expression.trycatch.using
{
///   <- punctuation.section.block.trycatch
    // Use font3
}
///   <- punctuation.section.block.trycatch

using (Font font3 = new Font("Arial", 10.0f),
/// <- keyword.control.trycatch.using.cs
///   ^ punctuation.definition.expression.trycatch.using
///                                         ^ punctuation.separator
            font4 = new Font("Arial", 10.0f))
///                                         ^ punctuation.definition.expression.trycatch.using
{
///   <- punctuation.section.block.trycatch
    // Use font3 and font4.
}
///   <- punctuation.section.block.trycatch
