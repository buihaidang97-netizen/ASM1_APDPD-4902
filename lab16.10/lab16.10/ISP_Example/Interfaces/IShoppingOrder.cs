using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.ISP_Example.Interfaces
{
    public interface IShoppingOrder
    {
        void PlaceOrder();
        void CancelOrder();
        void UpdateOrder();
        void CalculateTotal();
        void GenerateInvoice();
        void SendEmail();
        void PrintLabel();
    }
}
