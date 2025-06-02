internal partial class Cadena
{
    private static void Main(string[] args)
    {
        Console.Write("Cadena1\n");
        double num1, num2;
        Console.Write("Ingrese una cadena de texto: ");
        string cadena1 = Console.ReadLine();

        int longitud = cadena1.Length;
        Console.WriteLine($"La longitud de la cadena es: {longitud}");

        Console.Write("Cadena2\n");
        Console.Write("Ingrese una segunda cadena de texto: ");
        string cadena2 = Console.ReadLine();

        string concatenacion = string.Concat(cadena1, " ", cadena2);
        Console.WriteLine($"Las cadenas concatenadas son: {concatenacion}");

        Console.Write("Ingrese el índice de inicio para extraer subcadena: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de caracteres a extraer: ");
        int cantidad = int.Parse(Console.ReadLine());

        if (inicio >= 0 && inicio + cantidad <= cadena1.Length)
        {
            string subcadena = cadena1.Substring(inicio, cantidad);
            Console.WriteLine($"La subcadena extraida es: {subcadena}");
        }
        else
        {
            Console.WriteLine("Indices invalidos para extraer la subcadena.");
        }
        Console.Write("Calculadora\n");
        Console.Write("Ingrese el primer número: ");
        string entrada1 = Console.ReadLine();
        bool valido1 = double.TryParse(entrada1, out num1);

        Console.Write("Ingrese el segundo número: ");
        string entrada2 = Console.ReadLine();
        bool valido2 = double.TryParse(entrada2, out num2);
        if (valido1 & valido2)
        {
            double suma = num1 + num2;
            Console.WriteLine($"La suma de {num1} y {num2} es igual a: {suma}");

            double resta = num1 - num2;
            Console.WriteLine($"La resta de {num1} y {num2} es igual a: {resta}");

            double multi = num1 * num2;
            Console.WriteLine($"La multiplicación de {num1} y {num2} es igual a: {multi}");

            if (num2 != 0)
            {
                double division = num1 / num2;
                Console.WriteLine($"La división de {num1} entre {num2} es igual a: {division}");
            }
            else
            {
                Console.WriteLine("No se puede dividir en cero");
            }

        }
        else
        {
            Console.WriteLine("Los valores ingresados no son numeros validos.");
        }
        //Mostrar Caracteres
        Console.WriteLine("Caracteres de la cadena:");
        foreach (char c in cadena1)
        {
            Console.WriteLine(c);
        }
        //Buscar una palabra en la cadena1
        Console.Write("Ingrese la palabra a buscar: ");
        string palabra = Console.ReadLine();
        if (cadena1.Contains(palabra))
        {
            Console.WriteLine($"La palabra \"{palabra}\" se encuentra en la cadena.");
        }
        else
        {
            Console.WriteLine($"La palabra \"{palabra}\" no se encuentra en la cadena.");
        }
        //Convertir cadena1y2 a minusculas y mayusculas
        string mayus = cadena1.ToUpper();
        Console.WriteLine($"La cadena en mayuscula es: {mayus}");
        string minus = cadena1.ToLower();
        Console.WriteLine($"La cadena en mayuscula es: {minus}");
        //split
        Console.Write("Ingrese una cadena separada por comas: ");
        string cadena3 = Console.ReadLine();
        Console.Write("Ingrese el caracter separador: ");
        char separador = Console.ReadKey().KeyChar;
        string[] partes = cadena3.Split(separador);

        foreach (string parte in partes)
        {
            Console.WriteLine(parte);
        }
        double n1, n2;
        Console.WriteLine("Ingrese una ecuacion utlizando el + o - o * o /");
        string ecuacion = Console.ReadLine();
        char operador = ' ';
        bool operar = false;
        if (ecuacion.Contains("+"))
        {
            operador = '+';
            operar = true;
        }
        if (ecuacion.Contains("-"))
        {
            operador = '-';
            operar = true;
        }
        if (ecuacion.Contains("*"))
        {
            operador = '*';
            operar = true;
        }
        if (ecuacion.Contains("/"))
        {
            operador = '/';
            operar = true;
        }

        if (operar)
        {
             string[] partes1 = ecuacion.Split(operador);  // ← Aquí ahora sí está bien

            if (partes1.Length == 2 &&
                double.TryParse(partes1[0], out n1) &&
                double.TryParse(partes1[1], out n2))
            {
                double resultadoDenum = 0;

                switch (operador)
                {
                    case '+':
                        resultadoDenum = n1 + n2;
                    break;
                    case '-':
                        resultadoDenum = n1 - n2;
                    break;
                    case '*':
                        resultadoDenum = n1 * n2;
                    break;
                    case '/':
                    if (n2 != 0)
                        resultadoDenum = n1 / n2;
                    else
                    {
                        Console.WriteLine("No es posible dividir en cero.");
                        return;
                    }
                    break;
                }

                Console.WriteLine($"El resultado de {n1} {operador} {n2} es: {resultadoDenum}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}