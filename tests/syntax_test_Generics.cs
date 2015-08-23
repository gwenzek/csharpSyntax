/// SYNTAX TEST "Packages/User/csharpSyntax/csharp.sublime-syntax"

List<int> l;
/// <- variable.other.type
///   ^ support.type
List<List<int>> ll;
/// <- variable.other.type
///   ^ variable.other.type
///         ^ support.type
List<List<List<int>>> lll;
/// <- variable.other.type
///   ^ variable.other.type
///         ^ variable.other.type
///             ^ support.type
