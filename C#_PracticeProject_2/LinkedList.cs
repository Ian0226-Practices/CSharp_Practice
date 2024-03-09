namespace LinkedListImplement;
class LinkedList<T>
{
    Node<T> head = new Node<T>();
    public int Count = 0;

    public LinkedList()
    {
        head.data = default(T);
        head.next = null;
    }
    
    /// <summary>
    /// Print all element in list.
    /// </summary>
    public void PrintList()
    {
        if(Count == 0)
        {
            Console.WriteLine("The list has no element.");
            return;
        }
        Node<T> temp = new Node<T>();
        temp = head;
        Console.Write("Now list element : ");
        for(int i = 0;i < Count;i++)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        Console.Write("\n");
    }
    
    /// <summary>
    /// Insert element at last position.
    /// </summary>
    /// <param name="data">The data you want store in element.</param>
    public void Insert(T data)
    {
        Node<T> temp1 = new Node<T>();
        temp1.data = data;
        temp1.next = null;

        if(Count == 0)
        {
            head = temp1;
            Count++;
            return;
        }

        Node<T> temp2 = new Node<T>();
        temp2 = head;
        for(int i = 0;i < Count-1;i++)
        {
            temp2 = temp2.next;
        }
        temp2.next = temp1;
        Count++;
    }

    /// <summary>
    /// Insert the element at n position.
    /// </summary>
    /// <param name="data">The data you want store in element.</param>
    /// <param name="n">Insert position,has to larger than 0.</param>
    public void Insert(T data,int n)
    {
        if(n <= 0)
        {
            Console.WriteLine("Incorrect number,must larger than 0");
            return;
        }
        if(n > Count+1)
        {
            Console.WriteLine("Now list count : " + Count + " ,your insert position must in list");
            return;
        }
        Node<T> temp1 = new Node<T>();
        temp1.data = data;
        temp1.next = null;
        
        Count++;

        if(n == 1)
        {
            temp1.next = head.next;
            head.next = temp1;
            PrintList();
            return;
        }

        Node<T> temp2 = new Node<T>();
        temp2 = head;
        int i = 1;
        while(i < n-2)
        {
            temp2 = temp2.next;
            i++;
        }
        temp1.next = temp2.next;
        temp2.next = temp1;
        PrintList();
    }
    
    /// <summary>
    /// Delete the element at n posistion.
    /// </summary>
    /// <param name="n">Delete position,must less than list count or equal to list count,and no 0.</param>
    public void DeleteAt(int n)
    {
        if(n <= 0)
        {
            Console.WriteLine("n has to larger than 0.");
            return;
        }
        if(Count <= 0)
        {
            Console.WriteLine("There are no elements in the list.");
            return;
        }
        Count--;
        //n - 1 element.
        Node<T> temp1 = new Node<T>();
        temp1 = head;
        if(n == 1)
        {
            head = temp1.next;
            temp1 = null;//release temp1
            return;
        }

        int i = 0;
        while(i < n - 2)
        {
            temp1 = temp1.next;
            i++;
        }
        //n element.
        Node<T> temp2 = new Node<T>();
        temp2 = temp1.next;
        temp1.next = temp2.next;
        temp2 = null;//release temp2
    }

    /// <summary>
    /// Reverse the list.
    /// </summary>
    public void Reverse()
    {
        if(Count <= 0)
        {
            Console.WriteLine("There are no elements in the list.");
            return;   
        }
        Node<T> current = new Node<T>();
        current = head;
        if(Count == 1)
        {
            Console.WriteLine("There is only one element in the list.");
            return;
        }
        Node<T> prev = new Node<T>();
        Node<T> next = new Node<T>();

        prev = null;
        while(current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        head = prev;

    }
    
    /// <summary>
    /// Reverse print the list.
    /// </summary>
    public void ReversePrintRecursion()
    {
        ReversePrintRecursionHadler(head);
        Console.Write("\n");
    }
    private void ReversePrintRecursionHadler(Node<T> temp)
    {
        if(temp==null)
        {
            return;
        }
        ReversePrintRecursionHadler(temp.next);
        Console.Write(temp.data + " ");
    }
    
    /// <summary>
    /// Reverse the list.
    /// </summary>
    public void ReverseRecursion()
    {
        ReverseRecursionHandler(head);
        Console.Write("\n");
    }
    private void ReverseRecursionHandler(Node<T> temp)
    {
        if(temp.next == null)
        {
            head = temp;
            return;
        }
        ReverseRecursionHandler(temp.next);
        Node<T> temp2 = temp.next;
        temp2.next = temp;
        temp.next = null;
    }
}

class Node<T>
{
    public T data;
    public Node<T> next;
}