using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace SecondWeek
{
    internal class Program
    {

        public static void function(int number) //recursion, for next year
        {
            if (number > 10)
                return;
            Console.WriteLine(number);
            function(number+1);
        }



        public static int maxColumn(int[][] doubleArray)
        {
            int maxSum = 0;
            int rowsLength = doubleArray.Length;
            int columnsLength = doubleArray[0].Length;

            for (int i = 0; i < rowsLength; i++)
            {
                maxSum = maxSum + doubleArray[i][0];
            }
           
            int sum;
            int x = 0;
            for (int i=1; i< columnsLength; i++)
            {
                sum = 0;
                for(int j=0; j< rowsLength; j++)
                {
                    sum = sum + doubleArray[j][i];
                }

                if(sum > maxSum)
                {
                    maxSum = sum;
                    x=i;
                }

            }

            return x;
        }

        static void Main(string[] args)
        {
            function(3);//recursion, for next year
            long number = 100000000000000000; //exaple of a very long number
            Console.WriteLine(number);
            int[][] doubleArray = new int[3][]; //creating a matrix with 3 rows and 4 columns
            doubleArray[0] = new int[] { 9, 20, 15, 50 };
            doubleArray[1] = new int[] { 5, 9, 3, 4};
            doubleArray[2] = new int[] { 6, 12, 19, 0};
            //doubleArray[3] = new int[] { 8,10,11, 12};  // unused
            
            Console.WriteLine(maxColumn(doubleArray));// prints the index of the column with the biggest sum

            Console.ReadLine();
            
        }
    }
}
