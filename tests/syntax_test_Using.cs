/// SYNTAX TEST "Packages/User/csharpSyntax/csharp.sublime-syntax"
using System.Text;
/// <- storage.type.module.import.cs
///    ^ variable.module.cs
///         ^ punctuation.separator.module.cs
///            ^ variable.module.cs
///              ^ punctuation.definition.module.end
using static System.Math.Foo;
/// <- storage.type.module.import.cs
///      ^ storage.modifier.module.cs
///                  ^ variable.module.cs
using Project = PC.MyCompany.Project;
/// <- storage.type.module.import.cs
///    ^ entity.name.type
///           ^ storage.modifier.module.as

using (Font font3 = new Font("Arial", 10.0f))
/// <- keyword.control.trycatch.using.cs
///   ^ punctuation.definition.expression.trycatch.using
///     ^ variable.other.type
///               ^ keyword.operator.assignment
///                                         ^ punctuation.definition.expression.trycatch.using
{
///   <- punctuation.section.block.trycatch
    // Use font3
    global::System.Console.WriteLine("foo");
///  ^ support.module.cs
///       ^ keyword.operator.accessor.module.cs
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
