int numero;
int i = 1;
Console.WriteLine("Ingrese el número de la tabla que desea:");
numero = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine(numero * i);
    i++;

} while (i <= 10);