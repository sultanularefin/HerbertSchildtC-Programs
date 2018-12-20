using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

   
    //En-queue means push an item  and De-queue means pop an item
   // class Queue
    class Queue<T>

    {
        private const int DEFAULTQUEUESIZE = 100; //// array is of type 'T' where 'T' is the type parameter
        //private int[] data;

        //private object[] data;    // object is a base class everything inherites object class thus it is used 
                                // to access the upper level classes , but not a good idea , use generics
                                // which is better to handle any type of data;

        private T[] data;       // use 'T' as the data type
            
        private int head = 0, tail = 0;
        private int numElements = 0;
        public Queue()  // constructor
        {
            this.data = new T [DEFAULTQUEUESIZE];
        }

        public Queue(int size)
        {
            if (size > 0)
            {
                this.data = new T [size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            }
        }

        public void Enqueue(T item)
        {
            if (this.numElements == this.data.Length)
            {
                throw new Exception("Queue full");
            }
            this.data[this.head] = item;
            this.head++;
            this.head = this.head % this.data.Length;     // circular queue
            this.numElements++;
        }
        public T Dequeue()
        {
            if (this.numElements == 0)
            {
                throw new Exception("Queue empty");
            }
            T queueItem = this.data[this.tail];
            this.tail++;
            this.tail =this.tail % this.data.Length; // circular queue
            this.numElements--;
            return queueItem;
        }

       
    }
    
     
}

