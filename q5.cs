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
        Node currentHead = head;
        while (currentHead != null)
        {
            Console.WriteLine(currentHead.data);
            currentHead = currentHead.next;
        }

    }

    public void AddAtCurrentPostioon(string data , int postion)
    {
        int Count = 0;
        var currentHead = head;
        while(currentHead != null)
        {
            if(Count == postion)
            {
                var temp = new Node(data);
                temp.next = currentHead;

                temp.prev = currentHead;
                
            }
            Count++;
        }
    }

}

public class program
{
    public static void Main(string[] args)
    {
        DoubleLinkedList newlist = new DoubleLinkedList();
        newlist.AddLast("2");
        newlist.AddLast("4");
        newlist.AddLast("5");

        newlist.AddAtCurrentPostioon("6" , 2);
        newlist.Display();
    }
}