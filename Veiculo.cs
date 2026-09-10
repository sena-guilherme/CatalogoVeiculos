// Guilherme Sena - RM
using System;

namespace CatalogoVeiculos
{
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public string Cor { get; set; }

        // Construtor padrão
        public Veiculo(string marca, string modelo, int ano, double preco, string cor)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Preco = preco;
            Cor = cor;
        }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Marca: {Marca} | Modelo: {Modelo} | Ano: {Ano} | Preço: R$ {Preco:F2} | Cor: {Cor}");
        }
    }
}