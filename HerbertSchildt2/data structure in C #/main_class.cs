using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class main_class
    {
        public static void Main()


        {
            Queue<int> intQueue = new Queue<int>();
            //Queue<Horse> horseQueue = new Queue<Horse>();
            
            //Queue queue = new Queue(); // Create a new Queue
            intQueue.Enqueue(100);
            intQueue.Enqueue(-25);
            intQueue.Enqueue(33);

            Console.WriteLine("{0}", intQueue.Dequeue()); // Displays 100
            Console.WriteLine("{0}", intQueue.Dequeue()); // Displays -25
            Console.WriteLine("{0}", intQueue.Dequeue()); // Displays 33

            int[] pins = new int[] {11,22,33,44,55};
            Queue<Queue<int>> queueQueue = new Queue<Queue<int>>()  ;
          
            
            //        initialization or constructors
            //            public Queue() {}
            //            public Queue(int capacity) {}
            //            public Queue(ICollection col) {}
            //            public Queue(int capacity, float growFactor) {}

            queueQueue.Enqueue(11).Enqueue(12);
            
            queueQueue.Enqueue(222).Enqueue(11);
        }

    }
}
