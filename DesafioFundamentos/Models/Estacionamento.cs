namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        // Uma vez que é utilizada em diferentes métodos com a mesma função, a string "placa" foi declarada pública aqui
        public string placa;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Criado um método para leitura de placa, uma vez que há repetição na solicitação da informação.
        public void LerPlaca()
        {
            placa = "";
            placa = Console.ReadLine().ToUpper();
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a estacionar:");

            // Lê a placa do veículo
            LerPlaca();
            // Adiciona a placa informada à lista de veículos
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a remover:");

            // Lê a placa do veículo
            LerPlaca();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0; 

                // Solicita a quantidade de horas em que o veículo ficou estacionado.
                horas = Convert.ToInt32(Console.ReadLine());
                // Calcula a tarifa do estacionamento
                valorTotal = precoInicial + precoPorHora * horas;

                // Remove a placa digitada
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}.");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()

        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Laço de repetição para listar veículos estacionados
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
