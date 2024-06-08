using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using TestStoreWeb.Migrations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TestStoreWeb.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; }

        [Display(Name = "Mô tả")]
        public string ProductDescription { get; set; }

        [Display(Name = "Hãng")]
        [Required]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Giá niêm yết")]
        [Range (1,1000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Giá khi mua số lượng từ 1-10")]
        [Range(1, 10000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Giá khi mua số lượng từ 11-20")]
        [Range(1, 10000)]
        public double Price10 { get; set; }

        [Required]
        [Display(Name = "Giá khi mua số lượng trên 20")]
        [Range(1, 10000)]
        public double Price20 { get; set; }

        [Required]
        [Display(Name = "Số lượng")]
        [Range (1, 10000)]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}
