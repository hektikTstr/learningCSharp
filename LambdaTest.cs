using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learningCSharp
{
    delegate bool D();  
    public delegate bool D2(int i);
    public class LambdaTest
    {
        static void someMethod() {
            Console.WriteLine("someMethod");
        }
        // Expression-bodied methods
        static int TreeBranches(int branches, int trunks) => (branches * trunks);
        delegate void TestDelegate(string s);
        public static void test()
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            // ... Find index of first odd element.
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddIndex);

            //
            // Use implicitly-typed lambda expression.
            // ... Assign it to a Func instance.
            //
            Func<int, int> func1 = x => x + 1;
            //
            // Use lambda expression with statement body.
            //
            Func<int, int> func2 = x => { return x + 1; };
            //
            // Use formal parameters with expression body.
            //
            Func<int, int> func3 = (int x) => x + 1;
            //
            // Use parameters with a statement body.
            //
            Func<int, int> func4 = (int x) => { return x + 1; };
            //
            // Use multiple parameters.
            //
            Func<int, int, int> func5 = (x, y) => x * y;
            //
            // Use no parameters in a lambda expression.
            //
            Action func6 = () => Console.WriteLine();
            //
            // Use delegate method expression.
            //
            Func<int, int> func7 = delegate(int x) { return x + 1; };
            //
            // Use delegate expression with no parameter list.
            //
            Func<int> func8 = delegate { return 1 + 1; };

            Action func9 = () => { Console.WriteLine(); };

            Action func10 = () => someMethod();
            // ... The methods above are executed.
            //
            Console.WriteLine(func1.Invoke(1));
            Console.WriteLine(func2.Invoke(1));
            Console.WriteLine(func3.Invoke(1));
            Console.WriteLine(func4.Invoke(1));
            Console.WriteLine(func5.Invoke(2, 2));
            func6.Invoke();
            Console.WriteLine(func7.Invoke(1));
            Console.WriteLine(func8.Invoke());
            func9.Invoke();

            Predicate<int> predicate = value => value == 5;
            Console.WriteLine(predicate.Invoke(4));
            Console.WriteLine(predicate.Invoke(5));

            System.Console.WriteLine(TreeBranches(10, 2));


            int[] array = { 1, 2, 1 };
            Console.WriteLine(array.Count(element => element == 1));

            TestDelegate myDel = n => { string s = n + " " + "World"; Console.WriteLine(s); };  
            myDel("Hello");
            new TestDelegate(n => { string s = n + " " + "World"; Console.WriteLine(s); }).Invoke("wulala");

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
            Console.WriteLine(numbers.Count(n => n % 2 == 1));
            Console.WriteLine(numbers.TakeWhile(n => n < 6).Count());
        }
        
        // lambda scope test
        static D del;
        public static D2 del2;
        public static void testScope(int input)
        {  
            int j = 0;  
            // Initialize the delegates with lambda expressions.  
            // Note access to 2 outer variables.  
            // del will be invoked within this method.  
            del = () => { j = 10;  return j > input; };  
    
            // del2 will be invoked after TestMethod goes out of scope.  
            del2 = (x) => {return x == j; };  
    
            // Demonstrate value of j:  
            // Output: j = 0   
            // The delegate has not been invoked yet.  
            Console.WriteLine("j = {0}", j);        // Invoke the delegate.  
            bool boolResult = del();  
    
            // Output: j = 10 b = True  
            Console.WriteLine("j = {0}. b = {1}", j, boolResult);  
        }  
    }
}
