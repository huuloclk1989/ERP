using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public string TagID { set; get; }

        [Key]
        public int ProductID { set; get; }
    }
}