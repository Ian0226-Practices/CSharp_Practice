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
        LinkedListImplement.LinkedList<int> list = new LinkedListImplement.LinkedList<int>();
        list.Insert(5);
        list.Insert(3);
        list.Insert(150);
        list.Insert(9);
        list.Insert(11);

        //list.ReversePrintRecursion();

        //list.ReverseRecursion();
        //list.DeleteAt(2);
        //list.Reverse();
        //list.PrintList();
        //Console.WriteLine(list.Count);

        LinkedListDoublyImplement.LinkedListDoubly<int> listDoubly = new LinkedListDoublyImplement.LinkedListDoubly<int>();
        listDoubly.InsertAtHead(5);
        listDoubly.InsertAtHead(9);
        listDoubly.InsertAtHead(13);
        listDoubly.InsertAtHead(3);
        listDoubly.PrintList(); 
        Console.WriteLine(listDoubly.Count);
    }
}
