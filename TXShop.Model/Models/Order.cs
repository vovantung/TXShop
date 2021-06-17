using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public string CustomerName { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerMail { set; get; }
        [Required]
        [MaxLength(50)]

        public string CustomerMoblie { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessge { set; get; }
     
        [MaxLength(256)]
        public string PaymenMethod { set; get; }
        public DateTime? CreateDate { set; get; }
        public  string CreateBy { set; get; }
        public  string PaymenStatus { set; get; }
        public bool Status { set ;get;  }

        


    }
}
