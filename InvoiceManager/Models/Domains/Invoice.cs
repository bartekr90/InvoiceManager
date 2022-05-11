using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManager.Models.Domains
{
    public class Invoice
    {
        public Invoice()
        {
            InvoicePosition = new Collection<InvoicePosition>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage ="Pole tytuł jest wymagane!")]
        [Display(Name = "Tytuł:")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Pole wartość jest wymagane!")]
        [Display(Name = "Wartość:")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "Pole metoda płatności jest wymagane!")]
        [Display(Name = "Metoda płatności:")]
        public int MethodOfPaymentId { get; set; }

        [Required(ErrorMessage ="Pole data płatności jest wymagane!")]
        [Display(Name = "Data płatności:")]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Data utworzenia:")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Uwagi:")]
        public string Comments { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        [Required(ErrorMessage ="Pole Klient jest wymagane!")]
        [Display(Name = "Klient:")]
        public int ClientId { get; set; }

        public MethodOfPayment MethodOfPayment { get; set; }
        public Client Client { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<InvoicePosition> InvoicePosition { get; set; }
    }
}