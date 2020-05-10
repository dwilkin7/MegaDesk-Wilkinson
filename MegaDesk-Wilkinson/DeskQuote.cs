using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Wilkinson
{
    public class DeskQuote
    {
        public DateTime QuoteDate { get; set; }

        public string CustomerName { get; set; }

        public int RushDays { get; set; }

        public Desk Desk { get; set; }

        public decimal GetQuote()
        {
            //TODO
            return 0;
        }
    }
}
