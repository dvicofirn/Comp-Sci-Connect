using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;
using System.Threading.Tasks;

namespace PassOver
{
    internal class Program
    {
        public static bool LessThanTree(BinNode <int> t, int x)
        {
            if (t == null)
                return true;
            if (t.GetValue() <= x)
                return false;
            bool left = LessThanTree(t.GetLeft(), x);
            bool right = LessThanTree(t.GetRight(), x);
            return left || right;
        }
        public static bool Exist(BinNode<int>bt,int x)
        {
            if (bt == null)
                return false;
            if (bt.GetValue() == x)
                return true;
            return Exist(bt.GetLeft(), x) || Exist(bt.GetRight(), x);
        }

        public static Node<int> Check(BinNode <int> t1, BinNode <int> t2)
        {
            Node<int> first = new Node<int>(-1);
            first = Check(t1, t2, first);
            return first.GetNext();
        }
        public static Node<int> Check(BinNode<int> t1, BinNode<int> t2, Node<int> list)
        {
            if (t1 == null)
                return list;
            int currentValue=t1.GetValue();
            if(!Exist(t2 , currentValue))
            {
                //This part is as suggested by a student

                /*Node<int> temp = list;
                while(temp.GetNext()!=null)
                    temp = temp.GetNext();
                Node<int> newNode= new Node<int>(currentValue);
                temp.SetNext(newNode);*/

                //This part is following the website's solution

                Node<int> theNextNode = new Node<int>(currentValue);
                theNextNode.SetNext(list.GetNext());
                list.SetNext(theNextNode);
            }
            list = Check(t1.GetLeft(), t2,list);
            list=Check(t1.GetRight(), t2, list);
            return list;
        }
        static void Main(string[] args)
        {

        }
    }
}
