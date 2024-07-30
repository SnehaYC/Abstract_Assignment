namespace Assignment_15
{
    using System;
    using System.Collections.Generic;

    class Product
    {
        public string Code { get; private set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }

        public Product(string code, string name, int quantityInStock, double price, double discountPercentage)
        {
            Code = code;
            Name = name;
            QuantityInStock = quantityInStock;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        public double CalculateDiscountedPrice(int quantity)
        {
            double totalPrice = Price * quantity;
            double discountAmount = totalPrice * (DiscountPercentage / 100);
            return totalPrice - discountAmount;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Code: {Code}, Name: {Name}, Stock: {QuantityInStock}, Price: {Price:C}, Discount: {DiscountPercentage}%");
        }
    }

    class Store
    {
        private List<Product> productList = new List<Product>();

        public void AddProduct(Product product)
        {
            bool exists = false;
            foreach (var p in productList)
            {
                if (p.Code == product.Code)
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                Console.WriteLine("Product with this code already exists.");
            }
            else
            {
                productList.Add(product);
                Console.WriteLine("Product added successfully.");
            }
        }

        public void DisplayAllProducts()
        {
            Console.WriteLine("\nProduct List:");
            foreach (var product in productList)
            {
                product.DisplayDetails();
            }
        }

        public Product GetProductByCode(string code)
        {
            foreach (var product in productList)
            {
                if (product.Code == code)
                {
                    return product;
                }
            }
            return null;
        }
    }

    class Admin
    {
        private Store store;

        public Admin(Store store)
        {
            this.store = store;
        }

        public void AddProduct()
        {
            Console.Write("Enter Product Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Quantity In Stock: ");
            int quantityInStock = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Discount Percentage: ");
            double discountPercentage = double.Parse(Console.ReadLine());

            Product product = new Product(code, name, quantityInStock, price, discountPercentage);
            store.AddProduct(product);
        }

        public void DisplayProducts()
        {
            store.DisplayAllProducts();
        }
    }

    class Customer
    {
        private Store store;

        public Customer(Store store)
        {
            this.store = store;
        }

        public void PurchaseProduct()
        {
            Console.Write("Enter Product Code to purchase: ");
            string code = Console.ReadLine();
            Product product = store.GetProductByCode(code);

            if (product != null)
            {
                Console.Write("Enter Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                if (quantity <= product.QuantityInStock)
                {
                    product.QuantityInStock -= quantity;
                    double amountToPay = product.CalculateDiscountedPrice(quantity);

                    Console.WriteLine("Product Details:");
                    product.DisplayDetails();
                    Console.WriteLine($"Total Amount to Pay after Discount: {amountToPay:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient stock available.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }

    class Program
    {
        static Store store = new Store();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Who are you?\n1. Admin\n2. Customer\n3. Exit");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Admin admin = new Admin(store);
                    AdminMenu(admin);
                }
                else if (choice == 2)
                {
                    Customer customer = new Customer(store);
                    CustomerMenu(customer);
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        static void AdminMenu(Admin admin)
        {
            while (true)
            {
                Console.WriteLine("\nAdmin Menu:\n1. Add Product\n2. Display Products\n3. Back");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    admin.AddProduct();
                }
                else if (choice == 2)
                {
                    admin.DisplayProducts();
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        static void CustomerMenu(Customer customer)
        {
            while (true)
            {
                Console.WriteLine("\nCustomer Menu:\n1. Purchase Product\n2. Back");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    customer.PurchaseProduct();
                }
                else if (choice == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }

}
