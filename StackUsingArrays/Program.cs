public class StackUsingArray
{
    private int[] stack;
    private int top;
    private int capacity;


    public StackUsingArray(int size)
    {
        stack = new int[size];
        capacity = size;
        top = -1;

    }

    public void Push(int value)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Stack is Overflow");

        }
        stack[++top] = value;
        Console.WriteLine($"Pushed :{value}");
    }
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        return stack[top--];
    }

    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
        }
        return stack[top];

    }
    public bool IsEmpty()
    {
        return top == -1;
    }

    public int Count()
    {
        return top + 1;
    }
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Empty");
        }
        else
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            StackUsingArray sua = new StackUsingArray(5);

            sua.Push(10);
            sua.Push(20);
            sua.Push(30);


            Console.WriteLine($"Top:{sua.Peek()}");
            Console.WriteLine($"Poped:{sua.Pop()}");
            Console.WriteLine($"Top after pop:{sua.Peek()}");
            Console.WriteLine($"stack isempty:{sua.IsEmpty()}");
            Console.WriteLine($"Stack Count:{sua.Count()}");

            sua.Display();



        }

    }
}