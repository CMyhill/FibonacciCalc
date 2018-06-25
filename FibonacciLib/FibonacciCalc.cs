using System;

namespace FibonacciLib
{
    public static class FibonacciCalc
    {
        public static int[] Get(int len)
        {
            int a = 0, b = 1;

            var fibs = new int[len];

            for (int i = 1; i < len; i++)
            {
                var c = a + b;

                fibs[i] = c;

                a = b;

                b = c;
            }

            return fibs;
        }
    }
}
