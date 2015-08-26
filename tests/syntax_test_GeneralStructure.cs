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
        Int x;
///      ^ variable.other.type.return.cs
///         ^ entity.name.variable.cs

        public Int YourProperty {
///             ^ variable.other.type.return.cs
///                  ^ entity.name.variable.property.cs
            get {return x;}
///          ^ storage.type.function.accessor.get.cs
            set {x = value;}
///          ^ storage.type.function.accessor.set.cs
///                    ^ variable.language
        }
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

        public void MethodWith1Default(int max, string path = null) { }
///                                              ^ support.type.cs
        public void MethodWith2Default(int max = -1, string path = null){ }
///                                                     ^ support.type.cs
    }
/// ^ punctuation.section.class
}
///<- punctuation.section.module

