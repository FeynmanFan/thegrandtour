using System;

namespace BehrensTech.DessertStore.Data
{
    public class Product
    {
        /// <summary>
        /// The short name of the product
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A brief description to sell the product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The file used to display the product visually
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// The price of the product in US dollars
        /// </summary>
        public decimal Price { get; set; }
    }
}
