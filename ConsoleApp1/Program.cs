using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Buy(iceCream);
            Buy(frozenYogurt);
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
