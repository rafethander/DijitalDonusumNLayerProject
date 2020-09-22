using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Adress { get; set; }
        public char[] Phone { get; set; }
        public string Country { get; set; }
        public char[] IdentityNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
