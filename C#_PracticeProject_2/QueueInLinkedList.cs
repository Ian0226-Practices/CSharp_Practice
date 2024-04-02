namespace QueueInLinkedListImplement;

class QueueInLinkedList<T>
{
    private Node<T> rear = null;
    private Node<T> front = null;

    /// <summary>
    /// Push a element into queue from rear.
    /// </summary>
    /// <param name="data">The value you want to push.</param>
    public void Enqueue(T data)
    {
        Node<T> temp = new Node<T>();
        temp.data = data;
        temp.next = null;
        
        if(IsEmpty())
        {
            front = temp;
            rear = temp;
            return;
        }
        
        rear.next = temp;
        rear = temp;
    }

    /// <summary>
    /// Pop the element into queue from front.
    /// </summary>
    public void Dequeue()
    {
        if(IsEmpty())
        {
            Console.WriteLine("There has no element in queue.");
            return;
        }
        if(front == rear)
        {
            front = null;
            rear = null;
            return;
        }

        Node<T> temp = new Node<T>();
        temp = front.next;
        front = temp;
    }

    /// <summary>
    /// Return front value.
    /// </summary>
    /// <returns>Queue front value.</returns>
    public T Front()
    {
        return front.data;
    }

    /// <summary>
    /// Check if queue is empty.
    /// </summary>
    /// <returns>Return bool.</returns>
    public bool IsEmpty()
    {
        return rear == null ? true : false;
    }

    public void PrintQueue()
    {
        if(IsEmpty())
        {
            Console.WriteLine("There has no element in queue.");
            return;
        }

        Node<T> temp = new Node<T>();
        temp = front;
        while(temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        Console.WriteLine();
    }
}

class Node<T>
{
    public T data;
    public Node<T> next;
}