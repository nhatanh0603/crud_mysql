using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MYSQL.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
