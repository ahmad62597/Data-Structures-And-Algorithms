using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
  
        // First node in the linked list
        public Node Head { get; set; }

        // Always points to current node in the list
        public Node Current { get; set; }

        public LList(Node node)
        {
            Head = node;
            Current = node;
        }


        // Inserts a node at the beginning of the LL, O(1)

        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

      
        // Prints out all values in the linked list
        public void Print()
        {
            Current = Head;
            while (Current != null)
            {
                Console.WriteLine($"{Current.Value}-->");
                Current = Current.Next;
            }
        }

  
        // Adds a node to the end of the LL. O(n).
 
        public void Append(Node node)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }

 
        // Adds the new node before the node with the specified value
       
        public void AddBefore(Node newNode, int valueOfExistingNode)
      {
            Current = Head;
            //Otherwise, look for the node with the given value
            //and insert the new node before it
            while (Current.Next != null)
            {
                if (Current.Next.Value == valueOfExistingNode)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    Current = newNode.Next;
                }
                else
                {
                    Current = Current.Next;
                }
            }
        }

        // Adds the new node after the node with the specified value
       
        public void AddAfter(Node newNode, int valueOfExistingNode)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Value == valueOfExistingNode)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                }
                Current = Current.Next;
            }
        }

        // Returns the kth value from the end
     
        public int KthFromEnd(int k)
        {
            int length = 0;
            Current = Head;

            while (Current != null)
            {
                length++;
                Current = Current.Next;
            }

            if (k > length - 1)
            {
                throw new Exception("Out of range");
            }

            Current = Head;
            for (int i = 0; i < length - k - 1; i++)
            {
                Current = Current.Next;
            }
            return Current.Value;
        }
    }
}