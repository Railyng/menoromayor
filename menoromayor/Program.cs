using System;
    
    namespace menoromayor
{

    class program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("\nEste es un programa para saber que numero es mayor o menor\n");
            int numero1, numero2, numero3;

            Console.WriteLine("\nIngrese el numero1\n");
                numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el numero2\n");
                numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el numero3\n");
                numero3 = int.Parse(Console.ReadLine());

            int mayor = numero1;
            int menor = numero1;

            if (mayor > numero2) ;
                mayor = numero2;
            if (mayor > numero3) ;
                menor = numero3;j

            if (menor < numero2) ;
                menor = numero2;
            if (menor < numero3) ;
                menor = numero3;

            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);

            



                
        }
    }
}