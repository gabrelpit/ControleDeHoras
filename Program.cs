using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<DateTime> inicioHoras = new List<DateTime>();
        List<DateTime> fimHoras = new List<DateTime>();

        while (true)
        {
            Console.WriteLine("Escolha uma opcao");
            Console.WriteLine("1- Registar hora de inicio do trabalho");
            Console.WriteLine("2- Registar fim do trabalho");
            Console.WriteLine("3- Exibir relatorio de horas trabalhadas");
            Console.WriteLine("4- Sair");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    DateTime inicio = DateTime.Now;
                    inicioHoras.Add(inicio);
                    Console.WriteLine($"Inicio registrado as :{inicio}");
                    break;
                case "2":
                    DateTime fim = DateTime.Now;
                    fimHoras.Add(fim);
                    Console.WriteLine($"Fim registrado às: {fim}");
                    break;
                case "3":
                TimeSpan totalHoras = new TimeSpan();
                for(int i =0;i<inicioHoras.Count; i++){
                    if(i<fimHoras.Count){
                        TimeSpan horasTrabalhadas = fimHoras[i] - inicioHoras[i];
                        totalHoras += horasTrabalhadas;
                        Console.WriteLine($"Periodo {i+1}: {horasTrabalhadas}");
                    }
                    }
                    Console.WriteLine($"Total de horas trabalhadas: {totalHoras}");
                    break;
                    case "4":
                    return;
                    default:
                    Console.WriteLine("Opcao invalida, tente novamente");
                    break;
                }
            }
        }
    }

