using System;
using System.Net.Http.Headers;

namespace ConsoleApp8;
public class Node
{
    public int data;
    public Node? next;
    public Node? prev;

    public Node(int value)
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


  
    public void AddLast(int value)
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

   
    public void Display()
    {
        int count = 0;
        Node currentHead = head;
        Console.Write("linked list in string format: ");

        while (currentHead != null)
        {
            Console.Write((currentHead.data).ToString() + " ");
            currentHead = currentHead.next;
        }

    }


}

public class program
{
    public static void Main(string[] args)
    {
        DoubleLinkedList newlist = new DoubleLinkedList();
        newlist.AddLast(2);
        newlist.AddLast(3);
        newlist.AddLast(4);
        newlist.AddLast(5);
        newlist.AddLast(10);
        newlist.Display();

    }
}