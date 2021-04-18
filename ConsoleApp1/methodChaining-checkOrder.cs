using System;
namespace ConsoleApp1
{
    public class methodChaining_checkOrder
    {
        class BitwiseBuldier
        {
            private int value;

            public BitwiseBuldier(int value)
            {
                this.value = value;
            }

            public BitwiseBuldier AND(int num)
            {
                value &= num;
                return this;
            }
            public BitwiseBuldier OR(int num)
            {
                value |= num;

                return this;
            }
            public BitwiseBuldier XOR(int num)
            {
                value ^= num;

                return this;
            }
            public int get()
            {
                return value;
            }
        }
        static bool checkOrder(string value)
        {
            if (value.Length % 2 != 0)
            {
                return false;
            }

            string firstHalf = value.Substring(0, value.Length / 2);

            string secondHalf = value.Substring(value.Length / 2, value.Length/2);
            Console.WriteLine(firstHalf+"////"+secondHalf);

            int indx = (value.Length-1) /2;

            for (int i = 0; i < (value.Length-1)/2; i++)
            {
                if (firstHalf[i] != secondHalf[indx])
                {
                    return false;
                }
                indx--;
                Console.WriteLine(indx);
            }
            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Bitwise Builder: ");
            BitwiseBuldier bit = new BitwiseBuldier(20);
            int result = bit.AND(5).
                OR(2).
                XOR(1).
                get();
            Console.WriteLine(result);
            Console.WriteLine("/////////////////////////////////////////////////////");
            Console.WriteLine("Check order: ");
            Console.WriteLine(checkOrder("123456789987654321"));
        }
    }
}