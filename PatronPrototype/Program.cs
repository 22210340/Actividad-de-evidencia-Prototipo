using PatronPrototipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototipo
{
    class Program
    {
        static void Main(string[] args)
        {
            ExamenPrototype prototipoPatrones = new PatronesPrototype();
            ExamenPrototype prototipoWeb = new WebPrototype();
            ExamenPrototype prototipoBD = new BaseDatosPrototype();
            ExamenPrototype prototipoRedes = new RedesPrototype();
            ExamenPrototype prototipoSO = new SistemasOperativosPrototype();
            ExamenPrototype prototipoED = new EstructuraDatosPrototype();
            ExamenPrototype prototipoIA = new InteligenciaArtificialPrototype();
            ExamenPrototype prototipoMD = new MatematicasDiscretasPrototype();

            // Patrones de Diseño
            ExamenPrototype examen1 = prototipoPatrones.Clone();
            examen1.Materia = "Patrones de Diseño";
            examen1.CantidadPreguntas = 20;
            examen1.Rubrica = 50;
            examen1.Docente = "Mtra. Maribel Guerrero";
            examen1.Salon = "A101";
            examen1.Estudiante = "Grupo 5A";
            examen1.Tipo = "Escrito";

            Console.WriteLine(examen1.VerExamen());
            Console.WriteLine(examen1.Modalidad());
            Console.WriteLine(examen1.Revision());
            Console.WriteLine(examen1.Promediar());
            Console.WriteLine();

            // Otro grupo misma materia
            ExamenPrototype examen2 = prototipoPatrones.Clone();
            examen2.Materia = "Patrones de Diseño";
            examen2.CantidadPreguntas = 20;
            examen2.Rubrica = 50;
            examen2.Docente = "Mtra. Maribel Guerrero";
            examen2.Salon = "A102";
            examen2.Estudiante = "Grupo 5B";
            examen2.Tipo = "Escrito";

            Console.WriteLine(examen2.VerExamen());
            Console.WriteLine();

            // Programación Web
            ExamenPrototype web = prototipoWeb.Clone();
            web.Materia = "Programación Web";
            web.CantidadPreguntas = 25;
            web.Rubrica = 50;
            web.Docente = "Ing. Carlos Medina";
            web.Salon = "LAB1";
            web.Estudiante = "Grupo 6A";
            web.Tipo = "Práctico";

            Console.WriteLine(web.VerExamen());
            Console.WriteLine();

            // Base de Datos
            ExamenPrototype bd = prototipoBD.Clone();
            bd.Materia = "Base de Datos";
            bd.CantidadPreguntas = 18;
            bd.Rubrica = 50;
            bd.Docente = "Dra. Ana Torres";
            bd.Salon = "B201";
            bd.Estudiante = "Grupo 4A";
            bd.Tipo = "Escrito";

            Console.WriteLine(bd.VerExamen());
            Console.WriteLine();

            // Redes
            ExamenPrototype redes = prototipoRedes.Clone();
            redes.Materia = "Redes";
            redes.CantidadPreguntas = 22;
            redes.Rubrica = 50;
            redes.Docente = "Ing. Roberto Vázquez";
            redes.Salon = "LabRed";
            redes.Estudiante = "Grupo 5B";
            redes.Tipo = "Teórico";

            Console.WriteLine(redes.VerExamen());
            Console.WriteLine();

            // Sistemas Operativos
            ExamenPrototype so = prototipoSO.Clone();
            so.Materia = "Sistemas Operativos";
            so.CantidadPreguntas = 19;
            so.Rubrica = 50;
            so.Docente = "Ing. Laura Hernández";
            so.Salon = "C301";
            so.Estudiante = "Grupo 4B";
            so.Tipo = "Mixto";

            Console.WriteLine(so.VerExamen());
            Console.WriteLine();

            // Estructura de Datos
            ExamenPrototype ed = prototipoED.Clone();
            ed.Materia = "Estructura de Datos";
            ed.CantidadPreguntas = 24;
            ed.Rubrica = 50;
            ed.Docente = "Ing. Miguel Sánchez";
            ed.Salon = "A205";
            ed.Estudiante = "Grupo 3A";
            ed.Tipo = "Escrito";

            Console.WriteLine(ed.VerExamen());
            Console.WriteLine();

            // Inteligencia Artificial
            ExamenPrototype ia = prototipoIA.Clone();
            ia.Materia = "Inteligencia Artificial";
            ia.CantidadPreguntas = 21;
            ia.Rubrica = 50;
            ia.Docente = "Dra. Paola Jiménez";
            ia.Salon = "LabIA";
            ia.Estudiante = "Grupo 7A";
            ia.Tipo = "Proyecto";

            Console.WriteLine(ia.VerExamen());
            Console.WriteLine();

            // Matemáticas Discretas
            ExamenPrototype md = prototipoMD.Clone();
            md.Materia = "Matemáticas Discretas";
            md.CantidadPreguntas = 26;
            md.Rubrica = 50;
            md.Docente = "Mtro. José Ramírez";
            md.Salon = "D102";
            md.Estudiante = "Grupo 2A";
            md.Tipo = "Escrito";

            Console.WriteLine(md.VerExamen());

            Console.ReadKey();
        }
    }
}
