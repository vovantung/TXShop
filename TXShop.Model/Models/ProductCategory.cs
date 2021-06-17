using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXShop.Model.Adstract;

namespace TXShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public string Desciption { set; get; }
        public int ParentID { set; get; }
        public int DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        public virtual IEnumerable<Product> Products { set; get; }

    }
}
