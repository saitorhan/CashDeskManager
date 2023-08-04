
using CashDeskManager.V2.Entity.Database;

namespace CashDeskManager.V2
{
    public static class GlobalVariables
    {
        public static CashDesk CurrentCashDesk { get; set; }
        public static int Version => 1;
    }
}