using System;
using System.Collections.Generic;

namespace CesdeU.Models
{
    public class Estudiante
    {
        public int ID { get; set; }

        public string apellido { get; set; }

        public string nombre { get; set; }

        public DateTime enrollmentDate { get; set; }

        public virtual ICollection<Enrollment>Enrollments { get; set; }
    }
}