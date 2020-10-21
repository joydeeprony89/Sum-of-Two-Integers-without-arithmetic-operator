using System;

namespace Sum_of_Two_Integers_without_arithmetic_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(GetSum(-3,12));
        }

        static int GetSum(int a, int b)
        {
            int carry;
            while (b != 0)
            {
                carry = a & b;
                a = a ^ b;
                b = (carry) << 1;
            }
            return a;
        }
    }
}
