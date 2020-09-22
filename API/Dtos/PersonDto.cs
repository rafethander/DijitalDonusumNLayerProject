using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PersonDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Boş geçilemez alan: {0}")]
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
