using System;
using System.Collections.Generic;
class Program {
    static readonly List<Tarefa> tarefas = [];

    static void Main(string[] args) {

        while (true) {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Listar Tarefas");
            Console.WriteLine("3. Marcar Tarefa como Concluída");
            Console.WriteLine("4. Remover Tarefa");
            Console.WriteLine("5. Sair");

            string opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    AdicionarTarefa();
                    break;
                case "2":
                    ListarTarefas();
                    break;
                case "3":
                    if (tarefas == null || tarefas.Count == 0) {
                        Console.WriteLine("Não há tarefas na lista, crie uma tarefa primeiro.");
                        break;
                    }
                    else {
                        Console.WriteLine("Informe o título da tarefa");
                        string nome = Console.ReadLine();
                        Tarefa.MarcarComoConcluida(tarefas, nome);
                        break;
                    }
                case "4":
                    Console.WriteLine("Informe o título da tarefa");
                    string titulo = Console.ReadLine();
                    RemoverTarefa(titulo);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        static void AdicionarTarefa() {
            Console.Write("Crie um título para sua tarefa: ");
            string nome = Console.ReadLine();
            Tarefa novaTarefa = new(nome);
            tarefas.Add(novaTarefa);

            Console.WriteLine("Tarefa adicionada com sucesso!");
        }
        static void ListarTarefas() {
            if (tarefas == null || tarefas.Count == 0) {
                Console.WriteLine("Não há tarefas na lista, crie uma tarefa primeiro.");
            }
            else {
                foreach (var tarefa in tarefas) {
                    Console.WriteLine(tarefa);
                }
            }
        }
        static void RemoverTarefa(string titulo) {
            if (tarefas == null || tarefas.Count == 0) {
                Console.WriteLine("Não há tarefas na lista, crie uma tarefa primeiro.");
            }
            else {
                tarefas.RemoveAll(t => t.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("Tarefa removida com sucesso!");
            }
        }
    }
}
