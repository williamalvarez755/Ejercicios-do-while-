int numero;
int pares = 0;
do
{
    Console.WriteLine("ingrese numero ");
    numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0 && numero != 0)
    {
        pares++;
    }

} while (numero != 0);

Console.WriteLine(pares);