using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gamificacao_02
{
    public class Promocao
    {

        public enum TipoDesconto
        {
            Porcentagem,
            ValorFixo
        }


        public CategoriaProduto Categoria { get; set; }

        public Promocao(double valor, TipoDesconto tipo)
        {
            ValorDesconto = valor;
            Desconto = tipo;
        }

        public TipoDesconto Desconto { get; set; }
        public double ValorDesconto { get; set; }

        public static List<Promocao> promocoes = new List<Promocao>();
      
        public double CalcularValorDesconto(double precoOriginal)
        {
            if (Desconto == TipoDesconto.Porcentagem)
            {
                return precoOriginal * (ValorDesconto / 100.0);
            }
            else if(Desconto == TipoDesconto.ValorFixo)
            {
                return precoOriginal - ValorDesconto;
            } else
            {
                return 0;
            }
        }

       

    }

   
}
