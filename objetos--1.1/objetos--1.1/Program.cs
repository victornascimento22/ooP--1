using System;

namespace objetos__1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Victor ", "TI", 2500, new DateTime(2022, 09, 06), "291809689");

            funcionario.Demite(false);
            funcionario.Bonifica(5000);



            Console.WriteLine("Funcionario : " + funcionario.Nome);
            Console.WriteLine("Departamento : " + funcionario.Departamento);
            Console.WriteLine("Salario : " + funcionario.Salario);
            Console.WriteLine("Data de Entrada : " + funcionario.DatadeEntrada);
           
            Console.WriteLine("Atividade : " + funcionario._Admitido);



           
        }
    }
}
