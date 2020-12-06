using CesdeU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CesdeU.DAL
{
    public class InicializadorUniversidad : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniversidadContext>
    {
        protected override void Seed(UniversidadContext context)
        {
            var estudiantes = new List<Estudiante>
            {
            new Estudiante{nombre="Lightwood",apellido="Alexander",enrollmentDate=DateTime.Parse("2005-09-01")},
            new Estudiante{nombre="Lightwood",apellido="Isabelle",enrollmentDate=DateTime.Parse("2002-09-01")},
            new Estudiante{nombre="Herondale",apellido="Jace",enrollmentDate=DateTime.Parse("2003-09-01")},
            new Estudiante{nombre="Fairchild",apellido="Clary",enrollmentDate=DateTime.Parse("2002-09-01")},
            new Estudiante{nombre="Gray",apellido="Tessa",enrollmentDate=DateTime.Parse("2002-09-01")},
            new Estudiante{nombre="Herondale",apellido="James",enrollmentDate=DateTime.Parse("2001-09-01")},
            new Estudiante{nombre="Herondale",apellido="William",enrollmentDate=DateTime.Parse("2003-09-01")},
            };

            estudiantes.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();

            var cursos = new List<Curso>
            {
            new Curso{cursoID=1050,titulo="Química",creditos=3,},
            new Curso{cursoID=4022,titulo="Microeconomía",creditos=3,},
            new Curso{cursoID=4041,titulo="Macroeconomía",creditos=5,},
            new Curso{cursoID=1045,titulo="Cálculo",creditos=4,},
            new Curso{cursoID=3141,titulo="Trigonometría",creditos=4,},
            new Curso{cursoID=2021,titulo="Composición",creditos=2,},
            new Curso{cursoID=2042,titulo="Literatura",creditos=4,}
            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{estudianteID=1,cursoID=1050,gradoEstudio=gradoEstudio.A},
            new Enrollment{estudianteID=1,cursoID=4022,gradoEstudio=gradoEstudio.C},
            new Enrollment{estudianteID=1,cursoID=4041,gradoEstudio=gradoEstudio.B},
            new Enrollment{estudianteID=2,cursoID=1045,gradoEstudio=gradoEstudio.B},
            new Enrollment{estudianteID=2,cursoID=3141,gradoEstudio=gradoEstudio.F},
            new Enrollment{estudianteID=2,cursoID=2021,gradoEstudio=gradoEstudio.F},
            new Enrollment{estudianteID=3,cursoID=1050},
            new Enrollment{estudianteID=4,cursoID=1050,},
            new Enrollment{estudianteID=4,cursoID=4022,gradoEstudio=gradoEstudio.F},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

        }
    }
}