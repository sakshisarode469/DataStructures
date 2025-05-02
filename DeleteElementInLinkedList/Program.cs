using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class SinglyLinkedList
{
    public Node head;


    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.next != null)
        {
            current = current.next;
        }
        current.next = newNode;
    }


    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }


    public void DeleteFirst()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Console.WriteLine($"Deleted: {head.data}");
        head = head.next;
    }


    public void DeleteLast()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.next == null)
        {
            Console.WriteLine($"Deleted: {head.data}");
            head = null;
            return;
        }

        Node current = head;
        while (current.next.next != null)
        {
            current = current.next;
        }

        Console.WriteLine($"Deleted: {current.next.data}");
        current.next = null;
    }
}
class Program
{
    static void Main()
    {
        SinglyLinkedList list = new SinglyLinkedList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);
        list.Insert(50);

        Console.WriteLine("Original List:");
        list.Display();

        list.DeleteFirst();        
        list.Display();

        list.DeleteLast();         
        list.Display();

       
    }
}



