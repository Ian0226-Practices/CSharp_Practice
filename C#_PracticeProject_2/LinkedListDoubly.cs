namespace LinkedListDoublyImplement;

class LinkedListDoubly<T>
{
    Node<T> head = new Node<T>();

    public int Count = 0;

    public LinkedListDoubly()
    {
        head.data = default(T);
        head.next = null;
        head.prev = null;
    }

    /// <summary>
    /// Create a new node and initialize.
    /// </summary>
    /// <returns>Return new node.</returns>
    private Node<T> GetNewNode(T data)
    {
        Node<T> newNode = new Node<T>();
        newNode.data = data;
        newNode.next = null;
        newNode.prev = null;

        return newNode;
    }
    
    /// <summary>
    /// Insert element at head.
    /// </summary>
    /// <param name="data">Value that you want to insert.</param>
    public void InsertAtHead(T data)
    {
        Node<T> newNode = GetNewNode(data);
        
        if(head == null)
        {
            head = newNode;
            Count++;
            return;
        }

        //Create link of new node and head node.
        head.prev = newNode;
        newNode.next = head;

        //Set head to new node.
        head = newNode;
        Count++;
    }

    /// <summary>
    /// Insert element at tail.
    /// </summary>
    /// <param name="data">Value that you want to insert.</param>
    public void InsertAtTail(T data)
    {
        Node<T> newNode = GetNewNode(data);
        if(Count <= 0)
        {
            head = newNode;
            Count++;
            return;
        }
        
        Node<T> temp = new Node<T>();
        temp = head;
        for(int i = 0; i < Count-1; i++)
        {
            temp = temp.next;
        }
        temp.next = newNode;
        newNode.prev = temp;
        newNode.next = null;
        Count++;
    }

    /// <summary>
    /// Insert element at n position.
    /// </summary>
    /// <param name="data">Value that you want to insert.</param>
    /// <param name="n">The position you want to insert.</param>
    public void Insert(T data,int n)
    {
        Node<T> newNode = GetNewNode(data);
        if(Count <= 0)
        {
            head = newNode;
            Count++;
            return;
        }

        Node<T> temp = new Node<T>();
        Node<T> temp2 = new Node<T>();
        temp = head;
        for(int i = 0;i < n-1; i++)
        {
            temp = temp.next;
        }
        temp2 = temp.prev;
        temp2.next = newNode;
        newNode.next = temp;
        newNode.prev = temp2;
        temp.prev = newNode;
        Count++;
    }

    /// <summary>
    /// Print all element in list.
    /// </summary>
    public void PrintList()
    {
        Node<T> temp = new Node<T>();

        if(Count <= 0)
        {
            Console.WriteLine("The list has no element.");
            return;
        }

        temp = head;
        while(temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        Console.Write("\n");
    }

    /// <summary>
    /// Print all element in list reverse.
    /// </summary>
    public void ReversePrintList()
    {
        Node<T> temp = new Node<T>();
        if(Count <= 0)
        {
            Console.WriteLine("The list has no element.");
            return;
        }

        temp = head;
        while(temp.next != null )
        {
            temp = temp.next;
        }

        while(temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.prev;
        }
        Console.Write("\n");
    }
}

class Node<T>
{
    public T data;
    public Node<T> next;
    public Node<T> prev;
}