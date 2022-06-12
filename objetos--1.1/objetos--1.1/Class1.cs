using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos__1._1
{
   
    public class Engenheiro : Funcionario
    {
        public string Crea { get; set; }
        public string AreaAtuacao { get; set; }
        

        public Engenheiro()
        {
        }
        
        
        //base
        public Engenheiro(string crea, string atuacao, string rg):base(rg)
        {

     
           

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
