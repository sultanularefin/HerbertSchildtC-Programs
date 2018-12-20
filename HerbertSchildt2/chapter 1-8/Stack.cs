// A stack class for characters.
using System;
class Stack
{
    // These members are private.
    char[] stck; // holds the stack
    int tos; // index of the top of the stack
    // Construct an empty Stack given its size.
    public Stack(int size)
    {
        stck = new char[size]; // allocate memory for stack
        tos = 0;
    }
    // Push characters onto the stack.
    public void Push(char ch)
    {
        if (tos == stck.Length)
        {
            Console.WriteLine(" -- Stack is full.");
            return;
        }
        stck[tos] = ch;
        tos++;
    }
    // Pop a character from the stack.

    public char Pop()
    {
        if (tos == 0)
        {
            Console.WriteLine(" -- Stack is empty.");
            return (char)0;
        }
        tos--;
        return stck[tos];
    }
    // Return true if the stack is full.
    public bool IsFull()
    {
        return tos == stck.Length;
    }
    // Return true if the stack is empty.
    public bool IsEmpty()
    {
        return tos == 0;
    }
    // Return total capacity of the stack.
    public int Capacity()
    {
        return stck.Length;
    }
    // Return number of objects currently on the stack.
    public int GetNum()
    {
        return tos;
    }

    
}