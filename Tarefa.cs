using System.Diagnostics;

public class Tarefa {
    public string Titulo { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(string titulo) {
        Titulo = titulo;
        Concluida = false;
    }

    public static void MarcarComoConcluida(List<Tarefa> tarefas, string titulo) {
        Tarefa tarefa = tarefas.Find(t => t.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (tarefa != null) {
            tarefa.Concluida = true;
            Console.WriteLine($"Tarefa '{titulo}' foi marcada como concluída.");
        }
        else 
            Console.WriteLine($"Tarefa com o título '{titulo}' não foi encontrada.");
    }

    public override string ToString() {
        return $"{Titulo} - {(Concluida ? "Concluída" : "Pendente")}";
    }
}