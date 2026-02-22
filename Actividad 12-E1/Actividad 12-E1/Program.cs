Console.WriteLine("MENU");
Console.WriteLine("1. Emergencia");
Console.WriteLine("2. Consulta");
Console.WriteLine("3. Pediatría");
Console.WriteLine("4. Traumatología");
Console.WriteLine("Seleccionar una opción: ");
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
                            int prioridad;
                            string accion;
                            if (oxigeno < 90)
                            {
                                prioridad = 1;
                                accion= "Reanimación";
                            }
                            else if (temperatura >= 39 && niveldolor >= 8)
                            {
                                prioridad = 2;
                                   accion= "Atención urgente";
                            }
                            else
                            {
                                prioridad = 3;
                                accion= "Observacion";
                            }
                            Console.WriteLine("RESULTADO DEL TRIAJE");
                            Console.WriteLine($"Prioridad final:  {prioridad}");
                            Console.WriteLine($"Acción sugerida:   { accion}");
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
                            int prioridad;
                            string accion;
                            if (niveldolor >= 7 && temperatura >= 39)
                            {
                                prioridad = 1;
                                accion = "Consulta prioritaria";
                            }
                            else
                            {
                                prioridad = 2;
                                accion = "Consulta normal";
                            }
                            Console.WriteLine("RESULTADO DEL TRIAJE");
                            Console.WriteLine($"Prioridad final:  {prioridad}");
                            Console.WriteLine($"Acción sugerida:   {accion}");
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
                    Console.WriteLine("Edad invalida");
                }
            }
            break;
        }
    case 3:
        {
            Console.WriteLine("Ingresar edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad > 0 && edad <= 12)
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
                            int prioridad;
                            string accion;
                            if (temperatura >= 39 && niveldolor > 5)
                            {
                                prioridad = 1;
                                accion = "Atención pediátrica urgente";
                            }
                            else
                            {
                                prioridad = 2;
                                accion = "Observación pediátrica";
                            }
                            Console.WriteLine("RESULTADO DEL TRIAJE");
                            Console.WriteLine($"Prioridad final:  {prioridad}");
                            Console.WriteLine($"Acción sugerida:   {accion}");
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
                            int prioridad;
                            string accion;
                            if (niveldolor >8)
                            {
                                prioridad = 1;
                                accion = "Evaluación traumatológica urgente";
                            }
                            else
                            {
                                prioridad = 2;
                                accion = "Evaluación programada";
                            }
                            Console.WriteLine("RESULTADO DEL TRIAJE");
                            Console.WriteLine($"Prioridad final:  {prioridad}");
                            Console.WriteLine($"Acción sugerida:   {accion}");
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
        }
        break;
}