﻿using System;
using System.Globalization;

namespace DesafiosDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculaConsumoMedio();
            //DDD();
            //AumentaSalario();
            AumentoPopulacional();
        }
        static void CalculaConsumoMedio()
        {
            int distancia;
            double combustivelGasto, consumoMedio;

            string strDist = Console.ReadLine();
            if(string.IsNullOrEmpty(strDist))
            {
                throw new Exception("string de entrada é nula, ou vazia.");
            }
            distancia = int.Parse(strDist, CultureInfo.InvariantCulture);
            combustivelGasto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            combustivelGasto = Math.Round(combustivelGasto,1);
            
            if(distancia<0 || combustivelGasto<=0)
            {
                throw new ArgumentException();
            }
            else{
                consumoMedio = Math.Round(distancia/combustivelGasto,3);
                Console.WriteLine($"{consumoMedio} km/l");
            }
        }
        static void DDD()
        {
            int.TryParse(Console.ReadLine(), out int ddd);
            switch (ddd)
            {
                case 61:
                    Console.WriteLine("Brasilia");
                    break;
                case 71:                             //complete os DDD's corretamente
                    Console.WriteLine("Salvador");
                    break;
                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                default:
                    throw new ArgumentException("DDD não cadastrado");
                    //break;
            }   
        }
        static void AumentaSalario()
        {
            // double salario, reajuste, novoSalario, percentual;
            // string salarioString = Console.ReadLine();
            // if(string.IsNullOrEmpty(salarioString))
            // {
            //     throw new ArgumentException();
            // }
            // salario = double.Parse(salarioString,CultureInfo.InvariantCulture);
            // if(salario < 0)
            // {
            //     throw new ArgumentOutOfRangeException();
            // }
            // if(salario >= 0.00 && salario <= 400.00)
            // {
            //     reajuste = salario * 0.15; 
            //     novoSalario = salario + reajuste;
            //     if(salario == 0)
            //     {
            //         percentual = 0;
            //     }
            //     else
            //     {
            //          percentual = ((novoSalario - salario) * 100/salario);
            //     }
            //     Console.WriteLine("Novo salario: {0:0.00}",novoSalario.ToString("0.00") );
            //     Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("0.00"));
            //     Console.WriteLine("Em percentual: {0:0} %", percentual);
            // }
            // else if (salario > 400.00 && salario <= 800.00)
            // {
            //     reajuste = salario * 0.12; 
            //     novoSalario = salario + reajuste;
            //     percentual = ((novoSalario - salario) * 100/salario);
            //     Console.WriteLine("Novo salario: {0:0.00}",novoSalario.ToString("0.00") );
            //     Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("0.00"));
            //     Console.WriteLine("Em percentual: {0:0} %", percentual);
            // }
            // else if (salario > 800.00 && salario <= 1200.00)
            // {
            //     reajuste = salario * 0.1; 
            //     novoSalario = salario + reajuste;
            //     percentual = ((novoSalario - salario) * 100/salario);
            //     Console.WriteLine("Novo salario: {0:0.00}",novoSalario.ToString("0.00") );
            //     Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("0.00"));
            //     Console.WriteLine("Em percentual: {0:0} %", percentual);
            // }
            // else if (salario > 1200.00 && salario <= 2000.00)
            // {
            //     reajuste = salario * 0.07; 
            //     novoSalario = salario + reajuste;
            //     percentual = ((novoSalario - salario) * 100/salario);
            //     Console.WriteLine("Novo salario: {0:0.00}",novoSalario.ToString("0.00") );
            //     Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("0.00"));
            //     Console.WriteLine("Em percentual: {0:0} %", percentual);
            // }
            // else
            // {
            //     //Acima de 2000
            //     reajuste = salario * 0.04; 
            //     novoSalario = salario + reajuste;
            //     percentual = ((novoSalario - salario) * 100/salario);
            //     Console.WriteLine("Novo salario: {0:0.00}",novoSalario.ToString("0.00") );
            //     Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste.ToString("0.00"));
            //     Console.WriteLine("Em percentual: {0:0} %", percentual);
            // }

        
            double salario = 0, novoSalario = 0, percentual = 0;

            double.TryParse(Console.ReadLine(), out salario);
            
            if (salario > 0 && salario <= 400.00)
                percentual = 15;
            else if (salario > 400.00 && salario <= 800.00)
                percentual = 12;
            else if (salario > 800.00 && salario <= 1200.00)
                percentual = 10;
            else if (salario > 1200.00 && salario <= 2000.00)
                percentual = 7;
            else if (salario > 2000.00)
                percentual = 4;
            
            novoSalario = salario + (salario * (percentual / 100));

            var culture = CultureInfo.InvariantCulture;

            Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", culture)}");
            Console.WriteLine($"Reajuste ganho: {(novoSalario - salario).ToString("F2", culture)}");
            Console.WriteLine($"Em percentual: {percentual} %");
        }
        static void AumentoPopulacional()
        {
            //Console.WriteLine("Quantidade");
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            var culture = CultureInfo.InvariantCulture;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split(" ");
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

               //declare as variaveis corretamente
                cpa = double.Parse(valores[2],culture)/100;
                //Console.WriteLine(cpa);
                cpb = double.Parse(valores[3],culture)/100;
                //Console.WriteLine(cpb);
                while (pa <= pb)
                {

                   //complete o while
                   pa = Convert.ToInt32((1+cpa)*pa);
                   pb = Convert.ToInt32((1+cpb)*pb);
                   anos++;
                   if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo");
                        break;
                    }
                }

                if (anos <= 100)
                {
                   Console.WriteLine("{0} anos.", anos);
                }
            }
// 8
// 100 1100000 7.1 1.0
// 500 56866 5.0 3.7
// 654327 894521 8.4 3.2
// 100 199 3.0 0.0
// 190 200 0.2 0.1
// 666 6660 10.0 9.0
// 696 6969 1.9 1.8
// 101 103 .5 .2
        }
    }
}
