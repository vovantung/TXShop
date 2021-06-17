using System;

namespace TXShop.Model.Adstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDiscription { set; get; }
        bool Status { set; get; }
    }
}