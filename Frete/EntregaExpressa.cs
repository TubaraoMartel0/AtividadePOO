using System;
using System.Collections.Generic;
using System.Text;

namespace Frete
{
    internal class EntregaExpressa : Entrega
    {
        public override void calcularFrete()
        {
            Console.WriteLine("Insira o nome do remetente");
            nomeRemetente = Console.ReadLine();
            Console.WriteLine("Insira a kilometragem");
            km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o peso do pacote");
            peso = Convert.ToDouble(Console.ReadLine());

            valorFrete = (km * 10) + (peso * 10) + 3;
            Console.WriteLine("O valor do frete normal é: " + valorFrete);
        }
    }
}
