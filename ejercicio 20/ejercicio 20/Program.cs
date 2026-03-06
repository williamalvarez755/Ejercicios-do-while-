int numero;
int suma = 0;
int contador = 0;
do
{
    Console.WriteLine("ingrese numero y presione 0 para salir");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0)
    {
        suma = suma + numero;
        contador++;
    }

} while (numero != 0);

double promedio = (double)suma / contador;

Console.WriteLine("Suma: " + suma);
Console.WriteLine("Cantidad de números ingresados: " + contador);
Console.WriteLine("Promedio: " + promedio);