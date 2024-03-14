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
    /// Print all stack.
    /// </summary>
    public void PrintAllStack()
    {
        while(top >= 0)
        {
            Console.Write(array[top] + " ");
            top--;
        }
        Console.Write("\n");
    }
}