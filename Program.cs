using System;
using System.Reflection;

namespace Attributes
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
                foreach(Attribute a in t.GetCustomAttributes())
                    if(a is TestAttribute)
                        Console.WriteLine(t.Name);
        }
    }
}
