int numero;
int contador = 0;
do
{
    numero = int.Parse(Console.ReadLine());
    if (numero != 0)
    {
        contador++;
    }

} while (numero != 0);
Console.WriteLine(contador);