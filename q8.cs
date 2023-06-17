using System;
using System.Net.Http.Headers;

namespace ConsoleApp8;
public class Node
{
    public string data;
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
    public static int count = 0;
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
        count++;
    }

    public void delete()
    {
        if (head == null)
        {
            Console.WriteLine("empty");

        }
        else if (count == 1)
        {
            head = null;
        }
        else
        {
            tail = tail.prev;
            tail.next = null;
        }
        --count;
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
        newlist.AddLast("2");
        newlist.AddLast("3");
        newlist.AddLast("4");
        newlist.AddLast("5");
        newlist.Display();
        newlist.delete();
        newlist.Display();

    }
}