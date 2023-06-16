using System;

namespace Task3;

public class Node
{
    public string? data;
    public Node? next;
    public Node? prev;
    public Node(string value)
    {
        data = value;
        next = null;
        prev = null;
    }

}

public class DoubleLinkedList
{
    public static Node? head;
    public static Node? tail;

    public DoubleLinkedList()
    {
        head = null;
        tail = null;
    }

    public void AddLast(string value)
    {
        if (head == null)
        {
            head = new Node(value);
            tail = head;

        }
        else
        {
            Node newTail = new Node(value);

            tail.next = newTail;
            newTail.prev = tail;
            tail = newTail;
        }
    }
    public void Display()
    {
        Node curentTail = tail;
        while (curentTail != null)
        {
            Console.WriteLine(curentTail.data);
            curentTail = curentTail.prev;
        }

    }


}

public class program
{
    public static void Main(string[] args)
    {
        DoubleLinkedList newlist = new DoubleLinkedList();
        newlist.AddLast("2");
        newlist.AddLast("5");
        newlist.AddLast("8");

        newlist.Display();
    }
}