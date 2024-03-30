using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMOMO_nhom2.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yeu cau nhap mo ta danh muc")]
        public string Name { get; set; }
       
        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yeu cau nhap mo ta danh muc")]
        public string Description { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yeu cau nhap mo ta danh muc")]
        public decimal Price { get; set; }

    
        public int BrandId {  get; set; }
      
        public int CategoryId { get; set;}
        public CategotyModel Categoty { get; set; }
        public BrandModel Brand { get; set; }
        public string Image {  get; set; }

    }
}
