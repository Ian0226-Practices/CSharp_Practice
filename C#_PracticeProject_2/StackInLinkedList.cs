namespace StackInLinkedListImplement;

class StackInLinkedList<T>
{
    Node<T> top = null;

    /// <summary>
    /// Push a data in stack.
    /// </summary>
    /// <param name="data">Data that you want to push.</param>
    public void Push(T data)
    {
        Node<T> temp = new Node<T>();
        temp.data = data;
        temp.link = top;
        top = temp;
    }

    /// <summary>
    /// Pop a element in stack.
    /// </summary>
    public void Pop()
    {
        if(top == null)
        {
            Console.WriteLine("Stack has no element.");
            return;
        }
        Node<T> temp = new Node<T>();
        temp = top.link;
        top = temp;
        temp = null;
    }

    /// <summary>
    /// Get the top element in stack.
    /// </summary>
    /// <returns>Return top element.</returns>
    public T Top()
    {
        if(top == null)
        {
            Console.WriteLine("Stack has no element.");
            return default(T);
        }
        return top.data;
    }

    /// <summary>
    /// Check stack has element or not.
    /// </summary>
    /// <returns>Return true if has element,otherwise return false.</returns>
    public bool IsEmpty()
    {
        if(top == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Print all stack.
    /// </summary>
    public void PrintAllStack()
    {
        if(top == null)
        {
            Console.WriteLine("Stack has no element.");
            return;
        }
        Node<T> temp = new Node<T>();
        temp = top;
        while(temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.link;
        }
        Console.Write("\n");
    }
}

class Node<T>
{
    public T data;
    public Node<T> link;
}