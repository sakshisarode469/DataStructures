

class Node
{
    int data;
    Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }

    public class SinglyLinkedList
    {
        public Node head;

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;
            while(current.next!= null)
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
                Console.Write(current.data+" ->");
                current = current.next;
            }
            Console.WriteLine("null");
        }
        public bool Search(int value)
        {
            Node current = head;
            int position = 0;
            while (current != null)
            {
                if (current.data== value)
                {
                    Console.WriteLine($"Value {value} found at position {position}");
                    return true;
                }
                current = current.next;
                position++;

            }
            Console.WriteLine($"Value {value}is not found");
            return false;
        }


        class Program
        {
            static void Main()
            {
                SinglyLinkedList sll = new SinglyLinkedList();
                sll.Insert(10);
                sll.Insert(20);
                sll.Insert(30);
                sll.Insert(40);

                sll.Display();
                sll.Search(20);
                sll.Search(10);
            }
        }
    }
}