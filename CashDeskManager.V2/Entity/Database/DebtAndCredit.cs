using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CashDeskManager.V2.Entity.Enums;

namespace CashDeskManager.V2.Entity.Database
{
    public class DebtAndCredit
    {
        public int Id { get; set; }
        public int CashDeskId { get; set; }
        public int? TargetCashDeskId { get; set; }

        [DisplayName("Alacaklı")]
        public string TargetName { get; set; }

        [DisplayName("Para Birimi")]
        public CurrencyUnit CurrencyUnit { get; set; }

        [DisplayName("Tutar")]
        public double Amount { get; set; }


        [DisplayName("Kalan Tutar")]
        public double RemainingAmount { get; set; }

        public int? ActionId { get; set; }

        [DisplayName("Tarih")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime DateTime { get; set; }

        [DisplayName("Vade Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime? ExpiryDateTime { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Ödeme Yapan Kasa")]
        [NotMapped]
        public CashDesk TargetCashDesk { get; set; }

        [DisplayName("Borç Sahibi Kasa")]
        [NotMapped]
        public CashDesk CashDesk { get; set; }

        [NotMapped]
        [DisplayName("Kayıt Türü")]
        public string RecordType
        {
            get
            {
                if (CashDeskId == GlobalVariables.CurrentCashDesk.Id)
                {
                    return "Borç";
                }
                else if (TargetCashDeskId == GlobalVariables.CurrentCashDesk.Id)
                {
                    return "Alacak";
                }
                else
                {
                    return "Borç";
                }
            }
        }
    }
}