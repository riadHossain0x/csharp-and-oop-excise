using System;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopingCart = new ShopingCart();
            shopingCart.Add(new CartItem(new Product { Id = 1, Name = "Laptop", Price = 500, ImageFile = "laptop.jpg" }));
            shopingCart.Add(new CartItem(new Product { Id = 2, Name = "Moblie", Price = 200, ImageFile = "mobile.jpg" }));
            shopingCart.Add(new CartItem(new GiftCard { Id = 3, Name = "Azha", Price = 400, ImageFile = "azha.jpg" }));

            shopingCart["Laptop"].UpdateQuantity(5);
            foreach (var item in shopingCart.Items)
            {
                Console.WriteLine($"{item.Item.Name} {item.Item.Price}");
            }

            Console.WriteLine($"{shopingCart.TotalAmount}");
        }
    }
}
