using System.Security.Cryptography.X509Certificates;

Queue q = new Queue();
q.Enqueue(10);
q.Enqueue(20);
q.Enqueue(30);
q.Enqueue(40);
q.Dequeue();
q.Display();
q.Dequeue();
q.Peek();
q.Display();

public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}
public class Queue
{
    private Node front;
    private Node rear;

    public Queue()
    {
        front = null;
        rear = null;
    }

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if (rear == null)
        {
            rear = front = newNode;
        }
        else
        {

            rear.next = newNode;
            rear = newNode;

        }
        Console.WriteLine($"{data} : Enqueue to the queue");

    }

    public void Dequeue()
    {
        if (front == null)
        {
            Console.WriteLine("Dequeue is empty nothing to dequeue ");
        }

        Console.WriteLine($"{front.data} :Dequeue from the queue");
        front = front.next;
        if (front == null)
        {
            rear = null;
        }



    }
    public void Peek()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine($"Front element is {front.data}");
        }
    }

    public void Display()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is Empty");
        }

        Console.Write("Queue elements: ");
        Node temp = front;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        Console.WriteLine();
    }

}




