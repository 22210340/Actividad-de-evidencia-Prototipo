using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PatronPrototypeExamenes
{
    // Clase abstracta base del prototipo
    abstract class Examen
    {
        // Atributos protegidos: las clases hijas pueden acceder a ellos
        protected string claveMateria;
        protected string nombreAsignatura;
        protected string docente;
        protected string grupo;
        protected string salon;
        protected DateTime fechaAplicacion;
        protected int duracionMinutos;
        protected string instrucciones;

        // Constructor
        public Examen(
            string claveMateria,
            string nombreAsignatura,
            string docente,
            string grupo,
            string salon,
            DateTime fechaAplicacion,
            int duracionMinutos,
            string instrucciones)
        {
            this.claveMateria = claveMateria;
            this.nombreAsignatura = nombreAsignatura;
            this.docente = docente;
            this.grupo = grupo;
            this.salon = salon;
            this.fechaAplicacion = fechaAplicacion;
            this.duracionMinutos = duracionMinutos;
            this.instrucciones = instrucciones;
        }

        // Método abstracto de clonación
        public abstract Examen Clonar();

        // Método para mostrar la información del examen
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("TIPO DE EXAMEN: " + GetType().Name);
            Console.WriteLine("Clave de materia : " + claveMateria);
            Console.WriteLine("Asignatura       : " + nombreAsignatura);
            Console.WriteLine("Docente          : " + docente);
            Console.WriteLine("Grupo            : " + grupo);
            Console.WriteLine("Salón            : " + salon);
            Console.WriteLine("Fecha            : " + fechaAplicacion.ToString("dd/MM/yyyy"));
            Console.WriteLine("Duración         : " + duracionMinutos + " minutos");
            Console.WriteLine("Instrucciones    : " + instrucciones);
        }

        // Métodos para personalizar la copia
        public void CambiarGrupo(string nuevoGrupo)
        {
            grupo = nuevoGrupo;
        }

        public void CambiarSalon(string nuevoSalon)
        {
            salon = nuevoSalon;
        }

        public void CambiarDocente(string nuevoDocente)
        {
            docente = nuevoDocente;
        }

        public void CambiarFecha(DateTime nuevaFecha)
        {
            fechaAplicacion = nuevaFecha;
        }

        public void CambiarDuracion(int nuevaDuracion)
        {
            duracionMinutos = nuevaDuracion;
        }

        public void CambiarInstrucciones(string nuevasInstrucciones)
        {
            instrucciones = nuevasInstrucciones;
        }
    }

    // 1. Examen de Patrones de Diseño
    class ExamenPatronesDiseno : Examen
    {
        private string unidad;

        public ExamenPatronesDiseno(
            string claveMateria,
            string nombreAsignatura,
            string docente,
            string grupo,
            string salon,
            DateTime fechaAplicacion,
            int duracionMinutos,
            string instrucciones,
            string unidad)
            : base(claveMateria, nombreAsignatura, docente, grupo, salon, fechaAplicacion, duracionMinutos, instrucciones)
        {
            this.unidad = unidad;
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Unidad evaluada  : " + unidad);
        }
    }

    // 2. Examen de Programación Web
    class ExamenProgramacionWeb : Examen
    {
        private bool incluyePractica;

        public ExamenProgramacionWeb(
            string claveMateria,
            string nombreAsignatura,
            string docente,
            string grupo,
            string salon,
            DateTime fechaAplicacion,
            int duracionMinutos,
            string instrucciones,
            bool incluyePractica)
            : base(claveMateria, nombreAsignatura, docente, grupo, salon, fechaAplicacion, duracionMinutos, instrucciones)
        {
            this.incluyePractica = incluyePractica;
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Incluye práctica : " + (incluyePractica ? "Sí" : "No"));
        }
    }

    // 3. Examen de Base de Datos
    class ExamenBaseDatos : Examen
    {
        private string motorBD;

        public ExamenBaseDatos(
            string claveMateria,
            string nombreAsignatura,
            string docente,
            string grupo,
            string salon,
            DateTime fechaAplicacion,
            int duracionMinutos,
            string instrucciones,
            string motorBD)
            : base(claveMateria, nombreAsignatura, docente, grupo, salon, fechaAplicacion, duracionMinutos, instrucciones)
        {
            this.motorBD = motorBD;
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Motor BD         : " + motorBD);
        }
    }

    // 4. Examen de Redes
    class ExamenRedes : Examen
    {
        private string temaPrincipal;

        public ExamenRedes(
            string claveMateria,
            string nombreAsignatura,
            string docente,
            string grupo,
            string salon,
            DateTime fechaAplicacion,
            int duracionMinutos,
            string instrucciones,
            string temaPrincipal)
            : base(claveMateria, nombreAsignatura, docente, grupo, salon, fechaAplicacion, duracionMinutos, instrucciones)
        {
            this.temaPrincipal = temaPrincipal;
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tema principal   : " + temaPrincipal);
        }
    }

    // 5. Examen de Sistemas Operativos
    class ExamenSistemasOperativos : Examen
    {
        private string plataforma;

        public ExamenSistemasOperativos(
            string claveMateria,
            string nombreAsignatura,
            string docente,
            string grupo,
            string salon,
            DateTime fechaAplicacion,
            int duracionMinutos,
            string instrucciones,
            string plataforma)
            : base(claveMateria, nombreAsignatura, docente, grupo, salon, fechaAplicacion, duracionMinutos, instrucciones)
        {
            this.plataforma = plataforma;
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Plataforma       : " + plataforma);
        }
    }

    // 6. Examen de Estructura de Datos
    class ExamenEstructuraDatos : Examen
    {
        private string estructuraPrincipal;

        public ExamenEstructuraDatos(
            string claveMateria,
            string nombreAsignatura,
            string docente,
            string grupo,
            string salon,
            DateTime fechaAplicacion,
            int duracionMinutos,
            string instrucciones,
            string estructuraPrincipal)
            : base(claveMateria, nombreAsignatura, docente, grupo, salon, fechaAplicacion, duracionMinutos, instrucciones)
        {
            this.estructuraPrincipal = estructuraPrincipal;
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Estructura clave : " + estructuraPrincipal);
        }
    }

    // 7. Examen de Inteligencia Artificial
    class ExamenInteligenciaArtificial : Examen
    {
        private string enfoque;

        public ExamenInteligenciaArtificial(
            string claveMateria,
            string nombreAsignatura,
            string docente,
            string grupo,
            string salon,
            DateTime fechaAplicacion,
            int duracionMinutos,
            string instrucciones,
            string enfoque)
            : base(claveMateria, nombreAsignatura, docente, grupo, salon, fechaAplicacion, duracionMinutos, instrucciones)
        {
            this.enfoque = enfoque;
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Enfoque          : " + enfoque);
        }
    }

    // 8. Examen de Matemáticas Discretas
    class ExamenMatematicasDiscretas : Examen
    {
        private string bloqueTematico;

        public ExamenMatematicasDiscretas(
            string claveMateria,
            string nombreAsignatura,
            string docente,
            string grupo,
            string salon,
            DateTime fechaAplicacion,
            int duracionMinutos,
            string instrucciones,
            string bloqueTematico)
            : base(claveMateria, nombreAsignatura, docente, grupo, salon, fechaAplicacion, duracionMinutos, instrucciones)
        {
            this.bloqueTematico = bloqueTematico;
        }

        public override Examen Clonar()
        {
            return (Examen)this.MemberwiseClone();
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Bloque temático  : " + bloqueTematico);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Examen> examenes = new List<Examen>();

            // ===== PROTOTIPOS ORIGINALES =====

            Examen prototipoPatrones = new ExamenPatronesDiseno(
                "SCC-1015",
                "Patrones de Diseño",
                "Mtra. Maribel Guerrero Luis",
                "5A",
                "A-201",
                new DateTime(2026, 3, 15),
                90,
                "Contestar con lapicero azul o negro.",
                "Patrones Creacionales");

            Examen prototipoWeb = new ExamenProgramacionWeb(
                "PW-202",
                "Programación Web",
                "Ing. Carlos Medina",
                "6B",
                "LAB-3",
                new DateTime(2026, 3, 16),
                100,
                "Resolver ejercicios teóricos y prácticos.",
                true);

            Examen prototipoBD = new ExamenBaseDatos(
                "TIF-304",
                "Base de Datos",
                "Dra. Ana Torres",
                "4C",
                "B-104",
                new DateTime(2026, 3, 17),
                80,
                "No se permite celular.",
                "SQL Server");

            Examen prototipoRedes = new ExamenRedes(
                "AEC-1058",
                "Redes de Computadoras",
                "Ing. Roberto Vázquez",
                "5D",
                "LAB-RED",
                new DateTime(2026, 3, 18),
                90,
                "Examen individual.",
                "Modelo OSI y direccionamiento IP");

            Examen prototipoSO = new ExamenSistemasOperativos(
                "AEC-1061",
                "Sistemas Operativos",
                "Ing. Laura Hernández",
                "4A",
                "C-301",
                new DateTime(2026, 3, 19),
                85,
                "Justificar respuestas abiertas.",
                "Linux");

            Examen prototipoED = new ExamenEstructuraDatos(
                "AED-1026",
                "Estructura de Datos",
                "Ing. Miguel Sánchez",
                "3B",
                "A-103",
                new DateTime(2026, 3, 20),
                90,
                "Puede incluir pseudocódigo.",
                "Árboles y listas enlazadas");

            Examen prototipoIA = new ExamenInteligenciaArtificial(
                "IA-401",
                "Inteligencia Artificial",
                "Dra. Paola Jiménez",
                "7A",
                "LAB-IA",
                new DateTime(2026, 3, 21),
                110,
                "Responder teoría y caso práctico.",
                "Aprendizaje supervisado");

            Examen prototipoMD = new ExamenMatematicasDiscretas(
                "ACF-0905",
                "Matemáticas Discretas",
                "Mtro. José Ramírez",
                "2A",
                "D-202",
                new DateTime(2026, 3, 22),
                75,
                "Se permite formulario impreso.",
                "Lógica proposicional y teoría de conjuntos");

            // Guardamos los prototipos originales
            examenes.Add(prototipoPatrones);
            examenes.Add(prototipoWeb);
            examenes.Add(prototipoBD);
            examenes.Add(prototipoRedes);
            examenes.Add(prototipoSO);
            examenes.Add(prototipoED);
            examenes.Add(prototipoIA);
            examenes.Add(prototipoMD);

            // ===== CLONACIONES =====
            // Misma materia, mismo docente, distinto grupo
            Examen patronesGrupo5B = prototipoPatrones.Clonar();
            patronesGrupo5B.CambiarGrupo("5B");
            patronesGrupo5B.CambiarSalon("A-202");
            patronesGrupo5B.CambiarFecha(new DateTime(2026, 3, 16));

            Examen patronesGrupo5C = prototipoPatrones.Clonar();
            patronesGrupo5C.CambiarGrupo("5C");
            patronesGrupo5C.CambiarSalon("A-203");
            patronesGrupo5C.CambiarFecha(new DateTime(2026, 3, 17));

            // Misma materia, diferente docente
            Examen patronesOtroDocente = prototipoPatrones.Clonar();
            patronesOtroDocente.CambiarDocente("Ing. Fernando López");
            patronesOtroDocente.CambiarGrupo("5D");
            patronesOtroDocente.CambiarSalon("A-204");
            patronesOtroDocente.CambiarFecha(new DateTime(2026, 3, 18));

            // Programación Web en otro grupo
            Examen webGrupo6C = prototipoWeb.Clonar();
            webGrupo6C.CambiarGrupo("6C");
            webGrupo6C.CambiarSalon("LAB-4");
            webGrupo6C.CambiarFecha(new DateTime(2026, 3, 18));

            // Base de Datos con otro docente
            Examen bdOtroDocente = prototipoBD.Clonar();
            bdOtroDocente.CambiarDocente("Ing. Brenda Ortiz");
            bdOtroDocente.CambiarGrupo("4D");
            bdOtroDocente.CambiarSalon("B-105");

            // Redes en otro grupo
            Examen redesGrupo5E = prototipoRedes.Clonar();
            redesGrupo5E.CambiarGrupo("5E");
            redesGrupo5E.CambiarFecha(new DateTime(2026, 3, 19));

            // IA otro grupo
            Examen iaGrupo7B = prototipoIA.Clonar();
            iaGrupo7B.CambiarGrupo("7B");
            iaGrupo7B.CambiarSalon("LAB-IA-2");

            examenes.Add(patronesGrupo5B);
            examenes.Add(patronesGrupo5C);
            examenes.Add(patronesOtroDocente);
            examenes.Add(webGrupo6C);
            examenes.Add(bdOtroDocente);
            examenes.Add(redesGrupo5E);
            examenes.Add(iaGrupo7B);

            // ===== MOSTRAR TODOS LOS EXÁMENES =====
            Console.WriteLine("SISTEMA DE EXÁMENES UTILIZANDO EL PATRÓN PROTOTYPE\n");

            foreach (Examen examen in examenes)
            {
                examen.MostrarInformacion();
                Console.WriteLine();
            }

            Console.WriteLine("Presiona una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
