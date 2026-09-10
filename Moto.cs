// Guilherme Sena - RM 568101
using System;

namespace CatalogoVeiculos
{
    class Moto : Veiculo
    {
        // Propriedade específica da moto
        public int Cilindradas { get; set; }

        // Construtor
        public Moto(string marca, string modelo, int ano, double preco, string cor, int cilindradas)
            : base(marca, modelo, ano, preco, cor)
        {
            Cilindradas = cilindradas;
        }

        // Método
        public override void Apresentar()
        {
            Console.WriteLine($"Moto → {Marca} {Modelo} | Ano: {Ano} | Preço: R$ {Preco:F2} | Cor: {Cor} | Cilindradas: {Cilindradas}cc");
        }
    }
}