using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashDeskManager.V2.Entity.Database
{
    public class Custumer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Müşteri adı boş bırakılamaz")]
        [MaxLength(200, ErrorMessage = "Müşteri adı en fazla 200 karakter olabilir.")]
        [DisplayName("Adı Soyadı")]
        public string Name { get; set; }

        [MaxLength(15, ErrorMessage = "Telefon numarası en fazla 15 karakter olabilir")]
        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }
        
        [MaxLength(150, ErrorMessage = "Adres en fazla 150 karakter olabilir")]
        [DisplayName("Adres")]
        public string Address { get; set; }

        [Display(Name = "Açıklama")]
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "Açıklama uzunluğu en fazla 500 karakter olabilir.")]
        public string Description { get; set; }

        [DisplayName("Kayıt Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime RecordDate { get; set; }

        public int CashDeskId { get; set; }
        [NotMapped]
        [DisplayName("Bağlı Olduğu Kasa")]
        public CashDesk CashDesk { get; set; }

        [NotMapped]
        [DisplayName("Kalan Borç")]
        public double? RemainingDebt { get; set; }

        [NotMapped] 
        [DisplayName("Ödemesi Bitmeyen Borçlar")]
        public List<CustumerDebt> NotPayedDebts { get; set; }

        [NotMapped] 
        [DisplayName("Ödemesi Biten Borçlar")]
        public List<CustumerDebt> PayedDebts { get; set; }
    }
}