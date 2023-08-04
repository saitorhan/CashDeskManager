using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CashDeskManager.V2.Entity.Enums;

namespace CashDeskManager.V2.Entity.Database
{
    [DisplayName("Kasa Hareketleri")]
    public class CashDeskAction
    {
        public int Id { get; set; }
        public int CashDeskId { get; set; }

        [DisplayName("Para Birimi")]
        public CurrencyUnit CurrencyUnit { get; set; }

        [DisplayName("Tutar")]
        public double Amount { get; set; }

        [DisplayName("Tarih")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DateTime { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        #region kredi kartı ve çek alanları

        [DisplayName("Banka Adı")]
        public string BankName { get; set; }

        [DisplayName("Banka Şubesi")]
        public string BankBranch { get; set; }

        [DisplayName("Çek İmza Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime? SignDateTime { get; set; }

        [DisplayName("Çek Vade Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime? ExpirtyDateTime { get; set; }

        [DisplayName("Hesap Numarası")]
        public string AccountNumber { get; set; }
        [DisplayName("Çek Numarası")]
        public string CheckNumber { get; set; }

        [DisplayName("Çek Sahibi")]
        public string CheckOwner { get; set; }

        public int? GetCollectCashDeskActionId { get; set; }

        [DisplayName("Ödemeyi Alan Kasa")]
        [NotMapped]
        public CashDesk GetPayCashDeskAction { get; set; }

        #endregion kredi kartı ve çek alanları
        public PaymentStatu PaymentStatu { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ActionDirection ActionDirection { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeleteTime { get; set; }

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