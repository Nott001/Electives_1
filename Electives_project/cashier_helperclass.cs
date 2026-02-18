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

        public void AddToTransaction(string name, decimal price)
        {
            ItemNames.Add(name);
            ItemPrices.Add(price);
        }

        public void RemoveLastItem()
        {
            if (ItemNames.Count > 0)
            {
                ItemNames.RemoveAt(ItemNames.Count - 1);
                ItemPrices.RemoveAt(ItemPrices.Count - 1);
            }
        }

        public void ClearTransaction()
        {
            ItemNames.Clear();
            ItemPrices.Clear();
        }

        // Calculation logic
        public (decimal subtotal, decimal discount, decimal total) GetCalculations(bool isDiscounted)
        {
            decimal subtotal = ItemPrices.Sum();
            decimal discount = isDiscounted ? subtotal * 0.20m : 0;
            decimal total = subtotal - discount;

            return (subtotal, discount, total);
        }
    }
}
