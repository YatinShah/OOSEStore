namespace OOSEStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orchestrator = new PurchaseOrchestrationFacade("Yatin Shah", "Christmas Purchases");
            orchestrator.BuyItems();
            orchestrator.GetStoreManagerGift();
            orchestrator.RentItems();
            orchestrator.AddCartCoupons();

            orchestrator.GenerateXmlReceipt();
        }
    }
}
