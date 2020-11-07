using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="{0} alanı boş geçilemez.")]
        public string Name { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="{0} alanı 1'den küçük olamaz.")]
        public int  Stock { get; set; }
        [Range(1,double.MaxValue,ErrorMessage ="{0} alanı 1'den küçük olamaz.")]
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
