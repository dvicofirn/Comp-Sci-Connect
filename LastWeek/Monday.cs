using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace monday
{
    internal class Program
    {
        public static int[] gradesSort(int[] grades)
        {
            int[] result;
            int count = 0;
            for(int i=0; i<grades.Length; i++)
            {
                if(grades[i]>=0 && grades[i] <= 100)
                {
                    count++;
                }
            }
            result=new int[count];
            int index = 0;
            for(int i=0; i <= 100; i++)
            {
                for(int j=0; j<grades.Length; j++)
                {
                    if (grades[j] == i)
                    {
                        result[index] = i;
                        index++;
                    }
                }
            }
            return result;
        }

        public static int[] gradesSort2(int[] grades)
        {
            int[] result;
            int count = 0;
            int[] countingGraes = new int[101];
            for(int i = 0; i < countingGraes.Length; i++)
            {
                countingGraes[i] = 0;
            }

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 0 && grades[i] <= 100)
                {
                    count++;
                    countingGraes[grades[i]]++;
                }
            }
            result = new int[count];

            int index = 0;
            for(int i=0;i< countingGraes.Length; i++)
            {
                for(int j=0; j<countingGraes[i]; j++)
                {
                    result[index]= i;
                    index++;
                }
            }
            return result;
        }
        public static bool checker (BinNode<int> tree, int treeSize)
        {
            if (tree == null)
                return true;
            int[] arr = new int[treeSize];
            check(tree, arr, new int[] {0});
            for(int i=0; i<arr.Length-1; i++)
            {
                if(arr[i]>arr[i+1])
                    return false;
            }
            return true;
        }
        public static void check (BinNode<int> tree, int[]arr,int[] index)
        {
            if (tree.GetLeft() != null)
            {  
                check(tree.GetLeft(), arr,index);
            }

            arr[index[0]] = tree.GetValue();
            index[0]++;

            if (tree.GetRight() != null)
            {
                check(tree.GetRight(), arr,index);
            }
        }
            static void Main(string[] args)
        {
        }

        //functions: 1-3 are examples, you may calculate their complexity
        public static int function1(int n)
        {
            int k = 0;
            int result = 1;
            while (n > 0)
            {
                k += n;
                n -= 1;
                while (k > 0)
                {
                    result += k;
                    k -= 1;
                }
            }
            return result;
        }
        public static int function2(int n)
        {
            int sum = 0;
            while (n > 1)
            {
                for (int i = 0; i < n; i++)
                    sum += i;

                n = n - 1;
            }
            return sum;
        }
        public static int function3(int n)
        {
            if (n < 0)
                return 1;
            return function3(n - 1) + function3(n - 1) + function3(n - 1);
        }
    }
}
