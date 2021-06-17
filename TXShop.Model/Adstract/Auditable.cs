using System;
using System.ComponentModel.DataAnnotations;

namespace TXShop.Model.Adstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreateDate { set; get; }

        [MaxLength(256)]
        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        public string MetaDiscription { set; get; }
        public bool Status { set; get; }

    }
}