// Use the decimal type to compute a discount.
using System;
class UseDecimal
{
    static void Main()
    {
        double price;
        double discount;
        double discounted_price;
        // Compute discounted price.
        price = 19.95;
        discount = 0.15; // discount rate is 15%
        discounted_price = price - (price * discount);
        Console.WriteLine("Discounted price: $" + discounted_price);


        return;
    }
}