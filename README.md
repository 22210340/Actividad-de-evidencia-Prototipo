# Actividad-de-evidencia-Prototipo

![C#](https://img.shields.io/badge/C%23-Programming-blue)
![Design Pattern](https://img.shields.io/badge/Design%20Pattern-Prototype-green)
![Herencia](https://img.shields.io/badge/POO-Herencia-yellow)
![Clonación](https://img.shields.io/badge/Prototype-Clonaci%C3%B3n-important)
![Protected](https://img.shields.io/badge/Atributos-Protected-lightgrey)
![Status](https://img.shields.io/badge/Status-Academic%20Project-success)

# Instituto Tecnológico de Tijuana

**Tecnológico Nacional de México**  
**Subdirección Académica**  
**Departamento de Sistemas y Computación**

**Carrera:** Ingeniería en Sistemas Computacionales  
**Materia:** Patrones de Diseño  
**Alumno:** Kevin Jonathan Rivas Pérez  
**Docente:** Maribel Guerrero Luis  
**Semestre:** Enero - Junio 2025  

# Desgloce De Codigo
## Clase abstracta base
```csharp
abstract class Examen
```
## Atributos protegidos
```csharp
 protected string claveMateria;
 protected string nombreAsignatura;
 protected string docente;
 protected string grupo;
 protected string salon;
 protected DateTime fechaAplicacion;
 protected int duracionMinutos;
 protected string instrucciones;
```
## Contructor
```csharp
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
```
## Método abstracto de clonación
```csharp
public abstract Examen Clonar();
```
## Método mostrar interfaz
```csharp
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
```
## Método Para realizar copias y su personalizacion
```csharp
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
```
## Examenes solo un Ejemplo
```csharp
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
```
## Prototipos 
```csharp
 List<Examen> examenes = new List<Examen>();

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
```
## Donde se guarda los prototipos originales
```csharp
examenes.Add(prototipoPatrones);
examenes.Add(prototipoWeb);
examenes.Add(prototipoBD);
examenes.Add(prototipoRedes);
examenes.Add(prototipoSO);
examenes.Add(prototipoED);
examenes.Add(prototipoIA);
examenes.Add(prototipoMD);
```
## Clonaciones (Misma materia, Mismo Docente, Distinto grupo) 
```csharp
 Examen patronesGrupo5B = prototipoPatrones.Clonar();
 patronesGrupo5B.CambiarGrupo("5B");
 patronesGrupo5B.CambiarSalon("A-202");
 patronesGrupo5B.CambiarFecha(new DateTime(2026, 3, 16));

 Examen patronesGrupo5C = prototipoPatrones.Clonar();
 patronesGrupo5C.CambiarGrupo("5C");
 patronesGrupo5C.CambiarSalon("A-203");
 patronesGrupo5C.CambiarFecha(new DateTime(2026, 3, 17));

 
 Examen patronesOtroDocente = prototipoPatrones.Clonar();
 patronesOtroDocente.CambiarDocente("Ing. Fernando López");
 patronesOtroDocente.CambiarGrupo("5D");
 patronesOtroDocente.CambiarSalon("A-204");
 patronesOtroDocente.CambiarFecha(new DateTime(2026, 3, 18));

 
 Examen webGrupo6C = prototipoWeb.Clonar();
 webGrupo6C.CambiarGrupo("6C");
 webGrupo6C.CambiarSalon("LAB-4");
 webGrupo6C.CambiarFecha(new DateTime(2026, 3, 18));


 Examen bdOtroDocente = prototipoBD.Clonar();
 bdOtroDocente.CambiarDocente("Ing. Brenda Ortiz");
 bdOtroDocente.CambiarGrupo("4D");
 bdOtroDocente.CambiarSalon("B-105");

 
 Examen redesGrupo5E = prototipoRedes.Clonar();
 redesGrupo5E.CambiarGrupo("5E");
 redesGrupo5E.CambiarFecha(new DateTime(2026, 3, 19));


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
```
## Impresion De Codigo 
```csharp
Console.WriteLine("SISTEMA DE EXÁMENES UTILIZANDO EL PATRÓN PROTOTYPE\n");

foreach (Examen examen in examenes)
{
    examen.MostrarInformacion();
    Console.WriteLine();
}

Console.WriteLine("Presiona una tecla para finalizar...");
Console.ReadKey();
```






# Donde se ve la herencia 

```csharp
abstract class Examen
```
y luego las clases hijas:

```csharp
class ExamenPatronesDiseno : Examen
class ExamenProgramacionWeb : Examen
class ExamenBaseDatos : Examen
class ExamenRedes : Examen
class ExamenSistemasOperativos : Examen
class ExamenEstructuraDatos : Examen
class ExamenInteligenciaArtificial : Examen
class ExamenMatematicasDiscretas : Examen
```
Todas heredan de la clase base `Examen`.

# Donde se ve la herencia 
La clonación se ve en el método

```csharp
public override Examen Clonar()
{
    return (Examen)this.MemberwiseClone();
}
```

Y cuando se usa así:
```csharp
Examen patronesGrupo5B = prototipoPatrones.Clonar();
```
Eso crea una copia del examen original.


# Donde se ve la herencia

```csharp
protected string claveMateria;
protected string nombreAsignatura;
protected string docente;
protected string grupo;
protected string salon;
protected DateTime fechaAplicacion;
protected int duracionMinutos;
protected string instrucciones;
```
Son protected porque:
no se exponen directamente al exterior,
pero sí pueden ser usados por las clases hijas.

# Explicación 

El patrón Prototype permite crear objetos nuevos a partir de una copia de un objeto ya existente.
En este caso:
el examen original funciona como prototipo, y las copias representan exámenes para otros grupos o docentes, compartiendo atributos comunes como:

**Clave De Materia**

**Nombre Asignatura** 

**Docente**

**Salon** 

**Instrucciones** 

**Duracion** 


Así el sistema es más rápido, reutilizable y fácil de mantener.



# Conclusión

El programa muestra como hace alucion el patron de diseño Prototipo que la verdad en el concepto es ideal por que se necesitan muchos objetos crearlos vaya y son similares como es un examen solo de diferentes materias y en diferentes grupos. Gracias a la herencia es la que nos ayuda a compartir estructura comun por los tipos de examenes pero siempre la clase real un Examen mediante la clonacion estamos generando copias y copias y copias rapidas que usan los atributos protegidos que se mantiene encapsulado y reutilizando codigo esto hace que el sistema este siendo mas ordenado en codigo y limpio flexible y escalable.
