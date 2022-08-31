using System;

namespace Ciclosjercicio1
{
    class ejercicio50
    {
        static void Main(string[] args)
        {
            //51.Generar 15 números al azar entre 1 y 20.Al finalizar informar la cantidad de números
            //entre 10 y 15, los menores a 7 y la suma de los números generados.
            Console.WriteLine("Se generan 15 numeros entre 1 y 20 y se informa la cantidad de numeros entre 10 y 10 y menores a 7");

            Random ran = new Random();
            double menoresa7 = 0, entre10y15 = 0, sumamenores = 0, sumaentre = 0;
            double sumaparc = 0;
            for (int i = 0; i < 15; i++)
            {
                var numero = ran.Next(1,21000)/1000.0;
                //var numero2 = Math.Truncate(numero * 100) / 100;
                sumaparc += numero;
                sumaparc=(Math.Truncate(sumaparc*100)/100);
                //var numero = Math.Round(ran.Next(1, 21000) / (1000.0),4);
                //Math.Round(sumaparc += numero,2);
                Console.WriteLine($"El numero es;  {numero} suma parcial; {sumaparc}");
                if (numero<=15 && numero>=10)
                {
                    entre10y15++;

                    sumaentre += numero;
                }
                else if(numero<7)
                {
                    menoresa7++;
                    sumamenores += numero;
                }
            }
            Console.WriteLine($"Se generaron {entre10y15} numeros entre 10 y 15, y su suma es {Math.Round(sumaentre,2)}");
            Console.WriteLine($"Se generaron {menoresa7} numeros menores a 7, y su suma es {Math.Round(sumamenores,2)}");
        }
    }
}
