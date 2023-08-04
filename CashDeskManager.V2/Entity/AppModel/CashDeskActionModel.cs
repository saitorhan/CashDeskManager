using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;

namespace CashDeskManager.V2.Entity.AppModel
{
    public class CashDeskActionModel
    {

        public int Id { get; set; }
        public int CashDeskId { get; set; }
        [DisplayName("Kasa Adı")]
        public string cashdesk { get; set; }
        [DisplayName("Çek Hesap No")]
        public string AccountNumber { get; set; }
        [DisplayName("Çek No")]
        public string CheckNumber { get; set; }
        [DisplayName("Çek Sahibi")]
        public string CheckOwner { get; set; }
        [DisplayName("Sabit Gider")]
        public string fixedExpense { get; set; }

        [DisplayName("P. Birimi")]
        public CurrencyUnit CurrencyUnit { get; set; }

        [DisplayName("Tutar")]
        public double Amount { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Tarih")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DateTime { get; set; }
        [DisplayName("Silme Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime? DeleteTime { get; set; }
        [DisplayName("Çek İmza Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime? SignDateTime { get; set; }
        [DisplayName("Çek Vade Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime? ExpirtyDateTime { get; set; }
        public ActionDirection ActionDirection { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatu PaymentStatu { get; set; }
        public int? FixedExpenseId { get; set; }

        [DisplayName("Sabit Gider Açıklaması")]
        public string FixedExpenseDesc { get; set; }
        public int? PayedFromCashDeskId { get; set; }

        [DisplayName("Ödemeyi Yapan Kasa")]
        public string PayedFromCashDeskName { get; set; }

        [DisplayName("Ödemeyi Alan Kasa")]
        public string PayedToCashDeskName { get; set; }
        public int? CustumerId { get; set; }

        [DisplayName("Ödemeyi Yapan Müşteri")]
        public string CustumerName { get; set; }

        public bool? Deleted { get; set; }

        [DisplayName("Banka Adı")]
        public string BankName { get; set; }
        [DisplayName("Banka Şubesi")]
        public string BankBranch { get; set; }

        [NotMapped]
        [DisplayName("İşlem Türü")]
        public string ActionDirectionString => ActionDirection.ToStringF();

        [NotMapped]
        [DisplayName("Ödeme Şekli")]
        public string PaymentMethodString => PaymentMethod.ToStringF();

        [NotMapped]
        [DisplayName("Ödeme Durumu")]
        public string PaymentStatuString => PaymentStatu.ToStringF();

        public int? DebtId { get; set; }
        [NotMapped] public DebtAndCredit DebtAndCredit { get; set; }

        [NotMapped]
        [DisplayName("Ödeme Notu")]
        public string Note => PayedFromCashDeskName.IsNotNullOrEmpty() && PayedFromCashDeskName != cashdesk ? "Farklı kasadan borç ile yapılan ödeme" : null;

        public int? FixedExpensePayCeshDeskId { get; set; }
        public int? DebtPayCashDeskId { get; set; }
        public int? MoneyOutCashDeskId { get; set; }
    }
}