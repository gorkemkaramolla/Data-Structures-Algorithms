/* Exemplary file for Chapter 5 - Variants of Trees. */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace Trees
{
    class Program
    {
        const int numberOfItems = 35000;
        private const int COLUMN_WIDTH = 5;

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Timing tObj = new();

            BinarySearchTree<int> BST = new BinarySearchTree<int>();
            AVL<int> AVLTree = new AVL<int>();

            tObj.startTime();
            for (int i = 0; i < numberOfItems; i++)
                BST.Add(i);
            tObj.StopTime();
            Console.WriteLine("For {0} number of times operations \n\n", numberOfItems);
            Console.WriteLine("Time for BST add operation:" + tObj.Result());


            tObj.startTime();
            for (int i = 0; i < numberOfItems; i++)
                BST.Contains(i);
            tObj.StopTime();
            Console.WriteLine("Time for BST contains operation:" + tObj.Result());

            tObj.startTime();
            for (int i = 0; i < numberOfItems; i++)
                AVLTree.Add(i);
            tObj.StopTime();

            Console.WriteLine("Time for AVL add operation:" + tObj.Result());
            tObj.startTime();
            for (int i = 0; i < numberOfItems; i++)
            {
                AVLTree.Contains(i);
            }

            tObj.StopTime();
            Console.WriteLine("Time for AVL contains operation:" + tObj.Result());



        }


        public class Timing
        {
            TimeSpan startingTime;
            TimeSpan duration;
            public Timing()
            {
                startingTime = new TimeSpan(0);
                duration = new TimeSpan(0);
            }
            public void StopTime()
            {
                duration =
                Process.GetCurrentProcess().Threads[0].
                UserProcessorTime.Subtract(startingTime);

            }

            public void startTime()
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                startingTime =
                Process.GetCurrentProcess().Threads[0].
                UserProcessorTime;
            }

            public TimeSpan Result()
            {
                return duration;
            }
        }
    }
}
