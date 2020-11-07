using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Dtos
{
    public class PersonDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="{0} alanı boş geçilemez.")]
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
