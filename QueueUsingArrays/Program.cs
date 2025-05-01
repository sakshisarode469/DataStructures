MyQueue mq = new MyQueue(5);
mq.Enqueue(10);
mq.Enqueue(20);
mq.Enqueue(30);
mq.Display();
mq.Dequeue();
mq.Peek();
mq.Display();
mq.Enqueue(40);
mq.Enqueue(50);
mq.Display();
Console.WriteLine("Number of element in queue " + mq.Count());

class MyQueue
{
    private int[] queue;
    private int front;
    private int rear;
    private int maxSize;

    public MyQueue(int size)
    {
        maxSize = size;
        queue = new int[maxSize];
        front = 0;
        rear = -1;


    }

    public void Enqueue(int value)
    {
        if (rear == maxSize - 1)
        {
            Console.WriteLine("Overflow Queue");
        }
        rear++;
        queue[rear] = value;
        Console.WriteLine($"Enqueue :{value}");
    }
    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is Underflow");
            return;
        }
        Console.WriteLine($"Dequeued :{queue[front]}");
        front++;
    }

    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is Empty");
        }
        else
        {
            Console.WriteLine($"Front of Queue:{queue[front]}");


        }
    }
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is Empty");
        }
        Console.WriteLine("Queue Elements");
        for (int i = front; i < rear; i++)
        {
            Console.WriteLine(queue[i]);
        }
    }
    public int Count()
    {
        if (IsEmpty())
        {
            return 0;
        }
        return rear - front + 1;
    }

    public bool IsEmpty()
    {
        return front > rear;
    }

}