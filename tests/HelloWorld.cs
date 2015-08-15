/// SYNTAX TEST "Packages/User/csharpSyntax/csharp.sublime-syntax"

// A Hello World! program in C#.
///<- comment.line
using System;
///<- storage.type.module.import
///   ^ variable.module
///         ^ punctuation.terminator

namespace HelloWorld
///<- storage.type.module
{
    class Hello
/// ^ storage.type.class
///       ^ entity.name.class
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
