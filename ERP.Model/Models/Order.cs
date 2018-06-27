using ERP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Model.Models
{
    [Table("Orders")]
   public class Order:Auditable
    {
        [Key]
        public string TagID { set; get; }

        [Required]
        public string CustomerName { set; get; }
        public string CustomerEmail { set; get; }
        public string CustomeMobile { set; get; }
        public string CustomeMessage { set; get; }
        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }

    }
}
