using System;

// CLASE PERSONA
// Aquí definimos qué información tendrá una Persona
// y qué acciones podrá realizar
class Persona
{
    // Atributos o características de la persona
    public string Nombre {set; get;}
    public int Edad {set; get;}

    // Constructores
    // Se ejecuta automáticamente cuando usamos "new Persona"
    // y sirve para darle valores iniciales al objeto.
    public Persona(string nombre, int edad)
    {
        // Guardamos el valor recibido en el atributo Nombre
        Nombre = nombre;

        // Guardamos el valor recibido en el atributo Edad
        Edad = edad;
    }

    // Método.
    // Un método es una acción que puede realizar el objeto
    public void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
    }
}

class Auto
{
    public string ModeloAuto {set; get;}
    public int AnioAuto {set; get;}
    public string ColorAuto {set; get;}

    public Auto (string modelo, int año, string color)
    {
        ModeloAuto = modelo;
        AnioAuto = año;
        ColorAuto = color;
    }
    public void PresentarAuto ()
     {
      Console.WriteLine ($"Vendemos este automovil modelo {ModeloAuto} año {AnioAuto} y de color {ColorAuto} nuevecito de paquete");   
    }
}
// PROGRAMA PRINCIPAL

class Program
{
    static void Main()
    {
     
        // Creamos los objetos de tipo Persona.
    
        Persona persona1 = new Persona("Carlos", 22);

        Persona persona2 = new Persona("Sofia", 30);

        persona1.Presentarse();

        persona2.Presentarse();

        Auto auto1 = new Auto("Ford",2026,"Azul Marino");
        //aqui se pone primero la clase "auto", despues el objeto, utilizando new llamamos el parametro y en (Ponemos los datos)
         Auto auto2 = new Auto("Tessla",2025,"Negro");
        auto1.PresentarAuto(); // aqui se manda a llamar en consola

        auto2.PresentarAuto();
    }
}