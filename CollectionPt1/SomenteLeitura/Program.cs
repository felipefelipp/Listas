using SomenteLeitura;

Curso csharpCollecoes = new Curso("C# Collections", "Felipe Freitas");
csharpCollecoes.Adiciona(new Aula("Trabalhando com listas", 21));
csharpCollecoes.Adiciona(new Aula("Criando uma aula", 20));
csharpCollecoes.Adiciona(new Aula("Modelando com coleções", 15));


//csharpCollecoes.Aulas.Sort(); IList não possui o método Sort()

// Copiar IList Aulas para List aulasCopiadas
ImprimirAulas(csharpCollecoes.Aulas);

List<Aula> aulas = new List<Aula>(csharpCollecoes.Aulas);

// Ordenar a cópia
aulas.Sort();

ImprimirAulas(aulas);

//Totalizar o tempo do curso
Console.WriteLine(csharpCollecoes.TempoTotal);


Console.WriteLine(csharpCollecoes);






static void ImprimirAulas(IList<Aula> aulas)
{
    //Console.Clear();
    foreach (Aula aula in aulas)
    {
        Console.WriteLine(aula);    
    }

    Console.WriteLine("\n");
}