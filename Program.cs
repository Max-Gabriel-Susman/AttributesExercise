using System;
using System.Reflection;

namespace HelloWorld
{
    class TestAttribute : Attribute { }

    [TestAttribute]
    class MyTestSuite
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Type t in Assembly.GetExecutingAssembly().GetTypes())
                Console.WriteLine(t.Name);
        }
    }
}
