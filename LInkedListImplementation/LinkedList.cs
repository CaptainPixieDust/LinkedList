using System;
using System.Collections;
namespace LInkedListImplementation
{
    public class LinkedList<T> : IEnumerable
    {
        public class Node
        {
            public Node previous { get; set; }
            public Node next { get; set; }
            public T data { get; set; }

            public Node() { }
            public Node(T d)
            {
                data = d;
            }
        }
        private Node Head;
        private Node Tail;
        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddFirst(T data){
            Node newNode = new Node(data);
            newNode.next = Head;
            newNode.previous = null;
            if(Head != null){
                Head.previous = newNode;
            }
            else
            {
                Tail = newNode;
            }
            Head = newNode;
            Count++;
        }

        public void AddLast(T data){
            Node node = new Node(data);
            node.next = null;
            if(Tail == null){
                Head = node;
                Tail = node;
                node.previous = null;
            }
            else{
                Tail.next = node;
                node.previous = Tail;
                Tail = node;
            }
            Count++;
        }

        public void RemoveLast(){
            //if(head == null) //error
            if(Head == Tail){
                Head = null;
                Tail = null;
            }
            else{
                Tail = Tail.previous;
                Tail.next = null;
            }
            Count--;
        }

        public void RemoveFirst()
        {
            if(Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.next;
                Head.previous = null;
            }
            Count--;
        }

        public void Remove(T data)
        {
            Node before = null;
            Node current = Head;

            while(!Equals(current.data, data))
            {
                before.next = current;
                current = current.next;
            }
            if(current == Head)
            {
                Head = Head.next;
                Head.previous = null;
            }
            else
            {
                before.next = current.next;
                current.next.previous = before;
            }
            Count--;
        }

        public void AddAfter(Node node, T data){
            Node newNode = new Node(data);
            newNode.next = node.next;
            newNode.previous = node;
            node.next = newNode;
            if(newNode.next != null){
                newNode.next.previous = newNode;
            }
            if(Tail == node){
                Tail = newNode;
            }
            Count++;
        }

        public void AddBefore(Node node, T data){
            Node newNode = new Node(data);
            newNode.next = node;
            newNode.previous = node.previous;
            node.previous = newNode;
            if(newNode.previous != null){
                newNode.previous.next = newNode;
            }
            if(Head == node){
                Head = newNode;
            }
            Count++;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T data)
        {
            Node node = Head;
            while(!Equals(node.data, data) && node.next != null)
            {
                node = node.next;
            }
            if(!Equals(node.data, data))
            {
                return false;
            }

            return true;
        }

        public Node Find(T data)
        {
            Node node = Head;
            while(!Equals(node.data, data))
            {
                node = node.next;
            }

            return node;
        }

        public IEnumerator GetEnumerator()
        {
            var node = Head;
            while (node != null)
            {
                yield return node.data;
                node = node.next;
            }
        }
    }
}
