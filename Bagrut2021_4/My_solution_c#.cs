using System;
using Unit4.CollectionsLib;

namespace Question_2
{
    public class BiList
    {
        private Node<int> lst1;
        private Node<int> lst2;
        public BiList()
        {
            this.lst1 = null;
            this.lst2 = null;
        }
        public void AddNum (int num, int CodeList)
        {
            Node<int> temp=null;
            if (CodeList == 1)
            {
                if (this.lst1 == null)
                    this.lst1 = new Node<int>(num);
                else
                    temp = this.lst1;
            }
            else if (CodeList == 2)
            {
                if (this.lst2 == null)
                    this.lst2 = new Node<int>(num);
                else
                    temp = this.lst2;
            }
            else
                throw new Exception("Invalid CodeList");
            if (temp != null)
            {
                while (temp.HasNext())
                {
                    temp = temp.GetNext();
                }
                temp.SetNext(new Node<int>(num));
            }
        }
        public override string ToString()
        {
            string str = "lst1: [";
            Node<int> temp = lst1;
            while (temp != null)
            {
                str += temp.GetValue() + " ";
                temp= temp.GetNext();
            }
            str += "] lst2: [";
            temp= lst2;
            while(temp != null)
            {
                str += temp.GetValue() + " ";
                temp = temp.GetNext();
            }
            str += "]";
            return str;
        }
    }
    internal class Program
    {
        public static BiList GenerateBilist(Node<int> lst)
        {
            BiList biList = new BiList();
            int len = LstLength(lst);
            int maxIndex;
            Node<int> temp;
            for (int i = 0; i < (int)len/2; i++)
            {
                PrintLst(lst);
                maxIndex = MaxValueOfListIndex(lst);
                Console.WriteLine(maxIndex);
                if (maxIndex == 0)
                {
                    biList.AddNum(lst.GetValue(),1);
                    lst=lst.GetNext();
                } 
                else
                {
                    temp=lst;
                    while ((maxIndex - 1) > 0)
                    {
                        maxIndex--;
                        temp = temp.GetNext();
                    }
                    biList.AddNum(temp.GetNext().GetValue(), 1);
                    temp.SetNext(temp.GetNext().GetNext());
                }

            }
            while (lst != null)
            {
                biList.AddNum(lst.GetValue(), 2);
                lst = lst.GetNext();
            }
            return biList;
        }
        public static void PrintLst(Node<int> lst)
        {
            Console.Write("[");
            Node<int> temp =lst;
            while(temp != null)
            {
                Console.Write(temp.GetValue()+" ");
                temp=temp.GetNext();
            }
            Console.Write("]\n");
        }
        public static int LstLength(Node<int> lst)
        {
            Node<int> temp = lst;
            int runningIndex = 0;
            while(temp != null)
            {
                runningIndex++;
                temp=temp.GetNext();
            }
            return runningIndex;
        }
        public static int MaxValueOfListIndex(Node<int> lst)
        {
            if(lst == null)
                return -1;
            int maxValue = lst.GetValue();
            int maxIndex = 0;
            int runningIndex = 1;
            Node<int> temp = lst.GetNext();
            while (temp != null)
            {
                if(temp.GetValue() > maxValue)
                {
                    maxValue = temp.GetValue();
                    maxIndex=runningIndex;
                }
                runningIndex++;
                temp = temp.GetNext();
            }
            return maxIndex;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            Node<int> lst = new Node<int>(random.Next(1, 100));
            Node<int> temp = lst;
            for (int i = 0; i < 9; i++)
            {
                temp.SetNext(new Node<int>(random.Next(1, 100)));
                temp=temp.GetNext();
            }
            BiList bilist = GenerateBilist(lst);
            Console.WriteLine("worked");
            Console.WriteLine(bilist.ToString());
            Console.ReadLine();
        }
    }
}
