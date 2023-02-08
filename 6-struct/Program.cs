using System;
using Cadastro;

namespace Cadastro{
    struct Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEstoque;
        public DataVenc DataDeVencimento;
    }

    struct DataVenc{
        public int Dia;
        public int Mes;
        public int Ano;
    }
}

class Program 
{
    static void Main(string[] args)
    {
        
        Produto[] xProd = new Produto[2];

        for (int i = 0; i < 2; i++)
        {
            Console.Write($"\nNome do Produto {i+1}: ");
            xProd[i].Nome = Console.ReadLine();

            Console.Write($"Preço do Produto {i+1}: R$");
            xProd[i].Preco = Double.Parse(Console.ReadLine());

            Console.Write($"Quantidade em Estoque do produto {i+1}: ");
            xProd[i].QuantidadeEstoque = int.Parse(Console.ReadLine());

            Console.Write($"Digite a data de vencimento do produto {i+1}: ");
            string dataVencimentoIncluidaUsuario = Console.ReadLine();
            string[] arrayDataVencimento = dataVencimentoIncluidaUsuario.Split("/");
            xProd[i].DataDeVencimento.Dia = int.Parse(arrayDataVencimento[0]);
            xProd[i].DataDeVencimento.Mes = int.Parse(arrayDataVencimento[1]);
            xProd[i].DataDeVencimento.Ano = int.Parse(arrayDataVencimento[2]);
        }
        
        ListarProduto(xProd);

        static void ListarProduto(Produto[] P)
        {
            double NovoPreco;

            Console.Write("\nDigite Preço, para procurar produtos acima do determinado valor: R$");
            NovoPreco = Double.Parse(Console.ReadLine());

            for (int i = 0; i < P.Length; i++)
            {
                if (P[i].Preco > NovoPreco){
                    Console.WriteLine($"\nNome do Produto: {P[i].Nome};\nPreço: R${P[i].Preco};\nQuantidade em Estoque: {P[i].QuantidadeEstoque};\nData de Vencimento: {P[i].DataDeVencimento.Dia}/{P[i].DataDeVencimento.Mes}/{P[i].DataDeVencimento.Ano}.");
                }
            }
        }
    }
}

