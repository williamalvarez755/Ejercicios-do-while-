int opcion;
Random r = new Random();

do
{
    Console.WriteLine("1 Mostrar saludo");
    Console.WriteLine("2 Mostrar numero aleatorio");
    Console.WriteLine("0 Salir");

    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("Hola usuario");
    }

    if (opcion == 2)
    {
        int numero = r.Next(1, 101);
        Console.WriteLine(numero);
    }

} while (opcion != 0);