using HackerRank.DataStructures.Structures;
using System;

namespace HackerRank.YoutubeEstructurasDatos.SinglyLinkedList
{
    class SinglyLinkedList
    {
        public static void MainLL(string[] args)
        {
            LinkedList singlyLinkedList = new LinkedList();
            singlyLinkedList.Append("A");
            singlyLinkedList.Append("B");
            singlyLinkedList.Append("D");
            singlyLinkedList.AddFirst("AA");
            singlyLinkedList.AddAfter("C", "B");
            singlyLinkedList.Remove("A");
            singlyLinkedList.Print();

            Console.ReadKey();
        }
    }

    public class LinkedList {
        Node head = null;

        public void Append(string data)
        {
            Node newNode = new Node(data);

            if (head == null)
                head = newNode;
            else
            {
                Node temporalNode = head;
                while(temporalNode.getNext() != null)
                {
                    temporalNode = temporalNode.getNext();
                }

                temporalNode.setNext(newNode);
            }
        }

        public void AddFirst(string data)
        {
            Node newNode = new Node(data);
            newNode.setNext(head);
            head = newNode;
        }

        public void AddAfter(string data, string afterThis)
        {
            Node temporalNode = head;
            Node newNode = new Node(data);

            if (temporalNode != null) {
                while (temporalNode.getNext() != null)
                {
                    if (temporalNode.getData().Equals(afterThis))
                    {
                        newNode.setNext(temporalNode.getNext());
                        temporalNode.setNext(newNode);
                    }

                    temporalNode = temporalNode.getNext();
                }
            }
        }

        public void Remove(string nodeToRemove)
        {
            Node temporalNode = head;
            Node previous = null;
            bool found = false;

            while (temporalNode != null && found == false)
            {
                if (temporalNode.getData().Equals(nodeToRemove))
                {
                    if(previous == null)
                    {
                        head = temporalNode.getNext();
                        temporalNode.setNext(null);
                    } else
                    {
                        previous.setNext(temporalNode.getNext());
                        temporalNode.setNext(null);
                    }

                    found = true;
                }

                previous = temporalNode;
                temporalNode = temporalNode.getNext();
            }
        }

        public void Print()
        {
            Node current = head;
            while(current != null)
            {
                Console.Write(string.Concat("[",current.getData(),"]","->"));

                current = current.getNext();
            }
        }
    }

    public class Node {
        private string data;
        private Node next;

        public Node(string data)
        {
            this.data = data;
            this.next = null;
        }

        public void setData(string data) { this.data = data; }
        public void setNext(Node next) { this.next = next; }

        public string getData() { return this.data; }
        public Node getNext() { return this.next; }
    }
}
