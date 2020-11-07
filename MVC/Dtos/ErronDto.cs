using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Dtos
{
    public class ErronDto
    {
        public IList<string> Errors { get; set; }
        public int Status { get; set; }


        public ErronDto()
        {
            Errors = new List<string>();
        }
    }
}
