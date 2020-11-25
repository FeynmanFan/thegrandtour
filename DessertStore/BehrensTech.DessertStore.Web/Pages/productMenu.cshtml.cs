using System.Collections.Generic;
using BehrensTech.DessertStore.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BehrensTech.DessertStore.Web.Pages
{
    public class productMenuModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            this.Products = new List<Product>();

            this.Products.Add(new Product
            {
                Title = "Ice Cream",
                Description = "Handmade with milk from happy cows",
                ImageName = "ice cream.jpg",
                Price = 5.99m
            });

            this.Products.Add(new Product
            {
                Title = "Frozen Yogurt",
                Description = "Handmade with bacteria from happy lactobacillae",
                ImageName = "frozen yogurt.jpg",
                Price = 6.99m
            });


            this.Products.Add(new Product
            {
                Title = "Ice Cream",
                Description = "Handmade with milk from happy cows",
                ImageName = "ice cream.jpg",
                Price = 5.99m
            });

            this.Products.Add(new Product
            {
                Title = "Frozen Yogurt",
                Description = "Handmade with bacteria from happy lactobacillae",
                ImageName = "frozen yogurt.jpg",
                Price = 6.99m
            });


            this.Products.Add(new Product
            {
                Title = "Ice Cream",
                Description = "Handmade with milk from happy cows",
                ImageName = "ice cream.jpg",
                Price = 5.99m
            });

            this.Products.Add(new Product
            {
                Title = "Frozen Yogurt",
                Description = "Handmade with bacteria from happy lactobacillae",
                ImageName = "frozen yogurt.jpg",
                Price = 6.99m
            });


            this.Products.Add(new Product
            {
                Title = "Ice Cream",
                Description = "Handmade with milk from happy cows",
                ImageName = "ice cream.jpg",
                Price = 5.99m
            });

            this.Products.Add(new Product
            {
                Title = "Frozen Yogurt",
                Description = "Handmade with bacteria from happy lactobacillae",
                ImageName = "frozen yogurt.jpg",
                Price = 6.99m
            });

        }
    }
}
