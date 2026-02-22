Console.WriteLine("MENU");
Console.WriteLine("1. Emergencia");
Console.WriteLine("2. Consulta");
Console.WriteLine("3. Pediatría");
Console.WriteLine("4. Traumatología");
Console.Write("Seleccionar una opción: ");
int opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        {
            Console.WriteLine("Ingresar edad: ");
            int edad=int.Parse(Console.ReadLine());
            if (edad >0)
            {
                Console.WriteLine("Ingresar temperatura: ");
                int temperatura=int.Parse(Console.ReadLine());
                if (temperatura >0 && temperatura<100)
                {
                    Console.WriteLine("Ingresar saturación de oxígeno: ");
                    int oxigeno=int.Parse(Console.ReadLine());
                    if (oxigeno > 0 && oxigeno < 100)
                    {
                        Console.WriteLine("Ingresar nivel de dolor: (0–10)");
                        int niveldolor =int.Parse(Console.ReadLine());
                        if (niveldolor>=0 && niveldolor<=10)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Nivel de dolor invalido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Oxigeno invalido"); 
                    }
                }
                else
                {
                    Console.WriteLine("temperatura invalida");
                }
            }
            else
            {
                Console.WriteLine("Edad invalida");
            }
            break;
        }
    case 2:
        {
            Console.WriteLine("Ingresar edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad > 0)
            {
                Console.WriteLine("Ingresar temperatura: ");
                int temperatura = int.Parse(Console.ReadLine());
                if (temperatura > 0 && temperatura < 100)
                {
                    Console.WriteLine("Ingresar saturación de oxígeno: ");
                    int oxigeno = int.Parse(Console.ReadLine());
                    if (oxigeno > 0 && oxigeno < 100)
                    {
                        Console.WriteLine("Ingresar nivel de dolor: (0–10)");
                        int niveldolor = int.Parse(Console.ReadLine());
                        if (niveldolor >= 0 && niveldolor <= 10)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Nivel de dolor invalido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Oxigeno invalido");
                    }
                }
                else
                {
                    Console.WriteLine("temperatura invalida");
                }
            }
            else
            {
                Console.WriteLine("Edad invalida");
            }
            break;
        }
    case 3:
        {
            Console.WriteLine("Ingresar edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad > 0)
            {
                Console.WriteLine("Ingresar temperatura: ");
                int temperatura = int.Parse(Console.ReadLine());
                if (temperatura > 0 && temperatura < 100)
                {
                    Console.WriteLine("Ingresar saturación de oxígeno: ");
                    int oxigeno = int.Parse(Console.ReadLine());
                    if (oxigeno > 0 && oxigeno < 100)
                    {
                        Console.WriteLine("Ingresar nivel de dolor: (0–10)");
                        int niveldolor = int.Parse(Console.ReadLine());
                        if (niveldolor >= 0 && niveldolor <= 10)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Nivel de dolor invalido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Oxigeno invalido");
                    }
                }
                else
                {
                    Console.WriteLine("temperatura invalida");
                }
            }
            else
            {
                Console.WriteLine("Edad invalida");
            }
            break;
        }
    case 4:
        {
            Console.WriteLine("Ingresar edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad > 0)
            {
                Console.WriteLine("Ingresar temperatura: ");
                int temperatura = int.Parse(Console.ReadLine());
                if (temperatura > 0 && temperatura < 100)
                {
                    Console.WriteLine("Ingresar saturación de oxígeno: ");
                    int oxigeno = int.Parse(Console.ReadLine());
                    if (oxigeno > 0 && oxigeno < 100)
                    {
                        Console.WriteLine("Ingresar nivel de dolor: (0–10)");
                        int niveldolor = int.Parse(Console.ReadLine());
                        if (niveldolor >= 0 && niveldolor <= 10)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Nivel de dolor invalido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Oxigeno invalido");
                    }
                }
                else
                {
                    Console.WriteLine("temperatura invalida");
                }
            }
            else
            {
                Console.WriteLine("Edad invalida");
            }
            break;
        }
    default:
        {
            Console.WriteLine("Opción no válida");
            break;
        }
}