using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos__1._4
{

    public enum TipoMotor
    {
        alem,
        dois,
        outro,
        quatro

    }
    public class Motor
    {
        public TipoMotor TipodeMotor { get; set; }
        public string TipodeCombustivel { get; set; }
        public string Descricao { get; set; }
        public string Potencia { get; set; }
        public string Torque { get; set; }

        public Motor(TipoMotor tipodemotor, string tipodecombustivel, string descricao, string potencia, string torque)
        {

            this.TipodeMotor = tipodemotor;
            this.TipodeCombustivel = tipodecombustivel;
            this.Descricao = descricao;
            this.Potencia = potencia;
            this.Torque = torque;
    }
        }
    }

