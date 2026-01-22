using System;
using System.Collections.Generic;
using System.Linq;

namespace SweetSpotDessertShop412
{
    // Class to represent a basket item
    public class BasketItem
    {
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }

        public BasketItem(string itemName, decimal unitPrice, int quantity, string category)
        {
            ItemName = itemName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Category = category;
        }
    }

    // Static class to manage basket state across all forms
    public static class BasketManager
    {
        private static List<BasketItem> basketItems = new List<BasketItem>();

        public static int ItemCount
        {
            get { return basketItems.Sum(item => item.Quantity); }
        }

        // Add item with details
        public static void AddItem(string itemName, decimal unitPrice, int quantity, string category)
        {
            // Check if item already exists in basket
            var existingItem = basketItems.FirstOrDefault(item =>
                item.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase));

            if (existingItem != null)
            {
                // Item exists, increase quantity
                existingItem.Quantity += quantity;
            }
            else
            {
                // New item, add to basket
                basketItems.Add(new BasketItem(itemName, unitPrice, quantity, category));
            }
        }

        // Legacy method for backward compatibility (increments count by 1)
        public static void AddItem()
        {
            // This is kept for backward compatibility but should not be used
            // Items should be added with full details using AddItem(name, price, quantity, category)
        }

        public static void RemoveItem(string itemName)
        {
            var item = basketItems.FirstOrDefault(i =>
                i.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase));

            if (item != null)
            {
                item.Quantity--;
                if (item.Quantity <= 0)
                {
                    basketItems.Remove(item);
                }
            }
        }

        // Legacy remove method
        public static void RemoveItem()
        {
            if (basketItems.Any())
            {
                var lastItem = basketItems.Last();
                lastItem.Quantity--;
                if (lastItem.Quantity <= 0)
                {
                    basketItems.Remove(lastItem);
                }
            }
        }

        public static void ClearBasket()
        {
            basketItems.Clear();
        }

        public static List<BasketItem> GetBasketItems()
        {
            return new List<BasketItem>(basketItems);
        }

        public static string GetBasketText()
        {
            int count = ItemCount;
            if (count == 0)
                return "🛒 Basket: 0 items";
            else if (count == 1)
                return "🛒 Basket: 1 item";
            else
                return $"🛒 Basket: {count} items";
        }

        // Get total price of all items
        public static decimal GetSubtotal()
        {
            return basketItems.Sum(item => item.UnitPrice * item.Quantity);
        }
    }
}