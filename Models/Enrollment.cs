namespace CesdeU.Models
{
    public enum gradoEstudio
    {
        A, B, C, D, E, F
    }

    public class Enrollment
    {
        public int enrollmentID { get; set; }

        public int estudianteID { get; set; }

        public int cursoID { get; set; }

        public gradoEstudio? gradoEstudio { get; set; }

        public virtual Curso curso { get; set; }

        public Estudiante MyProperty { get; set; }
    }
}