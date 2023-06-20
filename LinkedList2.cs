using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RFP_Basics_Concept
{
    internal class LinkedList2
    {
        Node head;

        public void AddNewData(int val)
        {
            Node nodeObj = new Node(val);

            if (head == null)
            {
                head = nodeObj;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = nodeObj;
            }
            Console.WriteLine("new Data Addeed in list is: " + nodeObj.Data);
        }
    }
}
