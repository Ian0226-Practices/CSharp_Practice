namespace StackInArrayImplement;

class StackInArray<T>
{
    private const int maxSize = 101;
    T[] array = new T[maxSize];
    int top = -1;

    /// <summary>
    /// Push a data in stack.
    /// </summary>
    /// <param name="data">Data that you want to push.</param>
    public void Push(T data)
    {
        if(top == maxSize-1)
        {
            Console.WriteLine("Stack overflow.");
            return;
        }
        array[++top] = data;
    }

    /// <summary>
    /// Pop a element in stack.
    /// </summary>
    public void Pop()
    {
        if(top == -1)
        {
            Console.WriteLine("Error ! Stack has no element,can't pop.");
            return;
        }
        top--;
    }

    /// <summary>
    /// Print all stack.
    /// </summary>
    public void PrintAllStack()
    {
        if(top == -1)
        {
            Console.WriteLine("Stack has no element.");
            return;
        }
        while(top >= 0)
        {
            Console.Write(array[top] + " ");
            top--;
        }
        Console.Write("\n");
    }
}