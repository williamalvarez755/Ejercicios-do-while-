int numero;
int mayor = 0;
do
{
    numero = int.Parse(Console.ReadLine());

    if (numero > mayor)
    {
        mayor = numero;
    }

} while (numero != 0);
Console.WriteLine(mayor);