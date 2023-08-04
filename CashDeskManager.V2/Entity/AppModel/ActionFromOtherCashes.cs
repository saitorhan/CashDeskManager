using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashDeskManager.V2.Entity.Database;
using CashDeskManager.V2.Entity.Enums;

namespace CashDeskManager.V2.Entity.AppModel
{
    class ActionFromOtherCashes
    {

        public int Id { get; set; }
        public int CashDeskId { get; set; }

        [DisplayName("Kaynak Hesap")]
        public string SourceCash { get; set; }
        [DisplayName("Para Birimi")]
        public CurrencyUnit CurrencyUnit { get; set; }
        [DisplayName("Miktar")]
        public double Amount { get; set; }
        [DisplayName("İşlem Tarihi")]
        public DateTime DateTime { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Banka")]
        public string BankName { get; set; }
        [DisplayName("Banka Şubesi")]
        public string BankBranch { get; set; }
        [DisplayName("İmza Tarihi")]
        public DateTime? SignDateTime { get; set; }
        [DisplayName("Vade Tarihi")]
        public DateTime? ExpirtyDateTime { get; set; }
        [DisplayName("Hesap Numarası")]
        public string AccountNumber { get; set; }
        [DisplayName("Çek Numarası")]
        public string CheckNumber { get; set; }
        [DisplayName("Çek Sahibi")]
        public string CheckOwner { get; set; }
        public PaymentStatu PaymentStatu { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ActionDirection ActionDirection { get; set; }
        public bool? Deleted { get; set; }
        [DisplayName("Silme Tarihi")]
        public DateTime? DeleteTime { get; set; }
        public int? CustumerId { get; set; }
        [DisplayName("Müşteri Adı")]
        public string CustumerName { get; set; }
        public string Discriminator { get; set; }
        public int? MoneyOutCashDeskId { get; set; }
        [DisplayName("Ödeme Yapan Kasa")]
        public string MoneyOutFrom { get; set; }
        public int? DebtPayCashDeskId { get; set; }
        [DisplayName("Ödeme Yapan Kasa (Borç)")]
        public string DeptPayFrom { get; set; }
        public int? DebtId { get; set; }
        [DisplayName("Borç Açıklama")]
        public string DebtName { get; set; }
        public int? FixedExpensePayCeshDeskId { get; set; }
        [DisplayName("Ödeme Yapan Kasa (Sabit Gider)")]
        public string FixedFrom { get; set; }
        public int? FixedExpenseId { get; set; }
        [DisplayName("Sabit Gider Açıklama")]
        public string FixedExpense { get; set; }
        public int? CustumerDibtId { get; set; }
        public int? GetCollectCashDeskActionId { get; set; }
        [DisplayName("Ödeme Alan Kasa")]
        public string MoneyToDesk { get; set; }
        [DisplayName("İşlem Türü")]
        public string ActionDesc { get; set; }

        [NotMapped]
        [DisplayName("İşlem Türü")]
        public string ActionDirectionString => ActionDirection.ToStringF();

        [NotMapped]
        [DisplayName("Ödeme Şekli")]
        public string PaymentMethodString => PaymentMethod.ToStringF();

        [NotMapped]
        [DisplayName("Ödeme Durumu")]
        public string PaymentStatuString => PaymentStatu.ToStringF();

    }
}
