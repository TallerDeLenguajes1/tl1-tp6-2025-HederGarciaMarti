using System.IO.Compression;

internal partial class Calculadora
{
    private static void Main(string[] args)
    {
        int continuar = 0;
        double numero1, numero2, numero3;
        while (continuar == 0)
        {
            Console.WriteLine("Ingrese un numero ");
            string resul = Console.ReadLine();
            bool valido = double.TryParse(resul, out numero1);
            if (valido)
            {
                Console.WriteLine($"Resultados para el número: {numero1}");
                Console.WriteLine($"-Valor absoluto: {Math.Abs(numero1)}");
                Console.WriteLine($"-Cuadrado: {Math.Pow(numero1, 2)}");
                Console.WriteLine($"-Raíz cuadrada: {(numero1 >= 0 ? Math.Sqrt(numero1).ToString() : "No definida para negativos")}");
                Console.WriteLine($"-Seno: {Math.Sin(numero1)}");
                Console.WriteLine($"-Coseno: {Math.Cos(numero1)}");
                Console.WriteLine($"-Parte entera: {Math.Truncate(numero1)}");
            }
            else
            {
                Console.WriteLine("Error al ingresar el numero");
                return;
            }
            Console.Write("Ingrese el primer número: ");
            string entrada_1 = Console.ReadLine();
            Console.Write("Ingrese el segundo número: ");
            string entrada_2 = Console.ReadLine();

            bool valido_1 = double.TryParse(entrada_1, out numero2);
            bool valido_2 = double.TryParse(entrada_2, out numero3);
            if (valido_1 && valido_2)
            {
                Console.WriteLine($"Maximo: {Math.Max(numero2, numero3)}");
                Console.WriteLine($"Minimo: {Math.Min(numero2, numero3)}");
            }
            else
            {
                Console.WriteLine("Error los valores ingresados no son válidos.");
            }
            Console.WriteLine("Presione 0 para continuar");
            Console.WriteLine("Presione 1 para salir");
            string resultado_salir = Console.ReadLine();
            bool validacion = int.TryParse(resultado_salir, out continuar);
        }
    }
}