internal class Invertir
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número: ");
        string variable = Console.ReadLine();
        bool valor = int.TryParse(variable, out int numero);
        int invertir = 0, num;
        if (valor)
        {
            if (numero > 0)
            {
                while (numero > 0)
                {
                    num = numero % 10;
                    invertir = invertir * 10 + num;
                    numero = numero / 10;
                }
                Console.WriteLine($"Número invertido: {invertir}");
            }
            else
            {
                Console.WriteLine("El número debe ser mayor a 0.");
            }
        }
    }
}