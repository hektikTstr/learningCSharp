using System;
using System.Collections.Generic;

namespace learningCSharp {
    public class StatementTest {
        public static void CheckedUnchecked() 
        {
            int x = int.MaxValue;
            // unchecked 
            {
                Console.WriteLine(x + 1);  // Overflow
            }
            // checked 
            {

                Console.WriteLine(x + 1);  // Exception
            }     
        }
        static IEnumerable<int> Range(int from, int to) 
        {
            for (int i = from; i < to; i++) 
            {
                yield return i;
            }
            yield break;
        }
        public static void YieldStatement(string[] args)
        {
            foreach (int i in Range(-10,10)) 
            {
                Console.WriteLine(i);
            }
        }
        public static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
        public static IEnumerable<int> GenerateWithoutYield()
        {
            var i = 0;
            var list = new List<int>();
            while (i<5)
                list.Add(++i);
            return list;
        }
        public static IEnumerable<int> GenerateWithYield()
        {
            var i = 0;
            while (true)
                yield return ++i;
        }
    }
}