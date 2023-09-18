// Assembly1.cs
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly2")] // Allow access from Assembly2

namespace Assembly1
{
    public class MyClass
    {
        internal MyClass()
        {
            // Internal constructor
        }

        public void SomeMethod()
        {
            Console.WriteLine("Some method in MyClass");
        }
    }
}
