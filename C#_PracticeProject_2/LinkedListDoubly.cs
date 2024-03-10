namespace LinkedListDoublyImplement;

class LinkedListDoubly<T>
{
    private Node<T> head = new Node<T>();

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
        Node<T> temp = GetNewNode(data);
        if(head == null)
        {
            head = temp;
            return;
        }

        //Create link of new node and head node.
        head.prev = temp;
        temp.next = head;

        //Set head to new node.
        head = temp;
        Count++;
    }

    /// <summary>
    /// Insert element at tail.
    /// </summary>
    /// <param name="data">Value that you want to insert.</param>
    public void InsertAtTail(T data)
    {

    }

    /// <summary>
    /// Insert element at n position.
    /// </summary>
    /// <param name="data">Value that you want to insert.</param>
    /// <param name="n">The position you want to insert.</param>
    public void Insert(T data,int n)
    {

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
        for(int i = 0; i < Count;i++)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        /*if(temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }*/
        Console.Write("\n");
    }

    /// <summary>
    /// Print all element in list reverse.
    /// </summary>
    public void ReversePrintList()
    {

    }
}

class Node<T>
{
    public T data;
    public Node<T> next;
    public Node<T> prev;
}