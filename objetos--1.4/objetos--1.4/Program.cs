using System;

namespace objetos__1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Modelo modelo = new Modelo("askjnd");
   
            //Motor motor = new Motor((TipoMotor)TipodeMotor, "TipodeCombustivel", "Descricao", "Potencia", "Torque");
            Veiculo veiculo = new Veiculo("54643565", "2007", modelo, "Agrale", 4611700, motor);



            Console.WriteLine("Chassi : " + veiculo.Chassi);
            Console.WriteLine("Ano : " + veiculo.Ano);
            Console.WriteLine("Modelo : " + veiculo.Modelo.Descricao) ;
            Console.WriteLine("Marca : " + veiculo.Marca);
            Console.WriteLine("Preco : " + veiculo.Preco);
            Console.WriteLine("Motor : " + veiculo.Motor.TipodeMotor);

            

        }
    }
}
//Faça um programa que possua classe de veículos e tenha as seguintes classes básicas com os respectivos atributos;

//Motor;

//Tipo de motor;
//Tipo de combustível;
//Descricao;
//Potencia;
//Torque;

//Modelo:

//Descrição;

//Marca:

//Descrição;
//País Origem;

//Veiculos:

//Chassis;
//Ano;
//Modelo;
//Marca;
//Preco;

//Crie outras classes que caracterizem outros tipos de veículos e seus atributos específicos, como exemplo:

//Caminhão;
//Moto;
//etc e tal