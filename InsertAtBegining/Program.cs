


public class Node
{
    public int data;
    public Node next;
}
class Program
{
    static Node InsertAtBegining(Node head,int newdata)
    {
        Node newNode= new Node();
        newNode.data = newdata;
        newNode.next = head;
        head = newNode;
        return head;
                         
    }

    static void InsertAtMiddle(Node head,int position ,int newdata)
    {
        Node newNode = new Node();
        newNode.data = newdata;
        Node current = head;


        //traverse the node to insert the value in new postion 
        for(int i= 1;i<position && current != null; i++)
        {
            current=current.next;
        }
        if (current == null)
        {
            Console.WriteLine("Position is out of bound");

        }

        newNode.next = current.next;

        current.next = newNode;
    }
    static void PrintList(Node node)
    {
        while(node != null)
        {
            Console.Write(node.data+" ->");
            node = node.next;

                
        }
       

        Console.WriteLine("null");
    }

    static void Main()
    {
        Node head = null;

        head = InsertAtBegining(head, 40);
        head = InsertAtBegining(head, 30);
        head = InsertAtBegining(head, 20);
        head = InsertAtBegining(head, 10);
        PrintList(head);

       InsertAtMiddle(head, 2, 25);

        Console.WriteLine("After inserting the 25 element at second position");
        PrintList(head);
    }
}