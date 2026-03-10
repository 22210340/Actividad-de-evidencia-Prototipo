using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrototypeExamenesITT
{
    
    abstract class Examen
    {
        
        protected string materia;
        protected int cantidadPreguntas;
        protected double rubrica;
        protected string docente;
        protected string salon;
        protected string estudiante;
        protected string tipo;

        
        public Examen(string materia, int cantidadPreguntas, double rubrica,
                      string docente, string salon, string estudiante, string tipo)
        {
            this.materia = materia;
            this.cantidadPreguntas = cantidadPreguntas;
            this.rubrica = rubrica;
            this.docente = docente;
            this.salon = salon;
            this.estudiante = estudiante;
            this.tipo = tipo;
        }

        
        public abstract Examen Clonar();

        
        public virtual void Modalidad()
        {
            Console.WriteLine("Modalidad del examen: " + tipo);
        }

        public virtual void Revision()
        {
            Console.WriteLine("El docente " + docente + " revisará el examen de " + materia + ".");
        }

        public virtual void Promediar()
        {
            Console.WriteLine("La rúbrica aplicada al examen es del " + rubrica + "%.");
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Clase: " + GetType().Name);
            Console.WriteLine("Materia: " + materia);
            Console.WriteLine("Cantidad de preguntas: " + cantidadPreguntas);
            Console.WriteLine("Rúbrica: " + rubrica + "%");
            Console.WriteLine("Docente: " + docente);
            Console.WriteLine("Salón: " + salon);
            Console.WriteLine("Estudiante/Grupo: " + estudiante);
            Console.WriteLine("Tipo: " + tipo);
        }

        
        public void CambiarDocente(string nuevoDocente)
        {
            docente = nuevoDocente;
        }

        public void CambiarSalon(string nuevoSalon)
        {
            salon = nuevoSalon;
        }

        public void CambiarEstudiante(string nuevoEstudiante)
        {
            estudiante = nuevoEstudiante;
        }

        public void CambiarTipo(string nuevoTipo)
        {
            tipo = nuevoTipo;
        }

        public void CambiarPreguntas(int nuevasPreguntas)
        {
            cantidadPreguntas = nuevasPreguntas;
        }

        public void CambiarRubrica(double nuevaRubrica)
        {
            rubrica = nuevaRubrica;
        }
    }

    
    class ExamenPatronesDiseno : Examen
    {
        public ExamenPatronesDiseno(string materia, int cantidadPreguntas, double rubrica,
                                    string docente, string salon, string estudiante, string tipo)
            : base(materia, cantidadPreguntas, rubrica, docente, salon, estudiante, tipo)
        {
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }
    }

    
    class ExamenProgramacionWeb : Examen
    {
        public ExamenProgramacionWeb(string materia, int cantidadPreguntas, double rubrica,
                                     string docente, string salon, string estudiante, string tipo)
            : base(materia, cantidadPreguntas, rubrica, docente, salon, estudiante, tipo)
        {
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }
    }

    
    class ExamenBaseDatos : Examen
    {
        public ExamenBaseDatos(string materia, int cantidadPreguntas, double rubrica,
                               string docente, string salon, string estudiante, string tipo)
            : base(materia, cantidadPreguntas, rubrica, docente, salon, estudiante, tipo)
        {
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }
    }

    
    class ExamenRedes : Examen
    {
        public ExamenRedes(string materia, int cantidadPreguntas, double rubrica,
                           string docente, string salon, string estudiante, string tipo)
            : base(materia, cantidadPreguntas, rubrica, docente, salon, estudiante, tipo)
        {
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }
    }

    
    class ExamenSistemasOperativos : Examen
    {
        public ExamenSistemasOperativos(string materia, int cantidadPreguntas, double rubrica,
                                        string docente, string salon, string estudiante, string tipo)
            : base(materia, cantidadPreguntas, rubrica, docente, salon, estudiante, tipo)
        {
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }
    }

    
    class ExamenEstructuraDatos : Examen
    {
        public ExamenEstructuraDatos(string materia, int cantidadPreguntas, double rubrica,
                                     string docente, string salon, string estudiante, string tipo)
            : base(materia, cantidadPreguntas, rubrica, docente, salon, estudiante, tipo)
        {
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }
    }

    
    class ExamenInteligenciaArtificial : Examen
    {
        public ExamenInteligenciaArtificial(string materia, int cantidadPreguntas, double rubrica,
                                            string docente, string salon, string estudiante, string tipo)
            : base(materia, cantidadPreguntas, rubrica, docente, salon, estudiante, tipo)
        {
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }
    }

    
    class ExamenMatematicasDiscretas : Examen
    {
        public ExamenMatematicasDiscretas(string materia, int cantidadPreguntas, double rubrica,
                                          string docente, string salon, string estudiante, string tipo)
            : base(materia, cantidadPreguntas, rubrica, docente, salon, estudiante, tipo)
        {
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Examen> examenes = new List<Examen>();

            
            Examen examen1 = new ExamenPatronesDiseno(
                "Patrones de Diseño", 20, 50, "Mtra. Maribel Guerrero",
                "A-101", "Grupo 5A", "Escrito");

            Examen examen2 = new ExamenProgramacionWeb(
                "Programación Web", 25, 50, "Ing. Carlos Medina",
                "LAB-1", "Grupo 6A", "Práctico");

            Examen examen3 = new ExamenBaseDatos(
                "Base de Datos", 18, 50, "Dra. Ana Torres",
                "B-201", "Grupo 4A", "Escrito");

            Examen examen4 = new ExamenRedes(
                "Redes de Computadoras", 22, 50, "Ing. Roberto Vázquez",
                "LAB-RED", "Grupo 5B", "Teórico");

            Examen examen5 = new ExamenSistemasOperativos(
                "Sistemas Operativos", 19, 50, "Ing. Laura Hernández",
                "C-301", "Grupo 4B", "Mixto");

            Examen examen6 = new ExamenEstructuraDatos(
                "Estructura de Datos", 24, 50, "Ing. Miguel Sánchez",
                "A-205", "Grupo 3A", "Escrito");

            Examen examen7 = new ExamenInteligenciaArtificial(
                "Inteligencia Artificial", 21, 50, "Dra. Paola Jiménez",
                "LAB-IA", "Grupo 7A", "Proyecto");

            Examen examen8 = new ExamenMatematicasDiscretas(
                "Matemáticas Discretas", 26, 50, "Mtro. José Ramírez",
                "D-102", "Grupo 2A", "Escrito");

            examenes.Add(examen1);
            examenes.Add(examen2);
            examenes.Add(examen3);
            examenes.Add(examen4);
            examenes.Add(examen5);
            examenes.Add(examen6);
            examenes.Add(examen7);
            examenes.Add(examen8);

            
            Examen clonPatrones1 = examen1.Clonar();
            clonPatrones1.CambiarEstudiante("Grupo 5B");
            clonPatrones1.CambiarSalon("A-102");

            Examen clonPatrones2 = examen1.Clonar();
            clonPatrones2.CambiarEstudiante("Grupo 5C");
            clonPatrones2.CambiarSalon("A-103");

            
            Examen clonPatrones3 = examen1.Clonar();
            clonPatrones3.CambiarEstudiante("Grupo 5D");
            clonPatrones3.CambiarDocente("Ing. Fernando López");
            clonPatrones3.CambiarSalon("A-104");

            
            Examen clonWeb = examen2.Clonar();
            clonWeb.CambiarEstudiante("Grupo 6B");
            clonWeb.CambiarSalon("LAB-2");

            
            Examen clonBD = examen3.Clonar();
            clonBD.CambiarEstudiante("Grupo 4B");
            clonBD.CambiarDocente("Ing. Brenda Ortiz");
            clonBD.CambiarSalon("B-202");

            
            Examen clonIA = examen7.Clonar();
            clonIA.CambiarEstudiante("Grupo 7B");
            clonIA.CambiarSalon("LAB-IA-2");

            examenes.Add(clonPatrones1);
            examenes.Add(clonPatrones2);
            examenes.Add(clonPatrones3);
            examenes.Add(clonWeb);
            examenes.Add(clonBD);
            examenes.Add(clonIA);

            
            Console.WriteLine("SISTEMA DE EXÁMENES CON PATRÓN PROTOTYPE\n");

            foreach (Examen examen in examenes)
            {
                examen.MostrarDatos();
                examen.Modalidad();
                examen.Revision();
                examen.Promediar();
                Console.WriteLine();
            }

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
