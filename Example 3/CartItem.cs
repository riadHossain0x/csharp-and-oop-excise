using System;

namespace Example_3
{
    public class CartItem
    {
        public IPurchasable Item { get; private set; }
        public uint Quantity { get; private set; }

        public CartItem(IPurchasable item)
        {
            this.Item = item;
            this.Quantity = 1;
        }

        public void UpdateQuantity(uint quantity)
        {
            if (quantity == 0)
                throw new ArgumentNullException("Quantity can not be null.");

            this.Quantity = quantity;
        }
    }
}
