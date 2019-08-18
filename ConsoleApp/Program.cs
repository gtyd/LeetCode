using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nums = new int[] { 3,3 };
            //var target = 6;
            //var rs = new TwoSumSolution().TwoSumV2(nums, target);
            //Console.WriteLine(string.Join(',', rs));

            var l1 = AddTwoNumbersSolution.GenerateList(new int[] { 3, 4, 5 });
            var l2 = AddTwoNumbersSolution.GenerateList(new int[] { 6, 9, 1 });
            var rs = new AddTwoNumbersSolution().addTwoNumbers(l1, l2);
            Console.ReadLine();
        }
    }
}
