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
public abstract class ExamenPrototype
```
## Atributos protegidos
```csharp
protected string _materia;
protected int _cantidadPreguntas;
protected double _rubrica;
protected string _docente;
protected string _salon;
protected string _estudiante;
protected string _tipo;
```
## Propiedades para modificar atributos
```csharp
public string Materia { set => _materia = value; }
public int CantidadPreguntas { set => _cantidadPreguntas = value; }
public double Rubrica { set => _rubrica = value; }
public string Docente { set => _docente = value; }
public string Salon { set => _salon = value; }
public string Estudiante { set => _estudiante = value; }
public string Tipo { set => _tipo = value; }
```
## Método abstracto de clonación
```csharp
public abstract ExamenPrototype Clone();
```
## Método mostrar interfaz
```csharp
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
```

## Examenes solo un Ejemplo
```csharp
public class PatronesPrototype : ExamenPrototype
{
    public override ExamenPrototype Clone()
    {
        return (PatronesPrototype)this.MemberwiseClone();
    }

    public override string VerExamen()
    {
        return $"Examen de {_materia}, {_cantidadPreguntas} preguntas, docente {_docente}, salón {_salon}, grupo {_estudiante}";
    }
}
```
## Prototipos 
```csharp
ExamenPrototype prototipoPatrones = new PatronesPrototype();
ExamenPrototype prototipoWeb = new WebPrototype();
ExamenPrototype prototipoBD = new BaseDatosPrototype();
ExamenPrototype prototipoRedes = new RedesPrototype();
ExamenPrototype prototipoSO = new SistemasOperativosPrototype();
ExamenPrototype prototipoED = new EstructuraDatosPrototype();
ExamenPrototype prototipoIA = new InteligenciaArtificialPrototype();
ExamenPrototype prototipoMD = new MatematicasDiscretasPrototype();
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
ExamenPrototype examen1 = prototipoPatrones.Clone();
examen1.Materia = "Patrones de Diseño";
examen1.CantidadPreguntas = 20;
examen1.Rubrica = 50;
examen1.Docente = "Mtra. Maribel Guerrero";
examen1.Salon = "A101";
examen1.Estudiante = "Grupo 5A";
examen1.Tipo = "Escrito";

ExamenPrototype examen2 = prototipoPatrones.Clone();
examen2.Materia = "Patrones de Diseño";
examen2.CantidadPreguntas = 20;
examen2.Rubrica = 50;
examen2.Docente = "Mtra. Maribel Guerrero";
examen2.Salon = "A102";
examen2.Estudiante = "Grupo 5B";
examen2.Tipo = "Escrito";

ExamenPrototype web = prototipoWeb.Clone();
web.Materia = "Programación Web";
web.CantidadPreguntas = 25;
web.Rubrica = 50;
web.Docente = "Ing. Carlos Medina";
web.Salon = "LAB1";
web.Estudiante = "Grupo 6A";
web.Tipo = "Práctico";

ExamenPrototype bd = prototipoBD.Clone();
bd.Materia = "Base de Datos";
bd.CantidadPreguntas = 18;
bd.Rubrica = 50;
bd.Docente = "Dra. Ana Torres";
bd.Salon = "B201";
bd.Estudiante = "Grupo 4A";
bd.Tipo = "Escrito";

ExamenPrototype redes = prototipoRedes.Clone();
redes.Materia = "Redes";
redes.CantidadPreguntas = 22;
redes.Rubrica = 50;
redes.Docente = "Ing. Roberto Vázquez";
redes.Salon = "LabRed";
redes.Estudiante = "Grupo 5B";
redes.Tipo = "Teórico";

ExamenPrototype so = prototipoSO.Clone();
so.Materia = "Sistemas Operativos";
so.CantidadPreguntas = 19;
so.Rubrica = 50;
so.Docente = "Ing. Laura Hernández";
so.Salon = "C301";
so.Estudiante = "Grupo 4B";
so.Tipo = "Mixto";

ExamenPrototype ed = prototipoED.Clone();
ed.Materia = "Estructura de Datos";
ed.CantidadPreguntas = 24;
ed.Rubrica = 50;
ed.Docente = "Ing. Miguel Sánchez";
ed.Salon = "A205";
ed.Estudiante = "Grupo 3A";
ed.Tipo = "Escrito";

ExamenPrototype ia = prototipoIA.Clone();
ia.Materia = "Inteligencia Artificial";
ia.CantidadPreguntas = 21;
ia.Rubrica = 50;
ia.Docente = "Dra. Paola Jiménez";
ia.Salon = "LabIA";
ia.Estudiante = "Grupo 7A";
ia.Tipo = "Proyecto";

ExamenPrototype md = prototipoMD.Clone();
md.Materia = "Matemáticas Discretas";
md.CantidadPreguntas = 26;
md.Rubrica = 50;
md.Docente = "Mtro. José Ramírez";
md.Salon = "D102";
md.Estudiante = "Grupo 2A";
md.Tipo = "Escrito";
```
## Impresion De Codigo 
```csharp
Console.WriteLine(examen1.VerExamen());
Console.WriteLine(examen1.Modalidad());
Console.WriteLine(examen1.Revision());
Console.WriteLine(examen1.Promediar());
```






# Donde se ve la herencia 

```csharp
public abstract class ExamenPrototype
```
y luego las clases hijas:

```csharp
public class PatronesPrototype : ExamenPrototype
public class WebPrototype : ExamenPrototype
public class BaseDatosPrototype : ExamenPrototype
public class RedesPrototype : ExamenPrototype
public class SistemasOperativosPrototype : ExamenPrototype
public class EstructuraDatosPrototype : ExamenPrototype
public class InteligenciaArtificialPrototype : ExamenPrototype
public class MatematicasDiscretasPrototype : ExamenPrototype
```
Todas heredan de la clase base `ExamenPrototype`.

# Donde se ve la herencia 
La clonación se ve en el método

```csharp
public override ExamenPrototype Clone()
{
    return (PatronesPrototype)this.MemberwiseClone();
}
```

Y cuando se usa así:
```csharp
ExamenPrototype examen2 = prototipoPatrones.Clone();
```
Eso crea una copia del examen original.


# Donde se ve la herencia

```csharp
protected string _materia;
protected int _cantidadPreguntas;
protected double _rubrica;
protected string _docente;
protected string _salon;
protected string _estudiante;
protected string _tipo;
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
