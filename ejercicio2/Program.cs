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
        int continuar1 = 0;
        double num1, num2;
        while (continuar1 == 0)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Presione una de las siguientes opciones");
            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");
            string opcion = Console.ReadLine();

            Console.WriteLine("Ingrese el primer numero: ");
            string valor1 = Console.ReadLine();
            bool entrada1 = double.TryParse(valor1, out num1);

            Console.WriteLine("Ingrese el segundo numero: ");
            string valor2 = Console.ReadLine();
            bool entrada2 = double.TryParse(valor2, out num2);
            if (entrada1 && entrada2)
            {
                double resultado = 0;
                switch (opcion)
                {
                    case "1":
                        resultado = num1 + num2;
                        break;
                    case "2":
                        resultado = num1 - num2;
                        break;
                    case "3":
                        resultado = num1 * num2;
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error al dividir en 0");
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion invalidad");
                        break;

                }
                if (num2 == 0)
                {
                    Console.WriteLine("El resultado es:-9999999999999999999999999");
                }else
                {
                    Console.WriteLine($"El resultado es: {resultado}");
                }
                
            }
            else
            {
                Console.WriteLine("Error al ingresar los numeros");
            }
            Console.WriteLine("Presione 0 para continuar con la calculadora");
            Console.WriteLine("Presione 1 para salir");
            string final = Console.ReadLine();
            bool valides = int.TryParse(final, out continuar1);
        }
    }
}
