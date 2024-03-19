namespace QueueInArrayImplement;

class QueueInArray<T>
{
    private static int size = 10;
    private T[] array = new T[size];
    int front = -1;
    int rear = -1;
    
    /// <summary>
    /// Push a element into queue from rear.
    /// </summary>
    /// <param name="data">The value you want to push.</param>
    public void Enqueue(T data)
    {
        if(IsFull())
        {
            return;
        }
        else if(IsEmpty())
        {
            rear = 0;
            front = 0;
            array[rear] = data;
        }
        else
        {
            rear = (rear+1)%size;
        }
        array[rear] = data;
    }

    /// <summary>
    /// Pop the element into queue from front.
    /// </summary>
    public void Dequeue()
    {
        if(IsEmpty())
        {
            Console.WriteLine("Queue has no element");
            return;
        }
        else if(front == rear)
        {
            front = -1;
            rear = -1;
        }
        front = (front+1)%size;
    }

    /// <summary>
    /// Return front value.
    /// </summary>
    /// <returns>Queue front value.</returns>
    public T Front()
    {
        return array[front];
    }

    /// <summary>
    /// Check if queue is empty.
    /// </summary>
    /// <returns>Return bool.</returns>
    public bool IsEmpty()
    {
        if(front == -1 && rear == -1)
        {
            return true;
        }
        else
        {
            return false;
        }   
    }

    /// <summary>
    /// Check if queue is full.
    /// </summary>
    /// <returns>Return bool.</returns>
    public bool IsFull()
    {
        if((rear+1)%size==front)
        {
            Console.WriteLine("Queue is full.");
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Print queue all element.
    /// </summary>
    public void PrintQueue()
    {
        if(IsEmpty())
        {
            return;
        }

        int i = front;
        while(i != rear)
        {
            Console.Write(array[i] + " ");
            i = (i+1)%size;
        }
        Console.Write(array[i] + " ");
        Console.Write("\n");
    }
}