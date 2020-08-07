using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Task.Model
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        [MaxLength(50)]
        public string Role { get; set; }

        /////////////

        public ICollection<Vacancy> Vacancies { get; set; }
        public ICollection<CV> CVs { get; set; }

    }
}
