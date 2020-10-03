using System;
using Products;

class MainClientApp
{
    public static void Main()
    {
        Product myProduct = new Product();
        Console.WriteLine("Client code executes");
        myProduct.ShowProduct();
    }
}