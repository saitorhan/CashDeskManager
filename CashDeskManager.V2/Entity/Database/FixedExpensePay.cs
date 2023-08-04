using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using CashDeskManager.V2.Entity.Enums;

namespace CashDeskManager.V2.Entity.Database
{
    public class FixedExpensePay : CashDeskAction
    {
        public int FixedExpensePayCeshDeskId { get; set; }
        public int FixedExpenseId { get; set; }

        
        [NotMapped]
        [DisplayName("Ödeme Yapan Kasa")]
        public CashDesk CashDeskPayFrom { get; set; }
    }
}