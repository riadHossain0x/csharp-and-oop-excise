using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Example_3
{
    public class ShopingCart
    {
        private List<CartItem> _Items;

        public IReadOnlyCollection<CartItem> Items
        {
            get
            {
                return new ReadOnlyCollection<CartItem>(_Items);
            }
        }

        public CartItem this[string name]
        {
            get
            {
                return _Items.Where(x => x.Item.Name == name).FirstOrDefault();
            }
        }

        public ShopingCart()
        {
            _Items = new List<CartItem>();
        }

        public void Add(CartItem item)
        {
            _Items.Add(item);
        }

        public void Clear()
        {
            _Items.Clear();
        }

        public void Remove(CartItem item)
        {
            _Items.Remove(item);
        }

        public double TotalAmount
        {
            get
            {
                double total = 0;
                foreach (var item in _Items)
                {
                    total += item.Item.Price * item.Quantity;
                }
                return total;
            }
        }
    }
}
