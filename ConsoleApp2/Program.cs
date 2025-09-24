using System;

namespace ConsoleApp2
{
    internal class program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("enter elements: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
