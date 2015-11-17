using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSortingTechnique
{
    public class Node
    {
        public int value;
        public Node Next;
    }
    public class LinkedList
    {
        public Node InsertToTheList(Node headPointor, int data)
        {
            Node tempNode = new Node();
            tempNode.value = data;
            tempNode.Next = null;

            Node pointorToLoop = headPointor;

            if (headPointor.value != 0)
            {
                while (pointorToLoop.Next != null)
                {
                    pointorToLoop = pointorToLoop.Next;
                }
                pointorToLoop.Next = tempNode;
                //headPointor = pointorToLoop;
                return headPointor;
            }

            return tempNode;

        }
        public Node InsertFromFrontToTheList(Node headPointor, int data)
        {
            Node tempNode = new Node();
            tempNode.value = data;
            tempNode.Next = null;

            if (headPointor.value != 0)
            {
                tempNode.Next = headPointor;
                headPointor = tempNode;
                return headPointor;
            }

            return tempNode;

        }
        public Node InsertAtTheGivenPositionToTheList(Node headPointor, int data, int position)
        {
            Node tempNode = new Node();
            tempNode.value = data;
            tempNode.Next = null;
            int i = 0;
            Node previousNode = new Node();
            Node loopingPointor = headPointor;
            if (headPointor.value != 0)
            {
                if(position == 0)
                {
                    tempNode.Next=headPointor;
                    headPointor = tempNode;
                }
                if(position == 1)
                {
                    tempNode.Next = headPointor.Next;
                    headPointor.Next = tempNode;
                }

                else
                {
                    while(loopingPointor.Next != null && i<position)
                    {
                        previousNode = loopingPointor;
                        loopingPointor = loopingPointor.Next;
                        i++;
                    }
                    previousNode.Next = tempNode;
                    tempNode.Next = loopingPointor;
                }
               
                return headPointor;
            }
            return tempNode;

        }

        public void PrintTheList(Node headPointor)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("The List elements are");
            Console.WriteLine("---------------------");
            if(headPointor == null)
            {
                return;
            }
            for(;headPointor.Next != null;headPointor=headPointor.Next)
            {
                Console.Write("{0}->",headPointor.value);
            }
            Console.Write("{0}\n",headPointor.value);

        }

        public Node DeleteUsingValue(Node headPointor, int dataToBeDeleted)
        {
            if(headPointor == null)
            {
                return null;
            }
            Node previousNode = new Node();
            Node loopingPointor = headPointor;
            while (loopingPointor.value != dataToBeDeleted && loopingPointor.Next != null)
            {
                previousNode = loopingPointor;
                loopingPointor = loopingPointor.Next;
            }
            if (loopingPointor.value == dataToBeDeleted)
            {
                if(previousNode.value == dataToBeDeleted)
                {
                    headPointor = null;
                }
                else
                {
                    previousNode.Next = loopingPointor.Next;
                }
            }

            return headPointor;
        }

        public Node DeleteUsingPosition(Node headPointor, int position)
        {
            if(headPointor == null)
            {
                return null;
            }
            Node previousNode = headPointor;
            Node loopingPointor = headPointor;
            int i = 0;
            while(i<position && loopingPointor.Next!=null)
            {
                previousNode = loopingPointor;
                loopingPointor = loopingPointor.Next;
                i++;
            }

            if(loopingPointor.value==previousNode.value)
            {
                headPointor = null; 
            }
            else
            {
                previousNode.Next = loopingPointor.Next;
            }

            return headPointor;
        }

    }
}
