// Demonstrate why the :: qualifier is needed.
//
// This program will not compile.
using System;
// Use both the Counter and AnotherCounter namespace.
using Counter;
using AnotherCounter;
// Declare a namespace for counters.
namespace Counter
{
    // A simple countdown counter.
    class CountDown
    {
        int val;
        public CountDown(int n)
        {
            val = n;
        }
        // ...
    }
}
// Declare another namespace for counters.
namespace AnotherCounter
{
    // Declare another class called CountDown, which
    // is in the AnotherCounter namespace.
    class CountDown
    {
        int val;
        public CountDown(int n)
        {
            val = n;
        }
        // ...
    }
}
class WhyAliasQualifier
{
    static void Main()
    {
        int i;

        // The following line is inherently ambiguous!
        // Does it refer to CountDown in Counter or
        // to CountDown in AnotherCounter?
        CountDown cd1 = new CountDown(10); // Error! ! !
        // ...
    }
}