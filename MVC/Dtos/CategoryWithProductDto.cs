﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Dtos
{
    public class CategoryWithProductDto:CategoryDto
    {
        public IEnumerable<ProductDto> Product { get; set; }
    }
}
