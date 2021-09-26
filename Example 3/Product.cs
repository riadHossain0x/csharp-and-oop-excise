namespace Example_3
{
    public class Product : IPurchasable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
    }
    public class GiftCard : IPurchasable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageFile { get; set; }
        public string RecieverEmail { get; set; }
    }
}
