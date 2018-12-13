using System;
namespace LInkedListImplementation
{
    public class Node
    {
        public Node previous { get; set; }
        public Node next  { get; set; }
        public Object data { get; set; }

        public Node(object d)
        {
            data = d;
        }
    }
}
