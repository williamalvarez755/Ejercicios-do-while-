int sumaTotal = 0; 
int numero;
do
{
    Console.WriteLine("Ingrese cantidad para sumar (o 0 para salir):");
    numero = int .Parse(Console.ReadLine());
    sumaTotal= sumaTotal + numero;

} while (numero != 0); 

Console.WriteLine("La suma total es: " + sumaTotal);