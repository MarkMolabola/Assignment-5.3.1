using System.ComponentModel.DataAnnotations;
using System;
using System.Text;
using System.Collections.Generic;

namespace Assignment_5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerBed1 = { 0,0,0,0,0,0,0,0}; int n1 = 4;
            int[] flowerBed2 = { 1,0,0,1,0,0,0,0}; int n2 = 2;
            int[] flowerBed3 = { 0,0,0,1,0,0,0,1}; int n3 = 6;

            Display(flowerBed1, n1);
            Display(flowerBed2, n2);
            Display(flowerBed3, n3);
          
        }
        static void Display(int[] nums, int n )
        {
            Console.WriteLine("FlowerBed Before: ");
            foreach (int i in nums)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine($"Num of Plants to Plant: {n}");

            Console.WriteLine($"Is it Possible: {NoAdjacentFlowers(nums, n)}");
            Console.WriteLine("FlowerBed After: ");
            foreach (int i in nums)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
        }
        static bool NoAdjacentFlowers(int[] arr, int n )
        {
            int counter = 0;
            if (arr[0] == 0) //edge case
            {
                counter++;
                arr[0] = 1;
            }

            for (int i = 1; i < arr.Length-1; i++)
            {
                if (arr[i-1] == 0 && arr[i+1]==0 && arr[i] == 0)
                {
                    counter++;
                    arr[i] = 1;
                }
            }

            if (arr[arr.Length-1] == 0 && arr[arr.Length-2] == 0) //edge case
            {
                counter++;
                arr[arr.Length-1] = 1;
            }
            
            if (n <= counter)
            {
                return true;
            }
            return false;

        }
    }
}
