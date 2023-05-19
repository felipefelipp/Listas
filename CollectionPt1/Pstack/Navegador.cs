public class Navegador
{
    private readonly Stack<string> historicoAnterior = new Stack<string>();

    private string atual = "vazia";
    public Navegador()
    {
        Console.WriteLine("Página atual: " + atual); 
    }

    internal void Anterior()
    {
        if(historicoAnterior.Any())
        {
            atual = historicoAnterior.Pop();
            Console.WriteLine("Página atual: " + atual);
        }
    }

    internal void NavegarPara(string url)
    {
        historicoAnterior.Push(atual);
        atual = url;
        Console.WriteLine("Página atual: " + atual);
    }
}