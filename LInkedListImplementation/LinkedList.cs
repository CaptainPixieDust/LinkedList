using System;
namespace LInkedListImplementation
{
    public class LinkedList
    {
        private Node head;
        private Node tail;

        public void AddFirst(object data){
            Node newNode = new Node(data);
            newNode.next = head;
            newNode.previous = null;
            if(head != null){
                head.previous = newNode;
            }
            head = newNode;
        }

        public void AddLast(object data){
            Node node = new Node(data);
            node.next = null;
            if(tail == null){
                head = node;
                tail = node;
                node.previous = null;
            }
            else{
                tail.next = node;
                node.previous = tail;
                tail = node;
            }
        }

        public void RemoveLast(){
            //if(head == null) //error
            if(head == tail){
                head = null;
                tail = null;
            }
            else{
                tail = tail.previous;
                tail.next = null;
            }
        }

        public void AddAfter(Node node, object data){
            Node newNode = new Node(data);
            newNode.next = node.next;
            newNode.previous = node;
            node.next = newNode;
            if(newNode.next != null){
                newNode.next.previous = newNode;
            }
            if(tail == node){
                tail = newNode;
            }
        }

        public void AddBefore(Node node, object data){
            Node newNode = new Node(data);
            newNode.next = node;
            newNode.previous = node.previous;
            node.previous = newNode;
            if(newNode.previous != null){
                newNode.previous.next = newNode;
            }
            if(head == node){
                head = newNode;
            }
        }
    }
}
