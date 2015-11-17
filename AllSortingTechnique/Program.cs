using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllSortingTechnique
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 87,45,677,3,3,2,8,1};
            BubbleSort bbs = new BubbleSort();
            SelectionSort ss = new SelectionSort();
            ReverseArray ra = new ReverseArray();
            Seggregate0and1 sg = new Seggregate0and1();

            //Console.WriteLine("Arry unsorted");
            //Console.WriteLine("---------------------------------");
            //foreach(int a in array)
            //{
            //    Console.WriteLine(a.ToString());
            //}

            //Console.WriteLine("Using buble sort");
            //int[] arraySortedBubbleSort = bbs.BubbleSortArray(array);

            //Console.WriteLine("Arry sorted");
            //Console.WriteLine("---------------------------------");
            //foreach (int a in arraySortedBubbleSort)
            //{
            //    Console.WriteLine(a.ToString());
            //}

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Using Selection sort");
            //int[] arraySortedSelectionSort = ss.SelectionSortArray(array);

            //Console.WriteLine("Arry sorted");
            //Console.WriteLine("---------------------------------");
            //foreach (int a in arraySortedSelectionSort)
            //{
            //    Console.WriteLine(a.ToString());
            //}

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Reversing Array");
            //int[] arrayReversed = ra.ReverseArrayNow(array);

            //Console.WriteLine("Arry reversed");
            //Console.WriteLine("---------------------------------");
            //foreach (int a in arrayReversed)
            //{
            //    Console.WriteLine(a.ToString());
            //}

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Seggregare 0 and 1");
            //int[] arr = {1,1,0,1,0};

            //arr = sg.segregate0and1(arr, arr.Length);

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Seggregated");
            //Console.WriteLine("---------------------------------");
            //foreach (int a in arr)
            //{
            //    Console.WriteLine(a.ToString());
            //}


            //LinkedList ll = new LinkedList();
            //Node headPointor = new Node();
            //headPointor = ll.InsertAtTheGivenPositionToTheList(headPointor, 2,0);
            //headPointor = ll.InsertAtTheGivenPositionToTheList(headPointor, 3,1);
            //headPointor = ll.InsertAtTheGivenPositionToTheList(headPointor, 10,1);
            //headPointor = ll.InsertAtTheGivenPositionToTheList(headPointor, 5,2);
            //headPointor = ll.InsertAtTheGivenPositionToTheList(headPointor, 6,4);
            //headPointor = ll.InsertAtTheGivenPositionToTheList(headPointor, 10,3);
            //headPointor = ll.InsertAtTheGivenPositionToTheList(headPointor, 11, 0);

            //ll.PrintTheList(headPointor);


            //headPointor = ll.DeleteUsingPosition(headPointor,2);
            //headPointor = ll.DeleteUsingPosition(headPointor,4);

            //ll.PrintTheList(headPointor);



            //DoublyLinkedList dll = new DoublyLinkedList();

            //DllNode headPointor = new DllNode();
            //headPointor = dll.InsertToTheFront(headPointor,2);
            //headPointor = dll.InsertToTheFront(headPointor,4);
            //headPointor = dll.InsertToTheFront(headPointor,8);


            //dll.PrintTheListFront(headPointor);


            //DllNode backHeadPointor = new DllNode();
            //backHeadPointor = dll.InsertToTheBack(backHeadPointor,5);
            //backHeadPointor = dll.InsertToTheBack(backHeadPointor,7);
            //backHeadPointor = dll.InsertToTheBack(backHeadPointor,8);

            //dll.PrintTheListBack(backHeadPointor);

            //ProductOfMaximumSubArray pomsa = new ProductOfMaximumSubArray();

            //int[] arr = {1, -2, -3, 0, 7, -8, -2};
            //int n = arr.Length;
            //int result = pomsa.maxSubarrayProduct(arr, n);

            //Console.WriteLine("{0}", result);




            //int result = 0;   // Result initialized to say there is no error
            //AllSortingTechnique.ProducerConsumerProblem.Cell cell = new AllSortingTechnique.ProducerConsumerProblem.Cell();

            //AllSortingTechnique.ProducerConsumerProblem.CellProd prod = new AllSortingTechnique.ProducerConsumerProblem.CellProd(cell, 20);  // Use cell for storage, 
            //// produce 20 items
            //AllSortingTechnique.ProducerConsumerProblem.CellCons cons = new AllSortingTechnique.ProducerConsumerProblem.CellCons(cell, 20);  // Use cell for storage, 
            //// consume 20 items

            //Thread producer = new Thread(new ThreadStart(prod.ThreadRun));
            //Thread consumer = new Thread(new ThreadStart(cons.ThreadRun));
            //// Threads producer and consumer have been created, 
            //// but not started at this point.

            //try
            //{
            //    producer.Start();
            //    consumer.Start();

            //    producer.Join();   // Join both threads with no timeout
            //    // Run both until done.
            //    consumer.Join();
            //    // threads producer and consumer have finished at this point.
            //}
            //catch (ThreadStateException e)
            //{
            //    Console.WriteLine(e);  // Display text of exception
            //    result = 1;            // Result says there was an error
            //}
            //catch (ThreadInterruptedException e)
            //{
            //    Console.WriteLine(e);  // This exception means that the thread
            //    // was interrupted during a Wait
            //    result = 1;            // Result says there was an error
            //}
            //// Even though Main returns void, this provides a return code to 
            //// the parent process.
            //Environment.ExitCode = result;


            int n = 5;
            //int[,] array = new int[5, 5]{{ 1, 0, 1, 1, 0 },
            //    { 0, 1, 1, 1, 0 },
            //    { 1, 1, 1, 1, 1 },
            //    { 1, 0, 1, 1, 1 },
            //    { 1, 1, 1, 1, 1 }
            //};

            bool[,] array2D = new bool[5, 5] {{ true, false, true, true, false },
                                            { false, true, true, true, false },
                                            { true, true, true, true, true },
                                            { true, false, true, true, true },
                                            { true, true, true, true, true } };

            Exchanging1And0 exOneAndZero = new Exchanging1And0();
            exOneAndZero.ProcessArrayStackOverFlow(array2D, 5);


            Console.ReadLine();
        }
    }
}
