using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookProject.Models
{
    public class DataPhonelist
    {

        [Key]
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Column(TypeName = "nvarchar(50)")]
        public string Fname { get; set; }

        [Column(TypeName = "nvarchar(120)")]
        [Required]
        [DisplayName("Last Name")]
        public string Lname { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Location { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Departmant { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Departmant List")]
         public string ListOfDepartmant { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Division { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string Position { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "شماره تلفن باید عدد و بیشتر از 0 باشد !")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Cell Phone Number")]
        public string CellPhone { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Description { get; set; }



    }
}
