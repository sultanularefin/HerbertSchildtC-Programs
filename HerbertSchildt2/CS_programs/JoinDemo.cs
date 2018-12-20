﻿// Demonstrate join.
using System;
using System.Linq;
// A class that links an item name with its number.
class Item
{
    public string Name { get; set; }
    public int ItemNumber { get; set; }
    public Item(string n, int inum)
    {
        Name = n;
        ItemNumber = inum;
    }
}
// A class that links an item number with its in-stock status.
class InStockStatus
{
    public int ItemNumber { get; set; }
    public bool InStock { get; set; }
    public InStockStatus(int n, bool b)
    {
        ItemNumber = n;
        InStock = b;
    }
}
// A class that encapsulates a name with its status.
class Temp
{
    public string Name { get; set; }
    public bool InStock { get; set; }
    public Temp(string n, bool b)
    {
        Name = n;
        InStock = b;
    }
}
class JoinDemo
{
    static void Main()
    {
        Item[] items = {
new Item("Pliers", 1424),
new Item("Hammer", 7892),
new Item("Wrench", 8534),
new Item("Saw", 6411)
};

        InStockStatus[] statusList = {
new InStockStatus(1424, true),
new InStockStatus(7892, false),
new InStockStatus(8534, true),
new InStockStatus(6411, true)
};
        // Create a query that joins Item with InStockStatus to
        // produce a list of item names and availability. Notice
        // that a sequence of Temp objects is produced.
        var inStockList = from item in items
                          join entry in statusList
                          on item.ItemNumber equals entry.ItemNumber
                          select new Temp(item.Name, entry.InStock);
        Console.WriteLine("Item\tAvailable\n");
        // Execute the query and display the results.
        foreach (Temp t in inStockList)
            Console.WriteLine("{0}\t{1}", t.Name, t.InStock);
    }
}