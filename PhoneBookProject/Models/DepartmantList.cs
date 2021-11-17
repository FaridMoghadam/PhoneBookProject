using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookProject.Models
{
    public class DepartmantList
    {
        [Key]
        public int Id { get; set; }


        [DisplayName("Depatmant Name")]
        [Required]
        public string Name { get; set; }


        [Required]
        public string Location { get; set; }
    }
}
