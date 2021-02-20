using System;

namespace DesafiosDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculaConsumoMedio();
            //DDD();
            AumentaSalario();
            
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
            int.TryParse(strDist, out distancia);
            double.TryParse(Console.ReadLine(), out combustivelGasto);
            
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
            double salario, reajuste, novoSalario, percentual;
            string salarioString = Console.ReadLine();
            if(string.IsNullOrEmpty(salarioString))
            {
                throw new ArgumentException();
            }
            salario = Convert.ToDouble(salarioString);
            salario = Math.Round(salario,2);

            if(salario >= 0.00 && salario <= 400.00)
            {
                reajuste = Math.Round(salario * 0.15,2); 
                novoSalario = Math.Round(salario + reajuste,2);
                percentual = Math.Round(((novoSalario - salario) * 100/salario),2);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("N2").Replace(".","")}" );
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("N2").Replace(".","")}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = Math.Round(salario * 0.12,2); 
                novoSalario = Math.Round(salario + reajuste,2);
                percentual = Math.Round(((novoSalario - salario) * 100/salario),2);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("N2").Replace(".","")}" );
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("N2").Replace(".","")}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                reajuste = Math.Round(salario * 0.1,2); 
                novoSalario = Math.Round(salario + reajuste,2);
                percentual = Math.Round(((novoSalario - salario) * 100 /salario),2);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("N2").Replace(".","")}" );
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("N2").Replace(".","")}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                reajuste = Math.Round(salario * 0.07,2); 
                novoSalario = Math.Round(salario + reajuste,2);
                percentual = Math.Round(((novoSalario - salario) * 100/salario),2);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("N2").Replace(".","")}" );
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("N2").Replace(".","")}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
            else
            {
                //Acima de 2000
                reajuste = Math.Round(salario * 0.04,2); 
                novoSalario = Math.Round(salario + reajuste,2);
                percentual = Math.Round(((novoSalario - salario) * 100/salario),2);
                Console.WriteLine($"Novo salario: {novoSalario.ToString("N2").Replace(".","")}" );
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("N2").Replace(".","")}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
        }
    }
}
