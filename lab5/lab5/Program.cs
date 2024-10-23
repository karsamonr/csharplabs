using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MyLinkedList<int> myList = new MyLinkedList<int>();
            myList.AddFirst(1);
            myList.AddFirst(2);
            myList.AddLast(3);
            myList.ShowList();
            Console.WriteLine();
            myList.AddFirst(4);
            myList.ShowList();
            Console.WriteLine();
            myList.DeleteLast();
            myList.ShowList();
            Console.WriteLine();
            myList.DeleteFirst();
            myList.ShowList();
        }

        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next;
            public Node<T> Prev;

            public Node(T data)
            {
                Data = data;
                Next = null;
                Prev = null;
            } 
        }

        public class MyLinkedList<T>
        {
            private Node<T> Header;
            private Node<T> Tail;

            public void AddFirst(T data)
            {
                Node<T> temp = new Node<T>(data);
                if (Header == null)
                {
                    Header = temp;
                    Tail = temp;
                } else
                {
                    temp.Next = Header;
                    Header = temp;
                }
            }

            public void AddLast(T data)
            {
                Node<T> temp = new Node<T>(data);
                if (Header == null)
                {
                    Header = temp;
                    Tail = temp;
                } else
                {
                    Tail.Next = temp;
                    temp.Prev = Tail;
                    Tail = temp;
                }
            }

            public void DeleteFirst()
            {
                if (Header != null)
                {
                    Header = Header.Next;
                    Header.Prev = null;
                }
            }

            public void DeleteLast()
            {
                if (Tail != null)
                {
                    Tail = Tail.Prev;
                    Tail.Next = null;
                }
            }

            public void DeleteAll()
            {
                Header = null;
                Tail = null;
            }

            public void ShowList()
            {
                Node<T> temp = Header;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }
        }
    }
}
