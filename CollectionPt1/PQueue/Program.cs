class Program
{
    static Queue<string> pedagio = new Queue<string>();

    static void Main(string[] args)
    {

        Enfileirar("van");
        Enfileirar("kombi");
        Enfileirar("guincho");
        Enfileirar("picape");
        Desenfileirar();
    }

    private static void Desenfileirar()
    {
        string veiculo = pedagio.Dequeue();
        Console.WriteLine($"\nSaiu da fila: {veiculo}");
        ImprimirFila();

    }

    private static void Enfileirar(string veiculo)
    {
        Console.WriteLine($"\nEntrou na fila: {veiculo}");
        pedagio.Enqueue(veiculo);
        ImprimirFila();
    }

    private static void ImprimirFila()
    {
        Console.WriteLine("\n********* FILA *********");
        foreach (var v in pedagio)
        {
            Console.WriteLine(v);
        }
    }
}


