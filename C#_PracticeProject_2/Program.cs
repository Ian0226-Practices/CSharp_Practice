using System.Diagnostics;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace C__PracticeProject_2;
class Program
{
    static void Main(string[] args)
    {
        //Linked List.
        /*LinkedListImplement.LinkedList<int> list = new LinkedListImplement.LinkedList<int>();
        list.Insert(5);
        list.Insert(3);
        list.Insert(150);
        list.Insert(9);
        list.Insert(11);

        list.ReversePrintRecursion();
        list.ReverseRecursion();
        list.DeleteAt(2);
        list.Reverse();
        list.PrintList();
        Console.WriteLine(list.Count);*/

        //Doubly Linked List.
        /*LinkedListDoublyImplement.LinkedListDoubly<int> listDoubly = new LinkedListDoublyImplement.LinkedListDoubly<int>();
        listDoubly.InsertAtHead(5);
        listDoubly.InsertAtTail(9);
        listDoubly.InsertAtTail(13);
        listDoubly.InsertAtTail(3);
        listDoubly.Insert(77,3);
        listDoubly.ReversePrintList(); 
        Console.WriteLine(listDoubly.Count);*/

        StackInArrayImplement.StackInArray<int> stack = new StackInArrayImplement.StackInArray<int>();
        stack.Push(3);
        stack.Push(8);
        stack.Push(13);
        Console.WriteLine(stack.IsEmpty());
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();
        
        stack.PrintAllStack();
    }
}
