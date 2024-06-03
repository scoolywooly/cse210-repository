using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two orders
        Order order1 = new Order("Benjamin", "3816 SW 3rd St, Des Moines, IA 50315, USA");
        Order order2 = new Order("Li Chang", "China, Guangdong Province, Foshan, Chancheng District, 桂城 政编码: 552110");

        Product keyboard = new Product("Mechanical Keyboard", 1000, 75.99, 1);
        Product piano = new Product("Grand Piano", 1001, 225.99, 2);
        Product pizza = new Product("Supreme Pizza", 1002, 6.99, 1);
        Product car = new Product("Ford GT Mustang", 1004, 200000.99, 1);

        order1.addProduct(keyboard);
        order1.addProduct(car);

        order2.addProduct(piano);
        order2.addProduct(car);
        order2.addProduct(pizza);

        // Display two orders
        string firstOrderReciept = order1.getShippingLabel() + order1.getPackingLabel() + $" \nTotal Price After tax: ${order1.shippingTax() + order1.totalCost()}";
        string secondOrderReciept = order2.getShippingLabel() + order2.getPackingLabel() + $" \nTotal Price After tax: ${order2.shippingTax() + order2.totalCost()}";
        
        Console.WriteLine(firstOrderReciept);
        Console.WriteLine(secondOrderReciept);
        

        
        


        



        
    }
}