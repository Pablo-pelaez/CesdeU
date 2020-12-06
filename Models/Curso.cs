using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CesdeU.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int cursoID { get; set; }

        public string titulo { get; set; }

        public int creditos { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}