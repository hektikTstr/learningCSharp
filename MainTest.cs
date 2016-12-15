using System;
using System.Collections.Generic;

namespace learningCSharp
{
    public class MainTest
    {
        public static void Main(string[] args)
        {
            LambdaTest.test();
            LambdaTest.testScope(5);
            Console.WriteLine(LambdaTest.del2(10));
            AnonymousMethodTest.test();
        }
    }
}