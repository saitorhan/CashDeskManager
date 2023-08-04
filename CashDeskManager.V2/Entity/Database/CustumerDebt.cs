using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CashDeskManager.V2.Entity.Enums;

namespace CashDeskManager.V2.Entity.Database
{
    public class CustumerDebt
    {
        public int Id { get; set; }
        public int CustumerId { get; set; }

        [DisplayName("Para Birimi")]
        public CurrencyUnit CurrencyUnit { get; set; }

        [DisplayName("Miktar")]
        [DisplayFormat(DataFormatString = "{0:f2}")]
        public double Amount { get; set; }
        [DisplayName("Tarih")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Açıklama")]
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "Açıklama uzunluğu en fazla 500 karakter olabilir.")]
        public string Description { get; set; }
        
        public CustumerPayStatu PayStatu { get; set; }
        [DisplayName("Kalan Miktar")]
        [DisplayFormat(DataFormatString = "{0:f2}")]
        public double RemainingAmount { get; set; }

        [NotMapped]
        [DisplayName("Müşteri")]
        public Custumer Custumer { get; set; }

        [NotMapped]
        [DisplayName("Yapılan Ödemeler")]
        public List<CustumerDibtCollect> CustumerDibtCollects { get; set; }


    }
}