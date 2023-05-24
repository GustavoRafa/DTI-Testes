using System.Runtime.CompilerServices;
using System.Collections;
using System;


Dictionary<DateTime, List<string>> lembretes = new Dictionary<DateTime, List<string>>();

while (true)
{
    Console.WriteLine("Bem vindo ao app de Lembretes! (Feito por Gustavo Rafá Pinheiro da Silva):");
    Console.WriteLine();
    Console.WriteLine("Opções:");
    Console.WriteLine();
    Console.WriteLine("1. Adicionar lembrete");
    Console.WriteLine("2. Listar lembretes");
    Console.WriteLine("3. Deletar lembrete");
    Console.WriteLine("Caso deseja sair do programa, digite 0");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    if (IsNumero(opcao))
    {
        switch (opcao)
        {
            case "1":
                AdicionarLembrete(lembretes);
                break;
            case "2":
                ListarLembretes(lembretes);
                break;
            case "3":
                DeletarLembrete(lembretes);
                break;
            case "0":
                Console.WriteLine("Encerrando o programa...");
                return;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Opção inválida. Insira somente números.");
    }

    //Função para adicionar lembretes
    static void AdicionarLembrete(Dictionary<DateTime, List<string>> lembretes)
    {
        Console.WriteLine("Digite o lembrete:");
        string nomeLembrete = Console.ReadLine();

        Console.WriteLine("Digite a data (formato: dd/mm/aaaa):");
        string dataString = Console.ReadLine();

        if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
        {
            if (data < DateTime.Today)
            {
                Console.WriteLine("Data inválida. A data deve ser a partir do futuro.");
                return;
            }

            if (lembretes.ContainsKey(data))
            {
                lembretes[data].Add(nomeLembrete);
            }
            else
            {
                lembretes[data] = new List<string> { nomeLembrete };
            }

            Console.WriteLine("Lembrete adicionado com sucesso.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Data inválida. Certifique-se de inserir a data no formato correto (dd/mm/aaaa).");
        }
    }

    //Função para listar os lembretes
    static void ListarLembretes(Dictionary<DateTime, List<string>> lembretes) {
            Console.WriteLine();
            Console.WriteLine("Lista de Lembretes");
            Console.WriteLine();

            foreach (var data in lembretes.OrderBy(data => data.Key))
            {
                Console.WriteLine("Data: " + data.Key.ToString("dd/MM/yyyy"));

                foreach (string lembrete in data.Value)
                {
                    Console.WriteLine("Lembrete: " + lembrete);
                }

                Console.WriteLine();
            }
    }

    //Função para deletar os lembretes
    static void DeletarLembrete(Dictionary<DateTime, List<string>> lembretes)
    {
        Console.Write("Digite a data do lembrete que deseja deletar (formato: dd/mm/aaaa): ");
        string dataString = Console.ReadLine();

        if (DateTime.TryParseExact(dataString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
        {
            if (lembretes.ContainsKey(data))
            {
                List<string> lembretesData = lembretes[data];

                Console.WriteLine("Lembretes disponíveis para a data especificada:");
                for (int i = 0; i < lembretesData.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {lembretesData[i]}");
                }

                Console.Write("Digite o número do lembrete que deseja deletar: ");
                if (int.TryParse(Console.ReadLine(), out int lembreteIndex) && lembreteIndex >= 1 && lembreteIndex <= lembretesData.Count)
                {
                    lembretesData.RemoveAt(lembreteIndex - 1);

                    if (lembretesData.Count == 0)
                    {
                        lembretes.Remove(data);
                    }

                    Console.WriteLine("Lembrete deletado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Índice inválido. Nenhum lembrete foi deletado.");
                }
            }
            else
            {
                Console.WriteLine("Não há lembretes para a data especificada.");
            }
        }
        else
        {
            Console.WriteLine("Data inválida. Certifique-se de inserir a data no formato correto (dd/mm/aaaa).");
        }
    }

    //Verificar se o input das opções são numero 
    static bool IsNumero(string input)
    {
        return int.TryParse(input, out _);
    }
}