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


    public void AddByPosition(string value, int position)
    {
        int currentPostion = 0;
        Node newNode = new Node(value);
        Node currentHead = head;
        if (head == null)
        {
            head = new Node(value);
            tail = head;

        }
        else if (position == 1)
        {

            head.prev = newNode;
            newNode.next = head;
            head = newNode;

        }
        else if (position == count)
        {

            tail.next = newNode;
            newNode.prev = tail;
            newNode.next = null;
            tail = newNode;

        }
        else
        {
            while (currentHead != null)
            {
                if (currentPostion + 2 == position)
                {
                    newNode.next = currentHead.next;
                    currentHead.prev = newNode;
                    currentHead.next = newNode;
                    newNode.prev = currentHead;
                    break;
                }
                currentPostion++;
                currentHead = currentHead.next;
            }


        }
        count++;
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
        newlist.AddLast("4");
        newlist.AddLast("5");

        newlist.AddByPosition("3", 1);

        newlist.Display();
    }
}