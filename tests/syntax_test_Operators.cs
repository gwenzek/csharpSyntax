/// SYNTAX TEST "Packages/User/csharpSyntax/csharp.sublime-syntax"
int? length = customers?.Length;
/// <- support.type.cs
///^ support.type.cs
///     ^ entity.name.variable.cs
///                    ^ keyword.operator.accessor
Customer? first = customers?[0];
/// <- variable.other.type
///                        ^ punctuation.definition.accessor
///                         ^ punctuation.definition.accessor
Customer second = customers[0];
/// <- variable.other.type
///                        ^ punctuation.definition.accessor
int? count = customers?[0]?.Orders?.Count();
///^ support.type.cs
///     ^ entity.name.variable.cs
///        ^ keyword.operator.assignment.variable.cs
A?.B?.C?[0] ?? E;
/// ^ keyword.operator.accessor
///     ^ punctuation.definition.accessor
///         ^ keyword.operator
A?.B?.C?[0] == E;
///         ^ keyword.operator
     x->y;
///    ^ keyword.operator
    (*x).y;
///  ^ keyword.operator
    x >>= y
///   ^ keyword.operator
    x = x >> y
///   ^ keyword.operator.assignment
///       ^ keyword.operator

