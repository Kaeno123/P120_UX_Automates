using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P120_UX_Automates
{
    public class Tickets
    {
        string _ticketName;
        double _price;
        DateTime _date;
        string _properDate;
        int _number;

        public string ticketName { get { return _ticketName; } set { _ticketName = value; } }
        public double price { get { return _price; } set { _price = value; } }
        public DateTime date { get { return _date; } set { _date = value; } }
        public string ProperDate { get { return _properDate; } set { _properDate = value; } }
        public int Number { get { return _number; }  set { _number = value; } }

        public Tickets(string TicketName, double Price, DateTime Date)
        {
            this.ticketName = TicketName;
            this.price = Price;
            this.date = Date;
            _properDate = _date.ToString().Split(' ')[0];
        }
    }
}
