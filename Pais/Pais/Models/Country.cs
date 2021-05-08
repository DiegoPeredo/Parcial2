using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pais.Models
{
    public class Country
    {
        [Key]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Population { get; set; }
        public string Timezones { get; set; }
        public Currency Currency { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
    }
}