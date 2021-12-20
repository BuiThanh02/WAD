using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Contacts
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Vui long nhap ten lien he")]
        public string ContactName { get; set; }
        [Required(ErrorMessage = "Vui long nhap so dien thoai lien he")]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage = "Vui long nhap ten nhom")]
        public string GroupName { get; set; }
        [Required(ErrorMessage = "Vui long nhap ngay thue")]
        public DateTime HireDate { get; set; }
        [Required(ErrorMessage = "Vui long nhap ngay sinh")]
        public DateTime Birthday { get; set; }
    }
}