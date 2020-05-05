using System;
using System.Collections;
using System.Collections.Generic;

namespace HackerRank.YoutubeEstructurasDatos.Stack
{
    class Stack
    {
        public static void Main(String[] args)
        {
            PushDownStack<string> pushDownStack = new PushDownStack<string>();
            pushDownStack.push("Hola");
            pushDownStack.push("Mundo");

            while(pushDownStack.size() > 0)
            {
                Console.WriteLine(pushDownStack.pop());
            }

            Console.ReadKey();
        }
    }

    public class PushDownStack<Item> : IEnumerable<Item>
    {
        private Node first;
        private int N;

        private class Node
        {
            private Item item;
            private Node next;

            public Node(Item item)
            {
                this.item = item;
                this.next = null;
            }

            public void setItem(Item item) { this.item = item; }
            public void setNext(Node next) { this.next = next; }
            public Item getItem() { return this.item; }
            public Node getNext() { return this.next; }
        }

        public bool isEmpty() => first == null;

        public int size() => N;

        public void push(Item item)
        {
            Node oldFirst = first;
            Node newNode = new Node(item);
            newNode.setNext(oldFirst);
            first = newNode;
            N++;
        }

        public Item pop()
        {
            Item item = first.getItem();
            first = first.getNext();
            N--;
            return item;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            Node temporalTraverse = first;
            while (temporalTraverse.getNext() != null)
            {
                yield return temporalTraverse.getItem();
                temporalTraverse.getNext();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
