using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlistexample
{

    class Node
    {
        public string Data
        {
            set; get;
        }
        public Node Next { set; get; }
    }

    class LinkedListNode
    {
        public Node Head { set; get; }
        public Node Tail { set; get; }
        public int Count { set; get; }

        public void Add(string userInput)
        {
            Node newNode = new Node { Next = null, Data = userInput };
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
                Count++;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
                Count++;
            }
        }
        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head;
            while (start != index)
            {
                start += 1;
                temp = temp.Next;
            }
            return temp;
        }
        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode myList = new LinkedListNode();
            myList.Add("Steve");
            myList.Add("Mauricio");
            myList.Add("Evan");
            myList.Add("Dan");

            Console.WriteLine("My list's count is " + myList.Count);

            Console.WriteLine();

            myList.PrintList();

            Node tempNode = myList.GetNode(3);
            tempNode.Data = "Ty";

            Console.WriteLine();
            myList.PrintList();

            Console.ReadLine();
        }
    }
}
