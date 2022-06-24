using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Model;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Model
{
   public class EmployeeModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int? AddressId { get; set; }
        [Required]
        public string Code { get; set; }
        public AddressModel Address { get; set; }
    }
}
