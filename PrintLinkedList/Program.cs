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
class Program
{
    static void PrintList(Node  node)
    {
        while (node != null)
        {
            Console.Write(node.data+"-> ");
            node = node.next;
        }
        Console.WriteLine("null");
    }

    static void Main()
    {
        Node head = new Node(10);
        Node second = new Node(20);
        Node third = new Node(30);

        head.next = second;

        second.next = third;
        PrintList(head);
    }
}