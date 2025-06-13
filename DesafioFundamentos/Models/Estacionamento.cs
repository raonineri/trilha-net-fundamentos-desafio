namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// Adiciona um veículo ao estacionamento.
        /// Verifica se o veículo já está estacionado e não permite duplicatas.
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper().Trim() == placa.ToUpper().Trim()))
            {
                Console.WriteLine("Desculpe, esse veículo já está estacionado.");
            }
            else
            {
                // Adiciona o veículo na lista
                veiculos.Add(placa.ToUpper().Trim());
                Console.WriteLine($"O veículo {placa} foi adicionado com sucesso!");
            }
        }

        /// <summary>
        /// Remove um veículo do estacionamento.
        /// Calcula o valor total a ser pago com base no tempo de permanência.
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper().Trim() == placa.ToUpper().Trim()))
            {
                int horas = 0;
                decimal valorTotal = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                string horasVeiculoEstacionado = Console.ReadLine();
                // Verifica se a entrada é um número válido
                if (int.TryParse(horasVeiculoEstacionado, out horas))
                {
                    valorTotal = precoInicial + precoPorHora * horas;
                }
                else
                {
                    Console.WriteLine("Quantidade de horas inválida. O veículo não será removido.");
                    return;
                }
                // Remove o veículo da lista
                veiculos.Remove(placa.ToUpper().Trim());

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        /// <summary>
        /// Lista todos os veículos estacionados.
        /// </summary>
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
