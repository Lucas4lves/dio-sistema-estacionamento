namespace DIO.Models 
{
    using System.Collections.Generic;
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private decimal faturamento = 0;

        private List<string> veiculosCadastrados = new List<string>();

        public Estacionamento (decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }


        public void CadastrarVeiculo()
            {
                string placa = "";
                Console.WriteLine("Digite a placa do veículo: ");
                placa = Console.ReadLine();
                this.veiculosCadastrados.Add(placa.ToUpper());
            }

        public void RemoverVeiculo(string veiculoARemover)
        {            
            if (this.veiculosCadastrados.Any(x => x.ToUpper() == veiculoARemover)){
                this.veiculosCadastrados.Remove(veiculoARemover);
                this.MostrarPrecoFinal(this.precoInicial, this.precoPorHora);
            } else {
                Console.WriteLine("A placa inserida não consta no sistema. Favor tentar novamente");
                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                Console.ReadLine();
            }
        }

        public void MostrarVeiculosCadastrados() 
            {
                if(this.veiculosCadastrados.Count < 1)
                    Console.WriteLine("Não há veículos estacionados no momento.");
                 else 
                    Console.WriteLine("Lista de veiculos estacionados: ");
                    foreach(var veiculo in this.veiculosCadastrados)
                    {
                        Console.WriteLine(veiculo);
                    }
                Console.WriteLine("");
            }


        public void MostrarPrecoFinal(decimal precoInicial, decimal precoPorHora)
        {
            Console.WriteLine("Quantas horas o veículo ficou estacionado?");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"O preço a ser pago pelo cliente é de R$: {this.precoInicial + this.precoPorHora * horas}");
            faturamento += this.precoInicial + this.precoPorHora * horas;
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadLine();
        }

        public void MostrarFaturamento()
        {
            Console.WriteLine($"O faturamento do dia foi de R$: {this.faturamento}");
        }


    }
}
