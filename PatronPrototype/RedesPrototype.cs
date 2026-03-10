using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototipo
{
    public class RedesPrototype : ExamenPrototype
    {
        public override ExamenPrototype Clone()
        {
            return (RedesPrototype)this.MemberwiseClone();
        }

        public override string VerExamen()
        {
            return $"Examen de {_materia}, {_cantidadPreguntas} preguntas, docente {_docente}, salón {_salon}, grupo {_estudiante}";
        }
    }
}
