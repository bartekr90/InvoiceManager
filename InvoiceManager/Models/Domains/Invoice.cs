﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InvoiceManager.Models.Domains
{
    public class Invoice
    {
        public Invoice()
        {
            InvoicePosition = new Collection<InvoicePosition>();
        }
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tytuł:")]
        public string Title { get; set; }

        [Display(Name = "Wartość:")]
        public decimal Value { get; set; }

        [Display(Name = "Metoda płatności:")]
        public int MethodOfPaymentId { get; set; }

        [Display(Name = "Data płatności:")]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Data utworzenia:")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Uwagi:")]
        public string Comments { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        [Display(Name = "Klient:")]
        public int ClientId { get; set; }

        public MethodOfPayment MethodOfPayment { get; set; }
        public Client Client { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<InvoicePosition> InvoicePosition { get; set; }

    }
}