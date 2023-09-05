using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace URICustomizationandEntityFrameworkIntegration.Models
{
    [Table("School11")]
    public class StudentViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Class { get; set; }
        public string Email { get; set; }

    }
}