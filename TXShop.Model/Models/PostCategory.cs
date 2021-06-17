﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXShop.Model.Models
{
    [Table("PostCagories")]
    public class PostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }
        [MaxLength(500)]
        public string Description { set;get;}
        public int? ParentID { set; get; }
        public  int? DisplayOrder { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        public virtual IEnumerable<Post> Posts { set; get; }



    }
}
