using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CashDeskManager.V2.Entity.Enums;

namespace CashDeskManager.V2.Entity.Database
{
    public class FixedExpense
    {
        public int Id { get; set; }

        public int CashDeskId { get; set; }

        [Required(ErrorMessage = "Gider türü boş bırakılamaz")]
        [Display(Name = "Gider Türü")]
        [DisplayName("Gider Türü")]
        [MaxLength(100, ErrorMessage = "Gider Türü en fazla 100 karakter olabilir")]
        public string ExpenseType { get; set; }

        [Display(Name = "Açıklama")]
        [DisplayName("Açıklama")]
        [MaxLength(100, ErrorMessage = "Açıklama uzunluğu en fazla 100 karakter olabilir.")]
        [Required(ErrorMessage = "Açıklama boş bırakılamaz")]
        public string Description { get; set; }

        [Display(Name = "Para Birimi")]
        [DisplayName("Para Birimi")]
        [Required(ErrorMessage = "Para birimi boş bırakılamaz")]
        public CurrencyUnit CurrencyUnit { get; set; }

        [Required(ErrorMessage = "Miktar boş bırakılamaz")]
        [DisplayName("Miktar")]
        [DisplayFormat(DataFormatString = "{0:f2}")]
        public double Amount { get; set; }

        [DisplayName("Gider Periyodu")]
        [Required(ErrorMessage = "Gider periyodu boş bırakılamaz")]
        public FixedExpensePeriod FixedExpensePeriod { get; set; }

        [DisplayName("Gider Periyodu (Gün)")]
        public int? FixedExpensePeriodCustomDay { get; set; }

        [DisplayName("Başlama Tarihi")]
        [Required(ErrorMessage = "Başlama tarihi boş bırakılamaz")]
        public DateTime StartDate { get; set; }
        [DisplayName("Son Geçmiş Tarih")]
        public DateTime? LastDate { get; set; }
        [DisplayName("Sonraki İlk Tarih")]
        public DateTime? NextDate { get; set; }

        [NotMapped]
        [DisplayName("Borcun Olduğu Kasa")]
        public CashDesk CashDesk { get; set; }

        [NotMapped]
        [DisplayName("Yapılan Ödemeler")]
        public List<FixedExpensePay> FixedExpensePays { get; set; }
    }
}