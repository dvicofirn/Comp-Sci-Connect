using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace LastSunday
{
    internal class Program
    {
        public static void PrintAll(BinNode<int> tree)
        {
            if(tree != null)
            {
                String str = "";
                PrintAllHelp(tree, str);
            }
        }
        public static void PrintAllHelp(BinNode<int> tree,String str )
        {
            if (tree.GetLeft() == null&&tree.GetRight()==null)
            {
                Console.WriteLine(str+tree.GetValue());
            }
            else if (tree.GetRight() == null)
            {
                PrintAllHelp(tree.GetLeft(), str+tree.GetValue());
            }
            else if (tree.GetLeft() == null)
            {
                PrintAllHelp(tree.GetRight(), str+tree.GetValue());
            }
            else
            {
                PrintAllHelp(tree.GetLeft(), str+tree.GetValue());
                PrintAllHelp(tree.GetRight(), str+tree.GetValue());
            }
        }
        public static void PrintAll2(BinNode<int> tree)
        {
            if (tree != null)
            {
                Stack<int> stack = new Stack<int>();
                PrintAllHelp2(tree,stack);
            }
        }
        public static void PrintAllHelp2(BinNode<int> tree, Stack<int> stack)
        {
            if (tree.GetLeft() == null && tree.GetRight() == null)
            {
                int numberToPrint=tree.GetValue();
                int multiplayer = 10;
                Stack<int> temp = new Stack<int>();
                int currentNumber;
                while (!stack.IsEmpty())
                {
                    currentNumber = stack.Pop();
                    numberToPrint += currentNumber * multiplayer;
                    temp.Push(currentNumber);
                    multiplayer *= 10;
                }
                Console.WriteLine(numberToPrint);
                while (!temp.IsEmpty())
                {
                    stack.Push(temp.Pop());
                }
            }
            else if (tree.GetRight() == null)
            {
                stack.Push(tree.GetValue());
                PrintAllHelp2(tree.GetLeft(), stack);
                stack.Pop();
            }
            else if (tree.GetLeft() == null)
            {
                stack.Push(tree.GetValue());
                PrintAllHelp2(tree.GetRight(), stack);
                stack.Pop();
            }
            else
            {
                stack.Push(tree.GetValue());
                PrintAllHelp2(tree.GetLeft(), stack);
                PrintAllHelp2(tree.GetRight(), stack);
                stack.Pop();
            }
        }

        static void Main(string[] args)
        {
            string str = "";
            int d = 5;
            Console.WriteLine( (str+d).GetType());
            Console.ReadLine();
        }
    }
}
