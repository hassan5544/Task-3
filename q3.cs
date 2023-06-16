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

    public void AddFirst(string value)
    {
        if (head == null)
        {
            head = new Node(value);
            tail = head;
        }
        else
        {
            Node? newHead = new Node(value);
            newHead.next = head;
            head.prev = newHead;
            head = newHead;



        }
    }

    public void Display()
    {
        Node currentHead = head;
        while (currentHead != null)
        {
            Console.WriteLine(currentHead.data);
            currentHead = currentHead.next;
        }

    }


}

public class program
{
    public static void Main(string[] args)
    {
        DoubleLinkedList newlist = new DoubleLinkedList();
        newlist.AddFirst("test1");
        newlist.AddFirst("test2");
        newlist.AddFirst("test3");
        newlist.AddFirst("test4");

        newlist.Display();
    }
}