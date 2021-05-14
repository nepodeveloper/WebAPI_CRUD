using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_CRUD.Models
{
    public class PaymentDetails
    {
        [Key]
        public int PaymentDetailId { get; set; }

        public string CardOwnerName { get; set; }

        public string CardNumber { get; set; }

        public string ExpirationDate { get; set; }

        public string SecurityCode { get; set; }
    }
}
