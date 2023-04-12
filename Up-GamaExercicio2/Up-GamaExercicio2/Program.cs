using System;


namespace Up_GamaExercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do produto");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto");
            Decimal precoProduto = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantida em estoque do produto");
            int quantidadeEstoque = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantida em estoque do produto");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Quantos foram vendidos?");
            int quantidadeVendida =Int32.Parse(Console.ReadLine());

            Console.WriteLine("qual a forma de pagamento?  [1] Cartao [2] Dinheiro ");
            int formaPagamento =Int32.Parse(Console.ReadLine());

            if (quantidadeEstoque >= quantidadeVendida)
            {
                Decimal valorTotal = precoProduto * quantidadeVendida;

                quantidadeEstoque -= quantidadeVendida;

                if (formaPagamento == 2)
                {
                    Console.WriteLine("Qual o valor recebido?");
                    Decimal valorRecebido = Decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"Troco R${valorRecebido - valorTotal}");

                }

                Console.WriteLine("Compra Finalizada");
            }
            else
            {
                Console.WriteLine("Não tem produto em estoque");
            }
        }

    }

}