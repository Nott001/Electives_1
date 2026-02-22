using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electives_project
{
    internal class cashier_helperclass
    {
        // Lists to store the current transaction history
        public List<string> ItemNames = new List<string>();
        public List<decimal> ItemPrices = new List<decimal>();

        public int CurrentSaleId { get; set; } = -1;

        // Global Session Data
        public static int LoggedInCashierId { get; set; } = 1;
        public static string LoggedInCashierName { get; set; } = "Unknown";

        // Use a class or struct to hold item details for better grouping
        public class CartItem
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Subtotal => Quantity * UnitPrice;
        }

        public (decimal subtotal, decimal discount, decimal total, decimal vat)
        GetCalculations(decimal subtotal, bool isSenior, bool isPWD, bool isVoucher)
        {
            decimal discountPercent = 0;

            if (isSenior || isPWD) discountPercent += 0.20m;
            if (isVoucher) discountPercent += 0.10m;

            decimal discountAmount = subtotal * discountPercent;

            // VAT applied AFTER discount
            decimal vatAmount = (subtotal - discountAmount) * 0.12m;

            decimal total = subtotal - discountAmount + vatAmount;

            return (subtotal, discountAmount, total, vatAmount);
        }


        public List<CartItem> Cart = new List<CartItem>();

        public void AddOrUpdateProduct(int id, string name, decimal price)
        {
            var existingItem = Cart.FirstOrDefault(i => i.ProductId == id);
            if (existingItem != null)
            {
                existingItem.Quantity += 1; // Increment quantity if found
            }
            else
            {
                Cart.Add(new CartItem { ProductId = id, Name = name, UnitPrice = price, Quantity = 1 });
            }
        }
    }
}
