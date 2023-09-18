
using Assembly1;

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();
        int value = myObject.protectedInternalField; 
        System.Console.WriteLine($"Protected Internal Field Value: {value}");
    }
}
