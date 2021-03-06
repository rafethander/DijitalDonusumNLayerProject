﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir.")]
        public string Name { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "{0} alanı 1'den büyük olmalıdır.")]
        public int Stock { get; set; }
        [Range(1,double.MaxValue,ErrorMessage ="{0} alanı 1'den büyük olmalıdır.")]
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }

    }
}
