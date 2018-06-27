using System;

namespace ERP.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedBDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}