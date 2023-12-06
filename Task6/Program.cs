class Stack<T>
{
    private readonly List<T> items;

    public Stack()
    {
        items = new List<T>();
    }

    // Push method
    public void Push(T item)
    {
        items.Add(item);
    }

    // Pop method
    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T poppedItem = items[^1];
        items.RemoveAt(items.Count - 1);
        return poppedItem;
    }

    // Peek method
    public T Peek()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return items[^1];
    }

    // IsEmpty method
    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        Stack<int> intStack = new();

        intStack.Push(69);
        intStack.Push(35);
        intStack.Push(54350);
        int poppedItem = intStack.Pop();
        Console.WriteLine($"Popped : {poppedItem}");
        intStack.Push(40);

        int topItem = intStack.Peek();
        Console.WriteLine($"Top : {topItem}");

        bool isEmpty = intStack.IsEmpty();
        Console.WriteLine($"Is the stack empty? {isEmpty}");
    }
}