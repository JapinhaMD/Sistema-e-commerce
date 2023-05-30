using Gamificacao_02;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gamificacao_02.Promocao;

namespace Gamificação_02
{
    public class PromocaoUI
    {
        public static void GerenciarPromocoes(CarrinhoUI carrinho)
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar promocao");
                Console.WriteLine("2 - Aplicar promocao");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarPromocao();
                        break;
                    case "2":
                        AplicarPromocao(carrinho);
                        break;

                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (continuar);
        }

     
        private static void CadastrarPromocao()
        {
            Console.WriteLine("  |Cadastro de Promocao| ");
            Console.WriteLine("Informe o Tipo da Promocao: ");
            Console.WriteLine("0 - Porcentagem ");
            Console.WriteLine("1 - Valor Fixo ");
            
            int tipo = int.Parse(Console.ReadLine());
            TipoDesconto tipoDesconto = (TipoDesconto)tipo;

            Console.WriteLine("Informe o Valor da Promocao: ");
            double valorDesconto = double.Parse(Console.ReadLine());

            Promocao novaPromocao = new Promocao(valorDesconto, tipoDesconto);

            promocoes.Add(novaPromocao);
        }

        private static void AplicarPromocao(CarrinhoUI carrinho)
        {
          ca
        }


    }
}

