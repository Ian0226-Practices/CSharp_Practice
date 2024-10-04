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
        stack.IsEmpty();
        
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

        /*QueueInArrayImplement.QueueInArray<int> queueInArray = new QueueInArrayImplement.QueueInArray<int>();
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
        queueInArray.PrintQueue();*/

        Program program = new Program();
        /*string str = "HelloWorld";
        str = program.StringReverse(str);
        Console.WriteLine(str);*/

        //program.PrintStarTower(8);

        #region  Queue implement by Linked List.
        /*QueueInLinkedListImplement.QueueInLinkedList<int> queue = new QueueInLinkedListImplement.QueueInLinkedList<int>();
        queue.Enqueue(8);
        queue.Enqueue(5);
        queue.Enqueue(2);
        queue.Dequeue();
        Console.WriteLine(queue.Front());

        queue.PrintQueue();*/
        #endregion

        //PrefixAndPostfixExpressions.Postfix postfix = new PrefixAndPostfixExpressions.Postfix();
        //Console.Write(postfix.CatchLetters('-'));
        // postfix.EvaluatePostfix("A*B+C-D".ToCharArray());
        // postfix.PrintPostfixExp();

        BST.BSTImplement bst = new BST.BSTImplement();
        bst.Insert(bst.root, 9);
        bst.Insert(bst.root, 20);
        bst.Insert(bst.root, 99);
        bst.Insert(bst.root, 13);
        bst.Insert(bst.root, 35);
        bst.Insert(bst.root, 18);
        bst.Insert(bst.root, 105);
        bst.Insert(bst.root, 1);

        // Console.WriteLine(bst.FinMinRecursion(bst.root));
        // Console.WriteLine(bst.Search(bst.root, 100));
        Console.WriteLine(bst.FindHeight(bst.root));

    }

    public string StringReverse(string str)
    {
        char[] c = str.ToCharArray();
        Stack<char> S = new Stack<char>();

        //將字元放入Stack
        for (int i = 0; i < c.Length; i++)
        {
            S.Push(c[i]);
        }

        //將字元從Stack中拔除並放回字元陣列
        for (int i = 0; i < c.Length; i++)
        {
            c[i] = S.Pop();
        }
        string str1 = new string(c);
        return str1;
    }

    public void PrintStarTower(int towerHeight)
    {
        int tHeight = towerHeight;

        for (int i = 1; i <= tHeight; i++)
        {
            for (int j = 1; j <= tHeight - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
