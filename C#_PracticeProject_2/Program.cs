using System.Diagnostics;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace C__PracticeProject_2;
class Program
{
    static void Main(string[] args)
    {
        #region Linked List.
        /*LinkedListImplement.LinkedList<int> list = new LinkedListImplement.LinkedList<int>();
        list.Insert(5);
        list.Insert(3);
        list.Insert(7);
        list.Insert(15);
        list.ReverseUsingStack();
        list.PrintList();
        Console.WriteLine(list.Count);*/
        #endregion

        #region Doubly Linked List.
        /*LinkedListDoublyImplement.LinkedListDoubly<int> listDoubly = new LinkedListDoublyImplement.LinkedListDoubly<int>();
        listDoubly.InsertAtHead(5);
        listDoubly.InsertAtTail(9);
        listDoubly.InsertAtTail(13);
        listDoubly.InsertAtTail(3);
        listDoubly.Insert(77,3);
        listDoubly.ReversePrintList(); 
        Console.WriteLine(listDoubly.Count);*/
        #endregion

        #region Stack implement by Array.
        /*StackInArrayImplement.StackInArray<int> stack = new StackInArrayImplement.StackInArray<int>();
        stack.Push(3);
        stack.Push(8);
        stack.Push(13);
        Console.WriteLine(stack.IsEmpty());
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();
        
        stack.PrintAllStack();*/
        #endregion

        #region Stack implemented by Linked List.
        /*StackInLinkedListImplement.StackInLinkedList<int> stackL = new StackInLinkedListImplement.StackInLinkedList<int>();
        stackL.Push(5);
        stackL.Push(9);
        stackL.Push(53);
        stackL.Push(3);
        stackL.Pop();
        stackL.Pop();
        stackL.Pop();
        stackL.Pop();
        stackL.PrintAllStack();
        Console.WriteLine(stackL.Top());*/
        #endregion

        QueueInArrayImplement.QueueInArray<int> queueInArray = new QueueInArrayImplement.QueueInArray<int>();
        queueInArray.Enqueue(9);
        queueInArray.Enqueue(6);
        queueInArray.Enqueue(3);
        queueInArray.Dequeue();
        queueInArray.Enqueue(15);
        queueInArray.Enqueue(19);
        queueInArray.Enqueue(7);
        queueInArray.Enqueue(1);
        queueInArray.Enqueue(5);
        queueInArray.Enqueue(29);
        queueInArray.Enqueue(17);
        queueInArray.Enqueue(55);
        Console.WriteLine(queueInArray.Front());
        queueInArray.PrintQueue();

        /*Program program = new Program();
        string str = "HelloWorld";
        str = program.StringReverse(str);
        Console.WriteLine(str);*/
    }

    public string StringReverse(string str)
    {
        char[] c = str.ToCharArray();
        Stack<char> S = new Stack<char>();

        //將字元放入Stack
        for(int i=0; i < c.Length;i++)
        {
            S.Push(c[i]);
        }

        //將字元從Stack中拔除並放回字元陣列
        for(int i=0; i < c.Length;i++)
        {
            c[i] = S.Pop();
        }
        string str1 = new string(c);
        return str1;
    }
}
