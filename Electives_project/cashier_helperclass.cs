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

        public static string CalculateChange(string cashText, string totalText)
        {
            // 1. Attempt to parse both inputs
            bool isCashValid = decimal.TryParse(cashText, out decimal cash);
            bool isTotalValid = decimal.TryParse(totalText, out decimal total);

            // 2. Perform calculation only if both are valid
            if (isCashValid && isTotalValid)
            {
                decimal change = cash - total;

                // Return formatted as a number with 2 decimal places
                // If change is negative, you can handle it here (e.g., return "0.00")
                return change >= 0 ? change.ToString("N2") : "0.00";
            }

            return "0.00";
        }
    }
}
