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
protected string materia;
 protected int cantidadPreguntas;
 protected double rubrica;
 protected string docente;
 protected string salon;
 protected string estudiante;
 protected string tipo;
```
## Contructor
```csharp
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
```
## Método abstracto de clonación
```csharp
public abstract Examen Clonar();
```
## Método mostrar interfaz
```csharp
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
 }
```
## Método Para realizar copias y su personalizacion
```csharp
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
```
## Examenes solo un Ejemplo
```csharp
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
```
## Prototipos 
```csharp
 List<Examen> examenes = new List<Examen>();

 // PROTOTIPOS ORIGINALES (8 materias distintas)
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
```
## Donde se guarda los prototipos originales
```csharp
examenes.Add(examen1);
examenes.Add(examen2);
examenes.Add(examen3);
examenes.Add(examen4);
examenes.Add(examen5);
examenes.Add(examen6);
examenes.Add(examen7);
examenes.Add(examen8);
```
## Clonaciones (Misma materia, Mismo Docente, Distinto grupo) 
```csharp
Examen clonPatrones1 = examen1.Clonar();
clonPatrones1.CambiarEstudiante("Grupo 5B");
clonPatrones1.CambiarSalon("A-102");

Examen clonPatrones2 = examen1.Clonar();
clonPatrones2.CambiarEstudiante("Grupo 5C");
clonPatrones2.CambiarSalon("A-103");

// Misma materia, diferente docente
Examen clonPatrones3 = examen1.Clonar();
clonPatrones3.CambiarEstudiante("Grupo 5D");
clonPatrones3.CambiarDocente("Ing. Fernando López");
clonPatrones3.CambiarSalon("A-104");

// Programación Web, otro grupo
Examen clonWeb = examen2.Clonar();
clonWeb.CambiarEstudiante("Grupo 6B");
clonWeb.CambiarSalon("LAB-2");

// Base de Datos, otro docente
Examen clonBD = examen3.Clonar();
clonBD.CambiarEstudiante("Grupo 4B");
clonBD.CambiarDocente("Ing. Brenda Ortiz");
clonBD.CambiarSalon("B-202");

// IA, otro grupo
Examen clonIA = examen7.Clonar();
clonIA.CambiarEstudiante("Grupo 7B");
clonIA.CambiarSalon("LAB-IA-2");

examenes.Add(clonPatrones1);
examenes.Add(clonPatrones2);
examenes.Add(clonPatrones3);
examenes.Add(clonWeb);
examenes.Add(clonBD);
examenes.Add(clonIA);
```
## Impresion De Codigo 
```csharp
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
Examen clonPatrones2 = examen1.Clonar();
```
Eso crea una copia del examen original.


# Donde se ve la herencia

```csharp
protected string materia;
protected int cantidadPreguntas;
protected double rubrica;
protected string docente;
protected string salon;
protected string estudiante;
protected string tipo;
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
