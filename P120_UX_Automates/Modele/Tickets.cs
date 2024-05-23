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
        string _type;
        double _price;
        DateTime _date;
        string _properDate;
        int _number;
        int _durability;

        public string TicketName { get { return _ticketName; } set { _ticketName = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public string ProperDate { get { return _properDate; } set { _properDate = value; } }
        public int Number { get { return _number; }  set { _number = value; } }

        public Tickets(string TicketName, string type, double Price, DateTime Date, int durability)
        {
            this.TicketName = TicketName;
            this.Type = type;
            this.Price = Price;
            this.Date = Date;
            _properDate = _date.ToString().Split(' ')[0];
            this._durability = durability;
        }

        public Tickets(string TicketName, string type, double Price, DateTime Date)
        {
            this.TicketName = TicketName;
            this.Type = type;
            this.Price = Price;
            this.Date = Date;
            _properDate = _date.ToString().Split(' ')[0];           
        }
    }
}
