
class HelloWorld
{
    static void CursoMoure()
    {
            Console.WriteLine("Hello, World!");
        int numero1 = 23; //valor inicial de la variable
        numero1 = 41; // aqui cambiamos el valor de la variable por otro
        Console.WriteLine(numero1);  //Tipo de dato Int "Variable"= "valor"

        string letras = "Cadena de texto variable";
        Console.WriteLine(letras); // tipo variable texto

        float numerode = 7.2f;
        Console.WriteLine(numerode); //tipo variable decimal pero al poner el numero al final lleva "f"

        double numerodecimal = 2.30493;
        Console.WriteLine(numerodecimal); //tipo de variable decimal sin poner "f"

        var variablecualquiera = 2.4;
        Console.WriteLine(variablecualquiera); // este tipo de dato automaticamente con el valor que pongas sabe si es numerico, texto, decimal, etc mas sin embargo no se puede modificar

        bool prueba = true;
        Console.WriteLine(prueba); //para saber si es falso o verdadero la variable

        Console.WriteLine($"El valor de mi edad es {numero1} y la verdad es {prueba}"); 
        /*aqui lo que hacemos sin necesidad de utlizar muchos + y cerrar " y abrir " mandamos a llamar
        las variables dentro entre {nombrevariable} y al iniciar los (utilizamos primero el simobolo $)
        */
        const string miconstante = "esta es mi constante";
        Console.WriteLine(miconstante); //constante utiliza const, tipo de dato y nombre de variable seguido del valor

        //Estructuras
        //ARREGLOS
        var miarreglo = new string[] {"carlos","felipe","ingeniero","software"};//aqui el arreglo tiene 4 datos pero se cuenta desde 0,1,2,3
        //se inicia con var, variable, y pues new y el valor del tipo de dato , en este caso texto
        foreach (var item in miarreglo)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(miarreglo[2]); //aqui mandamos a llamar al arreglo con la posision numero 2
        Console.WriteLine(miarreglo[3]); 

        miarreglo[1]= "soy un";
        Console.WriteLine(miarreglo[1]); //aqui cambiamos el valor del arreglo en la posision 1 y lo imprimimos
        //diccionarios
        var midiccionario = new Dictionary<string, int> //igual iniciamos con var, nombre variable y new con dictionary y dentro de <va el tipo de datola calve del valor primero, y el valor>
        {
            {"carlos", 22}, //aqui esta la clave del valor, que es string y el tipo del valor, que es int 
            {"mariela", 20},
            {"hugo", 16}
            
        };

        Console.WriteLine("carlos tiene la edad de " + midiccionario["carlos"]); // y aqui los mandamos a llamar

        //tuple

        var mitupla = ("carlos","felipe","ingeniero","software");
        Console.WriteLine(mitupla); // aqui lo que hace es tener datos pero simplemente en lista donde no se puede acceder uno por uno, si no todos en uno

        //Bucles
        // ciclo for, (tipo de variable, nombre = valor; nombre <menor que; variable++ incrementa hasta llegar al numero menor que)
        for (int bucle = 0; bucle <10; bucle++)
        {
            Console.WriteLine(bucle);

        }

        foreach (var item in miarreglo) //lo que hacemos es llamar al arreglo mediante el ciclo foreach dentro de la variable item
        {
            Console.WriteLine(item);
        }

        //flujos
        int numero15 = 26;      //variable con valor

        if (numero15 == 41 && prueba == true) //si la variable es igual a "numero" y variable es igual a "valor" imprime buen programador
        {
            Console.WriteLine("eres buen programado");
        }  
        else if (numero15 == 26 || prueba == false) //si aqui se llega a cumplir almenos 1 de las 2 condiciones, imprime usas chat 
        {
            Console.WriteLine("usas chatgpt, pero buen intento");
        }
        else
        {
            Console.WriteLine("eres mal programador"); //si no se llega a cumplir ninguna de las 2 condiciones, eres mal programador
        }
        //FUNCIONES
            
        funcion();
         funcion();
          funcion(); //aqui se mandan a llamar 
        funcion2();
        
        Console.WriteLine(funcionretornable(10));


    }
        static void funcion() //se crea una funcion vacia
       
    {
    Console.WriteLine("Probando funciones 3-4");
    }
    static void funcion2()
       
    {
    Console.WriteLine("Otra funcion");
    }

     static int funcionretornable(int dato) // se crea una fucnion con dato el cual se retorna al llamarla
       
    {
     return 25 * dato; // utilizamos return para realizar la accion una vez llamada la funcion
    }
}

       

