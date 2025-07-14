using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? PhoneNumber { get; set; }
    }
}