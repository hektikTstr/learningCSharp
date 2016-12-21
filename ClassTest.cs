using System;
using System.Collections.Generic;

namespace learningCSharp {
    public class ClassTest {
        public class Pair
        {
            public int First;
            public string Second;
        }
        static void Swap(ref int x, ref int y) 
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SwapExample() 
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // Outputs "2 1"
        }
        static void Divide(int x, int y, out int result, out int remainder) 
        {
            result = x / y;
            remainder = x % y;
        }
        public static void OutUsage() 
        {
            int res, rem;
            Divide(10, 3, out res, out rem);
            Console.WriteLine("{0} {1}", res, rem);	// Outputs "3 1"
        }
        public static void WriteSquares() 
        {
            int i = 0;
            int j;
            while (i < 10) 
            {
                j = i * i;
                Console.WriteLine($"{i} x {i} = {j}");
                i = i + 1;
            }
        }
    }
}