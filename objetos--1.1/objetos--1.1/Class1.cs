using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos__1._1
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public DateTime DatadeEntrada { get; set; }
        public string RG { get; set; }
        
        public bool _Admitido { get; set; }

        


        public Funcionario(string nome, string departamento, double salario, DateTime datadeentrada, string rg)
        {

            this.Nome = nome;
            this.Departamento = departamento;
            this.Salario = salario;
            this.DatadeEntrada = datadeentrada;
            this.RG = rg;
            

        }

        public void Demite(bool estado)
        {
            
            this._Admitido = estado;

        }

        public void Bonifica(double novoSalario1)
        {
            this.Salario = novoSalario1 * (5);
            
        }

    }
}

//Modele um funcionário. Ele deve ter o nome do funcionário, o departamento onde trabalha, seu salário(double), a data de entrada no banco (String), seu RG( String) e um valor booleano que indique se o funcionário ainda estaá ativo na empresa ou se já foi mandado embora.
//Você deve criar alguns métodos de acordo com sua necessidade. Além deles, crie um método "Bonifica" que auemnta o salário do funcinário de acordo com o parâmetro passado como argumento.
//Crie, também, um método "Demite", que não recebe parâmetro algum, só modifica o valor booleano indicando que o funcionário não trabalha mais aqui.