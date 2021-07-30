using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Test_ElianMartinez.Models
{
    public partial class Person
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este dato es obligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este dato es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
