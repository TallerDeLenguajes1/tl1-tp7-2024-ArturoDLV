using espacioCalculadora;
Calculadora calc = new Calculadora();
int opcion;

do
{
    Console.Clear();
    opcion = mostrarMenu();
    switch (opcion)
    {
        case 1:
        {
            sumar();
            break;
        }
        
        case 2:
        {
            restar();
            break;
        }

        case 3:
        {
            multiplicar();
            break;
        }

        case 4:
        {
            dividir();
            break;
        }

        case 5:
        {
            limpiar();
            break;
        }

        case -1:
        {
            Console.WriteLine("Saliendo del programa, gracias por utilizar nuestro servicio.");
            break;
        }

        default:
        {
            Console.WriteLine("La opcion ingresada es invalida. Porfavor elija una de la lista e ingresela tal cual se muestra.");
            break;
        }
    }

    Console.WriteLine("\nPresione ENTER para conntinuar");
    Console.ReadLine();
}
while (opcion != -1);

int mostrarMenu()
{
    int opcion;

    Console.WriteLine("\n--------------------- Menu: Calculadora Basica Secuencial ---------------------");
    Console.WriteLine("\nEsta calculadora tiene un unico valor al cual se le aplican operaciones.");
    Console.WriteLine("El valor actual del mismo es: X = " + calc.resultado);
    Console.WriteLine("\nSeleccione una operacion de la lista con su correspondiente numero:");
    Console.WriteLine("'1': Sumarle un numero a 'X'.");
    Console.WriteLine("'2': Restarle un numero a 'X'.");
    Console.WriteLine("'3': Multiplicar a 'X' un numero de veces.");
    Console.WriteLine("'4': Dividir a 'X' por un numero (No puede ser 0).");
    Console.WriteLine("'5': Limpiar el valor de 'X' (Hacerlo igual a 0).");
    Console.WriteLine("'-1': Ingresar para salir del programa.");
    Console.Write("\nIngrese su opcion deseada: ");
    int.TryParse(Console.ReadLine(), out opcion);
    Console.WriteLine("\n-------------------------------- Fin del menu --------------------------------");

    return opcion;
}

void sumar()
{
    double valor;

    Console.WriteLine("\nUsted a elegido la opcion '1' correspondiente a la operacion 'sumar'");
    Console.Write("Ingrese un numero para realizar la operacion (puede ser decimal): ");
    if (double.TryParse(Console.ReadLine(), out valor))
    {
        calc.sumar(valor);
        Console.WriteLine("\nOperacion realizada correctamente. El nuevo valor de 'X' es: '" + calc.resultado + "'");
    }
    else
    {
        Console.WriteLine("\nEl valor ingresado es invalido. Se volvera al menu sin realizar ninguna operacion.");
    }
}

void restar()
{
    double valor;

    Console.WriteLine("\nUsted a elegido la opcion '2' correspondiente a la operacion 'restar'");
    Console.Write("Ingrese un numero para realizar la operacion (puede ser decimal): ");
    if (double.TryParse(Console.ReadLine(), out valor))
    {
        calc.restar(valor);
        Console.WriteLine("\nOperacion realizada correctamente. El nuevo valor de 'X' es: '" + calc.resultado + "'");
    }
    else
    {
        Console.WriteLine("\nEl valor ingresado es invalido. Se volvera al menu sin realizar ninguna operacion.");
    }
}

void multiplicar()
{
    double valor;

    Console.WriteLine("\nUsted a elegido la opcion '3' correspondiente a la operacion 'multiplicar'");
    Console.Write("Ingrese un numero para realizar la operacion (puede ser decimal): ");
    if (double.TryParse(Console.ReadLine(), out valor))
    {
        calc.multiplicar(valor);
        Console.WriteLine("\nOperacion realizada correctamente. El nuevo valor de 'X' es: '" + calc.resultado + "'");
    }
    else
    {
        Console.WriteLine("\nEl valor ingresado es invalido. Se volvera al menu sin realizar ninguna operacion.");
    }
}

void dividir()
{
    double valor;

    Console.WriteLine("\nUsted a elegido la opcion '4' correspondiente a la operacion 'dividir'");
    Console.Write("Ingrese un numero para realizar la operacion (puede ser decimal): ");
    if (double.TryParse(Console.ReadLine(), out valor))
    {
        calc.dividir(valor);
        Console.WriteLine("\nOperacion realizada correctamente. El nuevo valor de 'X' es: '" + calc.resultado + "'");
    }
    else
    {
        Console.WriteLine("\nEl valor ingresado es invalido. Se volvera al menu sin realizar ninguna operacion.");
    }
}

void limpiar()
{
    Console.WriteLine("\nUsted a elegido la opcion '5' correspondiente a la operacion 'limpiar'");
    calc.limpiar();Console.WriteLine("Operacion realizada correctamente. El nuevo valor de 'X' es: '" + calc.resultado + "'");
}