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
        string _date;
        string _properDate;
        int _number;
        int _validity = 0;

        public string TicketName { get { return _ticketName; } set { _ticketName = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public string Date { get { return _date; } set { _date = value; } }
        public string ProperDate { get { return _properDate; } set { _properDate = value; } }
        public int Number { get { return _number; }  set { _number = value; } }
        public int Validity { get { return _validity; } }

        public Tickets(string TicketName, string type, double Price, string Date, int validity)
        {
            this.TicketName = TicketName;
            this.Type = type;
            this.Price = Price;
            this.Date = Date;
            _properDate = _date.Split(' ')[0];
            this._validity = validity;
        }

        public Tickets(string TicketName, string type, double Price, string Date)
        {
            this.TicketName = TicketName;
            this.Type = type;
            this.Price = Price;
            this.Date = Date;
            _properDate = _date.Split(' ')[0];           
        }


    }
}
