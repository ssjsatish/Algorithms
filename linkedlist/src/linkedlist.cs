using System;
using System.Collections.Generic;
using System.IO;
public class LinkedList
{
    Node head;
    public class Node
    {
        int data;
        Node next;
        public Node(int d)
        {
            int data = d;
            Node next = null;
        }
    }
    public void printList(Node head)
    {
        if(head!=null)
        {
            Console.Write("{0} ", head.data);
            head = head.next;
            printList(head);
        }
    }

    public static void Main(string[] args)
    {
        LinkedList llist = new LinkedList();
        llist.head = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);
        head.next = second;
        second.next = third;
        llist.printList(llist.head);
    }
}