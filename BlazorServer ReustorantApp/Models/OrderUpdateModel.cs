using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer_ReustorantApp.Models
{
    public class OrderUpdateModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Should be less than 20 caracters")]
        [MinLength(3, ErrorMessage = "Not less than 3!!")]
        [DisplayName("Name of the Order")]
        public string OrderName { get; set; }
    }
}
