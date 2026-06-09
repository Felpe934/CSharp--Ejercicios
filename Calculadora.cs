
class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Que operacion necesitas hacer?");
        Console.Write(" 1.Sumar 2.Restar,3.Multiplicar,4.Dividir");
        int operacion = Convert.ToInt16(Console.ReadLine());

        if (operacion == 1)
        {
              Console.WriteLine("Selecciona el primer numero para sumar");
        double numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona el segundo numero para sumar");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultadosuma = numero + numero2;

        Console.WriteLine($"El valor de la suma es {resultadosuma}"); 
        } else if (operacion == 2)
        {
            Console.WriteLine("Selecciona el primer numero para restar");
        double numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona el segundo numero para restar");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultadoresta = numero - numero2;

        Console.WriteLine($"El valor de la resta es {resultadoresta}"); 

        } else if (operacion == 3)
        {
            Console.WriteLine("Selecciona el primer numero para multiplicar");
        double numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona el segundo numero para multiplicar");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultadomulti = numero * numero2;

        Console.WriteLine($"El valor de la multiplicacion es {resultadomulti}"); 
        } else if (operacion == 4)
        {
            Console.WriteLine("Selecciona el primer numero para dividir");
        double numero1division = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona el segundo numero para dividir");
        double numero2division = Convert.ToDouble(Console.ReadLine());
            if (numero2division == 0)
            {
              Console.WriteLine("No se puede dividir entre 0, favor de poner un numer valido :)"); 
            } else
            {
                 double resultadodivi = numero1division / numero2division;

        Console.WriteLine($"El valor de la divicion es {resultadodivi}"); 
            }
        } 
        

    }
}