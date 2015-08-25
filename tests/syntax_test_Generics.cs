/// SYNTAX TEST "Packages/User/csharpSyntax/csharp.sublime-syntax"

List<int> l;
/// <- variable.other.type
///   ^ support.type
///       ^ entity.name.variable
List<List<int>> ll;
/// <- variable.other.type
///   ^ variable.other.type
///         ^ support.type
///             ^ entity.name.variable
List<List<List<int>>> lll;
/// <- variable.other.type
///   ^ variable.other.type
///         ^ variable.other.type
///             ^ support.type
///                    ^ entity.name.variable
     l = 1;
///  ^ variable.other.cs
     int l = 1;
///  ^ variable.other.type
///      ^ entity.name.variable
     int l1 = 1, l2 = 2;
///  ^ variable.other.type
///      ^ entity.name.variable
///               ^ entity.name.variable

