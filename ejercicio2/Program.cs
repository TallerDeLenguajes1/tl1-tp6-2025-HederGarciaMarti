internal partial class Calculadora
{
    private static void Main(string[] args)
    {
        int continuar = 0;
        double num1, num2;
        while (continuar == 0)
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
            bool valides = int.TryParse(final, out continuar);
        }
        
    }
}