
StackLinkedList stl = new StackLinkedList();
stl.Push(10);
stl.Push(20);
stl.Push(30);
stl.PrintStack();


public class Node
{
    public int data;
    public Node next;

    public Node(int value)
    {
        data = value;
        next = null;

    }
}
public class StackLinkedList
{
    private Node top;

    public StackLinkedList()
    {
        top = null;
    }
    public void Push(int value)
    {
        Node newnode = new Node(value);
        newnode.next = top;
        top = newnode;
        Console.WriteLine($"Pushed :{value}");
    }
    public void PrintStack()
    {
        Node current = top;
        while (current != null)
        {
            Console.WriteLine(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }

}