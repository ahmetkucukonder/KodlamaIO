using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1, num2 = 666;
            Console.WriteLine("Ref: " + SomeMath(ref num, ref num2));

            int outNum, outNum2;
            Console.WriteLine("Out: " + SomeOutReference(out outNum, out outNum2));
        }

        static int SomeMath(ref int num, ref int num2)
        {
            return num + num2 - 1;
        }
        static int SomeOutReference(out int outNum, out int outNum2)
        {
            outNum = 1;
            outNum2 = 665;
            return outNum + outNum2;
        }
    }
}