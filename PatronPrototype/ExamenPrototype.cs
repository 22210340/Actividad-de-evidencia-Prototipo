using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototipo
{
    public abstract class ExamenPrototype
    {
        protected string _materia;
        protected int _cantidadPreguntas;
        protected double _rubrica;
        protected string _docente;
        protected string _salon;
        protected string _estudiante;
        protected string _tipo;

        public string Materia { set => _materia = value; }
        public int CantidadPreguntas { set => _cantidadPreguntas = value; }
        public double Rubrica { set => _rubrica = value; }
        public string Docente { set => _docente = value; }
        public string Salon { set => _salon = value; }
        public string Estudiante { set => _estudiante = value; }
        public string Tipo { set => _tipo = value; }

        public abstract ExamenPrototype Clone();
        public abstract string VerExamen();

        public virtual string Modalidad()
        {
            return $"Modalidad del examen: {_tipo}";
        }

        public virtual string Revision()
        {
            return $"El docente {_docente} revisará el examen de {_materia}";
        }

        public virtual string Promediar()
        {
            return $"La rúbrica aplicada es del {_rubrica}%";
        }
    }
}
