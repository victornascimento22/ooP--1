using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos__1._4
{
    public class Veiculo
    {
        public string Chassi { get; set; }
        public string Ano { get; set; }
        public Modelo Modelo { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public Motor Motor { get; set; }

        public Veiculo()
        {
        }

        public Veiculo(string chassi, string ano, Modelo modelo, string marca, double preco, Motor motor)
        {
            this.Chassi = chassi;
            this.Ano = ano;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Preco = preco;
            this.Motor = motor;
        }
    }
}
