using lab16._10.ISP_Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.ISP_Example
{
    public class OnlineOrder : IShoppingOrder, IOrderPayment, IInvoiceGenerator, IEmailSender, ILabelPrinter
    {
        public void CalculateTotal()
        {
            Console.WriteLine("100 USD");
        }

        public void CancelOrder()
        {
            throw new NotImplementedException();
        }

        public void GenerateInvoice()
        {
            throw new NotImplementedException();
        }

        public void PayMnent()
        {
            Console.WriteLine("Transaction completed.");
        }

        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public void PrintLabel()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
