using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.ISP
{
    public class StoreOrder : IOrder
            {
        public void PlaceOrder()
        {
            // Implementation here
          
        }

        public void CancelOrder()
        {
            // Implementation here
            throw new NotImplementedException();
        
        }

        public void UpdateOrder()
        {
            // Implementation here

        }

        public void CalculateTotal()
        {
            // Implementation here
        }

        public void GenerateInvoice()
        {
            // Implementation here
        }

        public void SendEmail()
        {
            // Implementation here
        }

        public void PrintLabel()
        {
            // Implementation here
        }
    }
}
