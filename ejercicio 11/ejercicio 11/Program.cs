int i = 1;
int suma = 0;
do
{
    Console.WriteLine("ingrese valor para sumar " + i );
    int valor = Convert.ToInt32(Console.ReadLine());
    suma = suma + valor;
    i++;
} while (i<=5);
Console.WriteLine("la suma total es " + suma);