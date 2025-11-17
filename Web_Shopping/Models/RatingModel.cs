using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Shopping.Models
{
    public class RatingModel
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; } // Liên kết với sản phẩm nào

        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung đánh giá")]
        public string Comment { get; set; }

        public int StarRating { get; set; } // Số sao (1-5)

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [ForeignKey("ProductId")]
        public ProductModel Product { get; set; }
    }
}
