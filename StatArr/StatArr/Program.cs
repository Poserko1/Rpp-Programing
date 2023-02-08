using System;

namespace StatArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());


            }
            Console.WriteLine(OptionManeger.CountLess100(arr));
            Console.WriteLine(OptionManeger.MaxNum(arr));
            arr = OptionManeger.ReverseArr(arr);
            OptionManeger.PrintArr(arr);        
        }
    }
}
