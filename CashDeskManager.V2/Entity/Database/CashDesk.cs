using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashDeskManager.V2.Entity.Database
{
    public class CashDesk
    {
        public CashDesk()
        {
            Custumers = new List<Custumer>();
        }

        public int Id { get; set; }

        [MaxLength(200, ErrorMessage = "Kasa adı en fazla 200 karakter olabilir.")]
        [Required(ErrorMessage = "Kasa adı boş bırakılamaz.")]
        [Display(Name = "Kasa Adı")]
        [DisplayName("Kasa Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Kasa oluşturma tarihi boş bırakılamaz")]
        [Display(Name = "Oluşturma Tarihi")]
        [DisplayName("Oluşturma Tarihi")]
        public DateTime CreatedDateTime { get; set; }

        [Display(Name = "Açıklama")]
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "Açıklama uzunluğu en fazla 500 karakter olabilir.")]
        public string Description { get; set; }

        [NotMapped]
        [DisplayName("Müşteriler")]
        public List<Custumer> Custumers { get; set; }

        [NotMapped]
        [DisplayName("Sabit Giderler")]
        public List<FixedExpense> FixedExpenses { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}