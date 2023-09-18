using System;

namespace MyNamespace
{
    class ClassA
    {
        private int FieldA = 10;

        public void AccessFromClassB(ClassB objB)
        {
            int valueFromB = objB.GetPrivateFieldB();
            Console.WriteLine($"Accessed private field from ClassB: {valueFromB}");
        }
    }

    class ClassB
    {
        private int FieldB = 20;

        public int GetPrivateFieldB()
        {
            return FieldB;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassA objA = new ClassA();
            ClassB objB = new ClassB();

            objA.AccessFromClassB(objB);
        }
    }
}
