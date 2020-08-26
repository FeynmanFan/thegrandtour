namespace ConsoleApp1
{
    class Product
    {
        static decimal SalesTaxRate = .085m;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SpaceInBasket { get; set; }
        public decimal SalesTax
        {
            get
            {
                //Multiply this instance's price times the Sales Tax Rate and return that result
                decimal result = SalesTaxRate * this.Price;
                return result;
            }
        }
        public decimal TotalPrice
        {
            get
            {
                return this.Price + this.SalesTax;
            }
        }
    }
}
