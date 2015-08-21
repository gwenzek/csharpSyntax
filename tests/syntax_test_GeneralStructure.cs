/// SYNTAX TEST "Packages/User/csharpSyntax/csharp.sublime-syntax"

// A skeleton of a C# program
using System;

namespace YourNamespace
///<- storage.type.module
///        ^ entity.name.module
{
///<- punctuation.section.module
    class YourClass
/// ^ storage.type.class.class
///        ^ entity.name.class.class
    {
    }

    struct YourStruct
/// ^ storage.type.class.struct
///         ^ entity.name.class.struct
    {
    }

    interface IYourInterface
/// ^ storage.type.class.interface
///           ^ entity.name.class.interface
    {
    }

    delegate int YourDelegate(int a);
///  ^ storage.type.type.delegate
///           ^ support.type
///                  ^ entity.name.function.type
///                            ^ support.type
///                               ^ variable.parameter

    enum YourEnum
/// ^ storage.type.class.enum
///        ^ entity.name.class.enum
    {
        A, B
///     ^ constant.enum
    }

    namespace YourNestedNamespace
///     ^ storage.type.module
///             ^ entity.name.module
    {
        struct YourStruct
///      ^ storage.type.class.struct
///              ^ entity.name.class.struct
        {
        }
    }

    class YourMainClass
///   ^ storage.type.class.class
///          ^ entity.name.class.class
    {
        static void Main(string[] args)
        {
            //Your program starts here...
        }
///     ^ punctuation.section.function
    }
/// ^ punctuation.section.class
}
///<- punctuation.section.module

