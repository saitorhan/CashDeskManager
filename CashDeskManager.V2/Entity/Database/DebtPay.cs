namespace CashDeskManager.V2.Entity.Database
{
    public class DebtPay : CashDeskAction
    {
        public int DebtPayCashDeskId { get; set; }
        public int DebtId { get; set; }
    }
}