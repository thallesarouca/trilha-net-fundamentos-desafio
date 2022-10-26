namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        // inserindo uma nova lista para horas inicial de entrada do veiculo estacionado
        private List<string> hora = new List<string>();
        String horaEntrada;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar (todos os formatos são aceitos, inclusive Mercosul):");
            veiculos.Add(Console.ReadLine());

            //Adicionado, Pedir para o usuário digitar a hora de entrada e armazenar na variável horaEntrada
            // (como referencia para fechar a conta em "Remover veiculos")

            Console.WriteLine("Digite a hora da entrada (ex: 12h00) \n");
            horaEntrada = Console.ReadLine();
            hora.Add(horaEntrada);

             // certificando de armazenar a hora de entrada no ultimo veiculo adicionado
            var lastVeiculo = veiculos.Last();
            Console.WriteLine ($" Placa: {lastVeiculo} ----> Hora: {horaEntrada}, cadastrada \n");
            for (int contador = 0; contador < hora.Count; contador++)
            { }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:\n");
                   
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {  
        
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado \n (somente em números inteiros, sem frações de horas):\n ");

                int horas = 0;
                decimal valorTotal = 0;
                horas = int.Parse(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                // Remover a placa digitada da lista de veículos
               
                veiculos.Remove(placa);
                
                Console.WriteLine($"O veículo: ({placa})--> Foi Removido\nO preço total foi de: R$ {valorTotal}\n");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui ou já foi removido. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados hoje são: \n");
                
                for (int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($"N° {contador} :  Placa: {veiculos[contador] } ---> Hora: {hora[contador]}\n");

                }
                 
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados ou já foram removidos.");
            }
        }












    }
}
