// AssemblyA (YourClassLibrary)

using System;

public class MyClass
{
    internal MyClass()
    {
        Console.WriteLine("Internal constructor called.");
    }

    public void PublicMethod()
    {
        Console.WriteLine("Public method called.");
    }
}
