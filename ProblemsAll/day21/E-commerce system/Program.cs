
namespace E_commerce_system
{
    internal class Program
    {
        //Create a product
        static void Main(string[] args)
        { // Create some products
            Product Product1 = new Product("Laptop", 1200.00m, "Electronics");
            Product Product2 = new Product("Keyboard", 4000, "Accessories");
            Product Product3 = new Product("Mouse", 2000, "Accessories");

            //New user
            User user = new User("Rukku", "password123", "rukku@yahoo.com");

            // Create an order and add products to it
            Order order = new Order();
            order.AddProduct(Product1);
            order.AddProduct(Product2);
            order.AddProduct(Product3);
            order.DisplayOrder();
            //Discount details

            DiscountOrder discountedOrder = new DiscountOrder();
            //discountedOrder.discount = 2;
           Console.WriteLine("Discounted total : " + discountedOrder.CalculateTotal());
            discountedOrder.CalculateTotal();
            //Create a customer and admin

            Customer customer = new Customer("Annmerry", "annmarry@example.com", "432 Manila SA");
            Admin admin = new Admin("Priya", "priya@example.com", 1);

            //User details
            user.DisplayUser();
            user.UpdateUser("Visal", "Vishal@123", "Vishal123@yahoo.com");

            Console.WriteLine(order.CalculateTotal());
            order.DisplayOrder();
            customer.PlaceOrder();

            Console.WriteLine(customer);
            customer.Address = "145 Seattle WA";
            Console.WriteLine(admin);


            
            order.DisplayOrder();
            //Process Order
            IOrderProcessor paymentProcessor = new PaymentProcessor();
            IOrderProcessor shippingProcessor = new ShippingProcessor();
            Console.WriteLine(order);
            //Shipping process
            paymentProcessor.ProcessOrder(order);
            paymentProcessor.CancelOrder(order);
            shippingProcessor.ProcessOrder(order);
            shippingProcessor.CancelOrder(order);
           
        }
    }
}