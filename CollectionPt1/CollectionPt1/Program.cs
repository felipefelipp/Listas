var aulaIntro = new Aula("Introdução às coleções", 20);
var aulaModelando = new Aula("Modelando a classe aula", 18);
var aulaSets = new Aula("Trabalhando com conjuntos", 16);



static void ImprimirArray(string[] aulas)
{
    for (int i = 0; i < aulas.Length; i++)
    {
        Console.WriteLine(aulas[i]);
    }
    Console.WriteLine("\n");
}

static void ImprimirList(List<string> aulas)
{
    aulas.ForEach(aula => { Console.WriteLine(aula); });
    Console.WriteLine("\n");
}

static void ImprimirAulas(List<Aula> aulas)
{
    aulas.ForEach(aula => { Console.WriteLine(aula); });
    Console.WriteLine("\n");
}

static void ManipularArray(string aulaIntro, string aulaModelando, string aulaSets)
{
    string[] aulas = new string[]
    {
    aulaIntro,
    aulaModelando,
    aulaSets
    };

    ImprimirArray(aulas);

    Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
    Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

    Array.Reverse(aulas);
    ImprimirArray(aulas);

    Array.Reverse(aulas);
    ImprimirArray(aulas);

    Array.Resize(ref aulas, 2); //Reduzir o tamanho do array
    ImprimirArray(aulas);

    Array.Resize(ref aulas, 3);
    ImprimirArray(aulas);

    Array.Sort(aulas); //Ordenar em ordem alfabética
    ImprimirArray(aulas);

    string[] copia = new string[2];
    Array.Copy(aulas, 1, copia, 0, 2);
    ImprimirArray(copia);


    string[] clone = aulas.Clone() as string[];
    ImprimirArray(clone);

    Array.Clear(clone, 0, clone.Length);
    ImprimirArray(clone);
}

static void ManipularLista(string aulaIntro, string aulaModelando, string aulaSets)
{
    List<string> aulas = new List<string>();
    aulas.Add(aulaIntro);
    aulas.Add(aulaModelando);
    aulas.Add(aulaSets);
    ImprimirList(aulas);
    Console.WriteLine("A primeira aula é: " + aulas[0]);
    Console.WriteLine("A primeira aula é: " + aulas.First());
    Console.WriteLine("A última aula é: " + aulas[aulas.Count() - 1]);
    Console.WriteLine("A última aula é: " + aulas.Last());
    Console.WriteLine("Primeira aula 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));
    Console.WriteLine("Primeira aula 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));
    Console.WriteLine("A primeira 'Conclusão' é: " + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

    aulas.Reverse();
    ImprimirList(aulas);

    aulas.RemoveAt(aulas.Count() - 1);
    ImprimirList(aulas);

    aulas.Add("Conclusão");
    ImprimirList(aulas);

    aulas.Sort();
    ImprimirList(aulas);

    List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
    ImprimirList(copia);

    List<string> clone = new List<string>(aulas);
    ImprimirList(clone);

    clone.RemoveRange(clone.Count - 2, 2);
    ImprimirList(clone);
 }

static void ManipularListaObjetos(Aula aulaIntro, Aula aulaModelando, Aula aulaSets)
{
    List<Aula> aulas = new List<Aula>();
    aulas.Add(aulaIntro);
    aulas.Add(aulaModelando); 
    aulas.Add(aulaSets);
    // aulas.Add("Conclusão");
    ImprimirAulas(aulas);
    aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo)); //Posso definir o que será comparado ou criar meu próprio algorítmo de ordenação
    ImprimirAulas(aulas);
    aulas.Sort(); // Utilizou a interface IComparable e implementou o método CompareTo com o algorítmo de comparação que eu decidir
}



class Aula : IComparable
{
    private string titulo;
    private int tempo;

    public Aula(string titulo, int tempo)
    {
        this.titulo = titulo;
        this.tempo = tempo;
    }

    public string Titulo { get => titulo; set => titulo = value; }
    public int Tempo { get => tempo; set => tempo = value; }

    public int CompareTo(object? obj)
    {
        Aula aula = obj as Aula;
        return this.Titulo.CompareTo(aula.Titulo);
    }

    public override string ToString()
    {
        return $"[Título: {Titulo}, tempo: {Tempo} minutos]";
    }
}