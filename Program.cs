// Guilherme Sena - RM 568101
using System;
using System.Collections.Generic;

namespace CatalogoVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista tipada pela classe mãe
            List<Veiculo> veiculos = new List<Veiculo>();

            Console.WriteLine("=== CADASTRO DE MOTOS ===\n");

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine($"--- Cadastro #{veiculos.Count + 1} ---");

                // --- MARCA (não pode ficar em branco) ---
                string marca;
                while (true)
                {
                    Console.Write("Marca: ");
                    marca = Console.ReadLine()?.Trim();
                    if (string.IsNullOrEmpty(marca))
                    {
                        Console.WriteLine("A marca não pode ficar em branco. Tente novamente.");
                        continue;
                    }
                    break;
                }

                // --- MODELO (não pode ficar em branco) ---
                string modelo;
                while (true)
                {
                    Console.Write("Modelo: ");
                    modelo = Console.ReadLine()?.Trim();
                    if (string.IsNullOrEmpty(modelo))
                    {
                        Console.WriteLine("O modelo não pode ficar em branco. Tente novamente.");
                        continue;
                    }
                    break;
                }

                // --- ANO (numérico com try/catch) ---
                int ano;
                while (true)
                {
                    Console.Write("Ano: ");
                    try
                    {
                        ano = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida. Digite apenas números para o ano.");
                    }
                }

                // --- PREÇO (numérico com try/catch) ---
                double preco;
                while (true)
                {
                    Console.Write("Preço (ex: 15000.50): ");
                    try
                    {
                        preco = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida. Digite apenas números para o preço.");
                    }
                }

                // --- COR (não pode ficar em branco) ---
                string cor;
                while (true)
                {
                    Console.Write("Cor: ");
                    cor = Console.ReadLine()?.Trim();
                    if (string.IsNullOrEmpty(cor))
                    {
                        Console.WriteLine("A cor não pode ficar em branco. Tente novamente.");
                        continue;
                    }
                    break;
                }

                // --- CILINDRADAS (numérico com try/catch) ---
                int cilindradas;
                while (true)
                {
                    Console.Write("Cilindradas (ex: 160): ");
                    try
                    {
                        cilindradas = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida. Digite apenas números para as cilindradas.");
                    }
                }

                // Cria o objeto Moto
                Moto moto = new Moto(marca, modelo, ano, preco, cor, cilindradas);
                veiculos.Add(moto);

                Console.WriteLine("\n✅ Cadastrado com sucesso!\n");

                // Pergunta se deseja cadastrar outro
                while (true)
                {
                    Console.Write("Deseja cadastrar outro? (s/n): ");
                    string resposta = Console.ReadLine()?.Trim().ToLower();
                    if (resposta == "s")
                    {
                        Console.WriteLine();
                        break;
                    }
                    else if (resposta == "n")
                    {
                        continuar = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite 's' para sim ou 'n' para não.");
                    }
                }
            }

            // --- LISTAGEM FINAL ---
            Console.WriteLine("\n========================================");
            Console.WriteLine("       MOTOS CADASTRADAS");
            Console.WriteLine("========================================\n");

            foreach (Veiculo v in veiculos)
            {
                v.Apresentar();  // Polimorfismo: chama o override de Moto
            }

            Console.WriteLine($"\nTotal de motos cadastradas: {veiculos.Count}");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}