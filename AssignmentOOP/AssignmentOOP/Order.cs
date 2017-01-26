using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class Order
    {
        //ATTRIBUTES
        public static int orderCount = 1;
        public string OrderNo { get; set; }
        public DateTime OrderDateTime { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        private List<Ticket> ticketList = new List<Ticket>();

        //CONSTRUCTORS
        //Default
        public Order()
        {
            OrderNo = Convert.ToString(orderCount);
            orderCount++;
        }

        //METHODS
        public void AddTicket(Ticket t)
        {
            ticketList.Add(t);
        }

        public List<Ticket> GetTicketList()
        {
            return ticketList;
        }

        //TOSTRING
        public override string ToString()
        {
            return ("OrderDateTime: " + OrderDateTime + "Amount: " + Amount + "Status: " + Status);
        }
    }
}
