using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace miniapps.Models
{
    public class ProductModel
    {
        [DisplayName("Id Number")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        [DisplayName("How much the cost")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DisplayName("What you get")]
        public string Description { get; set; }
    }
}
