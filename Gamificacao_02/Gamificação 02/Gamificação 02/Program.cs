// See https://aka.ms/new-console-template for more information
using Gamificacao_02;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Gamificação_02;


public class Program
{

    public static List<ProdutoModel> produtos = new List<ProdutoModel>();
    public static List<CategoriaModel> categorias = new List<CategoriaModel>();
    static void Main(string[] args)
    {
        
       
        CarrinhoUI carrinhoUI = new CarrinhoUI();

        bool continuar = true;
        do
        {

            Console.WriteLine("    |Menu Principal|");
            Console.WriteLine("");
            Console.WriteLine("1 - Gerenciar Produtos");
            Console.WriteLine("2 - Gerenciar Categorias");
            Console.WriteLine("3 - Carrinho de Compras");
            Console.WriteLine("4 - Promoçoes");
            Console.WriteLine("0 - Sair");



            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":

                    new ProdutoUI().GerenciarProdutos();
                    break;


                case "2":

                    new CategoriaUI().MenuDeFuncionalidades();
                    break;


                case "3":

                    carrinhoUI.MenuCarrinho();
                    break;

                case "4":
                    PromocaoUI.GerenciarPromocoes(carrinhoUI);
                    break;

                case "0":
                    continuar = false;
                    break;
            }
        } while (continuar);


        carrinhoUI.carrinho.MostrarCarrinho();
    
       
    }
}










