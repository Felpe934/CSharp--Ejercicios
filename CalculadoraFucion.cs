class Calculadorafuncion
{
    static void calculadora2() 
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

           Console.WriteLine($"El valor de la suma es {parametrosuma(numero, numero2)}");
        }
        else if (operacion == 2)
        {
            Console.WriteLine("Selecciona el primer numero para restar");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Selecciona el segundo numero para restar");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El valor de la resta es {parametroresta( numero,  numero2)}"); 
        } 
        else if (operacion == 3)
        {
            Console.WriteLine("Selecciona el primer numero para multiplicar");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Selecciona el segundo numero para multiplicar");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"El valor de la multiplicacion es {parametromulti( numero,  numero2)}"); 
        } 
        else if (operacion == 4)
        {
            Console.WriteLine("Selecciona el primer numero para dividir");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Selecciona el segundo numero para dividir");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0, favor de poner un numero valido :)"); 
            } 
            else
            {
                Console.WriteLine($"El valor de la division es {parametrodivision(numero,  numero2)}"); 
            }
        } 
    }
    static double parametrosuma(double numero, double numero2)
    {
        return numero + numero2;
    }
    static double parametroresta(double numero, double numero2)
    {
        return numero - numero2;
    }
     static double parametromulti(double numero, double numero2)
    {
        return numero * numero2;
    }
    static double parametrodivision(double numero, double numero2)
    {
         return numero / numero2;
    }

}