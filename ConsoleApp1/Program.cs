using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Allow the user to construct the list of products
             * DisplayMenu
             * GetUserSelection
             *  Loop until user selects "Checkout"
             * Loop through list of selected products
             * Print total*/

            Product iceCream = new Product
            {
                Name = "Ice Cream",
                Price = 5.99m,
                SpaceInBasket = 1
            };

            Product frozenYogurt = new Product
            {
                Name = "Frozen Yogurt",
                Price = 6.99m,
                SpaceInBasket = 2
            };

            List<Product> productList = new List<Product>();

            string userSelection;

            do
            {
                DisplayMenu();

                userSelection = Console.ReadLine();

                if (userSelection == "IC")
                {
                    // add ice cream to the list
                    productList.Add(iceCream);
                }

                if (userSelection == "FY")
                {
                    // add frozen yogurt to the list
                    productList.Add(frozenYogurt);
                }
            } while (userSelection != "CO");

            Checkout(productList);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Ice Cream: Enter IC");
            Console.WriteLine("Frozen Yogurt: Enter FY");
            Console.WriteLine("Enter CO to check out when you're done.");
            Console.Write("Enter selection:");
        }

        private static void Checkout(List<Product> productList)
        {
            foreach(var product in productList)
            {
                Buy(product);
            }

            var totalPrice = 0m;

            for(var i = 0; i < productList.Count; i++)
            {
                totalPrice += productList[i].TotalPrice;
            }

            Console.WriteLine($"Total price: {totalPrice.ToString("C")}");
        }

        static void Buy(Product product)
        {
            GetFromShelf(product);
            PlaceInBasket(product);
            PlaceWithChecker(product);
            PayForProduct(product);
        }

        private static void GetFromShelf(Product product)
        {
            Console.WriteLine("Get " + product.Name + " from shelf.");
        }

        private static void PlaceInBasket(Product product)
        {
            Console.WriteLine("Place " + product.Name + " in basket, size: " + product.SpaceInBasket);
        }

        private static void PlaceWithChecker(Product product)
        {
            Console.WriteLine($"Place {product.Name} with checker");
        }

        private static void PayForProduct(Product product)
        {
            Console.WriteLine($"Pay for {product.Name}: {product.Price}\n" +
                product.SalesTax + "\n" + product.TotalPrice);
        }
    }
}
