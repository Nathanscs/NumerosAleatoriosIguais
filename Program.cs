using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] aleatorio;
            int[,] aleatorios;
            int i, j;
            aleatorio = new int[10,10];
            aleatorios = new int[10,10];

            for(i=0;i<10;i++)
            {
                for(j=0;j<10;j++)
                {
                    Random rnd = new Random();
                    aleatorio[i,j] = rnd.Next(0, 10);
                }
            }
            for(i=0;i<10;i++)
            {
                for(j=0;j<10;j++)
                {
                    Random rnd = new Random();
                    aleatorios[i,j] = rnd.Next(0, 10);
                }
            }
            for(i=0;i<10;i++)
            {
                for(j=0;j<10;j++)
                {
                    if(aleatorio[i,j]==aleatorios[i,j])
                    {
                        Console.WriteLine("[{0}][{1}] é igual!          {2} e {3}", i, j, aleatorio[i,j], aleatorios[i,j]);
                    }
                    else
                    {
                        Console.WriteLine("[{0}][{1}] não é igual!      {2} e {3}", i, j, aleatorio[i,j], aleatorios[i,j]);
                    }
                }
            }
        }
    }   
}

