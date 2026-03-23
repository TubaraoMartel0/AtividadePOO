using System;
using System.Collections.Generic;
using System.Text;

namespace Frete
{
    public abstract class Entrega
    {
        public String nomeRemetente;
        public double km;
        public double peso;
        public double valorFrete;
        public abstract void calcularFrete();
    }
}
