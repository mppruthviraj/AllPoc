using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSortingTechnique
{
    public class DllNode
    {
        public int value;
        public DllNode Next;
        public DllNode Prev;
    }

    public class DoublyLinkedList
    {
        public DllNode InsertToTheFront(DllNode headPointor, int value)
        {
            DllNode tempNode = new DllNode();
            tempNode.value = value;
            tempNode.Prev = null;
            tempNode.Next = null;

            DllNode pointorToLoop = headPointor;

            if (headPointor.value != 0)
            {
                while (pointorToLoop.Next != null)
                {
                    pointorToLoop = pointorToLoop.Next;
                }
                pointorToLoop.Next = tempNode;

                return headPointor;
            }
            return tempNode;
        }

        public DllNode InsertToTheBack(DllNode headPointor,int value)
        {
            DllNode tempNode = new DllNode();
            tempNode.value = value;
            tempNode.Next = null;
            tempNode.Prev = null;

            DllNode pointorToLoop = headPointor;

            if(headPointor.value != 0)
            {
                while(pointorToLoop.Prev!=null)
                {
                    pointorToLoop = pointorToLoop.Prev;
                }
                pointorToLoop.Prev = tempNode;
                return headPointor;
            }


            return tempNode;
        }

        public DllNode InsertAtaSpecifiedPosition(DllNode headPointor, int value, int position)
        {
            DllNode temp = new DllNode();
            temp.value = value;
            temp.Prev = null;
            temp.Next = null;


           // if(headPointor =)

            return temp;
        }

        public void PrintTheListFront(DllNode headPointor)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("The list elements front are");
            Console.WriteLine("---------------------");


            if(headPointor != null)
            {
                while(headPointor.Next!=null)
                {
                    Console.Write("{0}->",headPointor.value);
                    headPointor = headPointor.Next;

                }
                Console.Write("{0}",headPointor.value);
            }
        }

        public void PrintTheListBack(DllNode headPointor)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("The list elements back are");
            Console.WriteLine("---------------------");

            string outputString=string.Empty;

            if(headPointor != null)
            {
                while(headPointor.Prev!=null)
                {
                    outputString = "<-" + headPointor.value + outputString;
                    headPointor = headPointor.Prev;
                }
                outputString = headPointor.value + outputString;
                Console.WriteLine("\r{0}  ", outputString);
            }

        }


        public void PrintBothLeftAndRightNodes(DllNode headPointor)
        {

        }



    }
}
