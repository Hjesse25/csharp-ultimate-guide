using ClassLibrary1;

class Program
{
    static void Main()
    {
        //local constant
        const string developerName = "Jesse";

        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //1
        product2 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //2
        product3 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //3

        //initalize fields
        product1.SetProductID(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(20000);
        product1.SetQuantityInStock(1200);

        product2.SetProductID(1003);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);

        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);
        
        //call methods
        //named arguments percentage: 9.2
        product1.CalculateTax(percentage: 9.2);
        double p = 7.4;
        product2.CalculateTax(p);
        Console.WriteLine("p is " + p);
        product3.CalculateTax(10000, 3.4);

        //get values from fields
        Console.WriteLine(developerName);

        Console.WriteLine("Product 1:");
        Console.WriteLine("Product ID: " + product1.GetProductID());
        Console.WriteLine("Product Name: " + product1.GetProductName());
        Console.WriteLine("Cost: " + product1.GetCost());
        Console.WriteLine("Quantity in Stock: " + product1.GetQuantityInStock());
        Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
        Console.WriteLine("Tax: " + product1.GetTax());

        Console.WriteLine("\nProduct 2:");
        Console.WriteLine("Product ID: " + product2.GetProductID());
        Console.WriteLine("Product Name: " + product2.GetProductName());
        Console.WriteLine("Cost: " + product2.GetCost());
        Console.WriteLine("Quantity in Stock: " + product2.GetQuantityInStock());
        Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
        Console.WriteLine("Tax: " + product2.GetTax());

        Console.WriteLine("\nProduct 3:");
        Console.WriteLine("Product ID: " + product3.GetProductID());
        Console.WriteLine("Product Name: " + product3.GetProductName());
        Console.WriteLine("Cost: " + product3.GetCost());
        Console.WriteLine("Quantity in Stock: " + product3.GetQuantityInStock());
        Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
        Console.WriteLine("Tax: " + product3.GetTax());

        //total quantity
        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);

        //display totals
        Console.WriteLine("Total Quantity: " + totalQuantity);
        Console.WriteLine("Total no. of products: " + Product.GetTotalNoOfProducts()); //Output: 3
        Console.WriteLine("Category of Products: " + Product.CategoryName);
    }
}