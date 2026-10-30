public interface IShoppingOrder
{
    void CalculateTotal();
    void PayMnent();
    void SendEmail();
    void PrintInvoice();
    void PrintShippingLabel();
}
