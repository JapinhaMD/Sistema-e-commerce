using Gamificacao_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificação_02
{
    public class CarrinhoUI
    {
          public CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

        public void MenuCarrinho()
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Adicionar Item");
                Console.WriteLine("2 - Retirar Item");
                Console.WriteLine("3 - Vizualizar Carrinho");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                       
                        AdicionarItem(carrinho);
                        break;
                    case "2":
                        RetirarItem(carrinho);
                        break;
                    case "3":
                        carrinho.MostrarCarrinho();
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
            } while (continuar);
        }



        private void AdicionarItem(CarrinhoDeCompras carrinho)
        {
            Console.Clear();
            foreach (var produtos in Program.produtos)
            {
                Console.WriteLine($"ID: {produtos.ProdutoID} | Nome: {produtos.Nome} | Preço: {produtos.Preco} | Categoria: {produtos.CategoriaModel.Nome}");
            }
            Console.WriteLine("Digite o ID do produto que deseja adicionar ao carrinho: ");

            int idProduto = int.Parse(Console.ReadLine());

            ProdutoModel produto = Program.produtos.Find(p => p.ProdutoID == idProduto);

            if (produto.ProdutoID == null)
            {
                Console.WriteLine("Produto não encontrado.");
            }
            else
            {
                carrinho.AdicionarProduto(produto);
                Console.WriteLine("Produto adicionado ao Carrinho!");
            }
        }

        private void RetirarItem(CarrinhoDeCompras carrinho)
        {
            Console.Clear();
            Console.Write("Digite o ID do produto a ser retirado: ");
            int idProduto = int.Parse(Console.ReadLine());

            bool itemRemovido = carrinho.RemoverProduto(idProduto);

            if (itemRemovido)
            {
                Console.WriteLine("Produto removido do carrinho!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado no carrinho.");
            }
        }

    }
}
    

            
        
