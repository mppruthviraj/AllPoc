using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AllSortingTechnique
{
    public class ProducerConsumerProblem
    {

        public class CellProd
        {
            Cell cell;         // Field to hold cell object to be used
            int quantity = 1;  // Field for how many items to produce in cell

            public CellProd(Cell box, int request)
            {
                cell = box;          // Pass in what cell object to be used
                quantity = request;  // Pass in how many items to produce in cell
            }
            public void ThreadRun()
            {
                for (int looper = 1; looper <= quantity; looper++)
                    cell.WriteToCell(looper);  // "producing"
            }
        }

        public class CellCons
        {
            Cell cell;         // Field to hold cell object to be used
            int quantity = 1;  // Field for how many items to consume from cell

            public CellCons(Cell box, int request)
            {
                cell = box;          // Pass in what cell object to be used
                quantity = request;  // Pass in how many items to consume from cell
            }
            public void ThreadRun()
            {
                int valReturned;
                for (int looper = 1; looper <= quantity; looper++)
                    // Consume the result by placing it in valReturned.
                    valReturned = cell.ReadFromCell();
            }
        }

        public class Cell
        {
            int cellContents;         // Cell contents
            bool readerFlag = false;  // State flag
            public int ReadFromCell()
            {
                lock (this)   // Enter synchronization block
                {
                    if (!readerFlag)
                    {            // Wait until Cell.WriteToCell is done producing
                        try
                        {
                            // Waits for the Monitor.Pulse in WriteToCell
                            Monitor.Wait(this);
                        }
                        catch (SynchronizationLockException e)
                        {
                            Console.WriteLine(e);
                        }
                        catch (ThreadInterruptedException e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    Console.WriteLine("Consume: {0}", cellContents);
                    readerFlag = false;    // Reset the state flag to say consuming
                    // is done.
                    Monitor.Pulse(this);   // Pulse tells Cell.WriteToCell that
                    // Cell.ReadFromCell is done.
                }   // Exit synchronization block
                return cellContents;
            }

            public void WriteToCell(int n)
            {
                lock (this)  // Enter synchronization block
                {
                    if (readerFlag)
                    {      // Wait until Cell.ReadFromCell is done consuming.
                        try
                        {
                            Monitor.Wait(this);   // Wait for the Monitor.Pulse in
                            // ReadFromCell
                        }
                        catch (SynchronizationLockException e)
                        {
                            Console.WriteLine(e);
                        }
                        catch (ThreadInterruptedException e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    cellContents = n;
                    Console.WriteLine("Produce: {0}", cellContents);
                    readerFlag = true;    // Reset the state flag to say producing
                    // is done
                    Monitor.Pulse(this);  // Pulse tells Cell.ReadFromCell that 
                    // Cell.WriteToCell is done.
                }   // Exit synchronization block
            }
        }
    }
}
