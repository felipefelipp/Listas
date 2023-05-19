//Sets == Conjuntos

//Duas propriedados dos Sets
//1. Não permitem duplicidade
//2. Os elementos nõ são mantidos em ordem específicas

//Declarando set de alunos

using PoderDosSets;


ISet<string> alunos = new HashSet<string>();
alunos.Add("Felipe");
alunos.Add("Vanessa");
alunos.Add("Pedro");
alunos.Add("Rafael");

Console.WriteLine(string.Join(", ", alunos));

alunos.Add("João");
alunos.Add("Paulo");
alunos.Add("José");
alunos.Add("Maria");

Console.WriteLine(string.Join(", ", alunos));


alunos.Remove("Vanessa");
alunos.Add("Marcelo"); // É inserido na mesma posição que o último foi removido
Console.WriteLine(string.Join(", ", alunos));

// Como realizar o Short de um Set
// Set é mais performático que List

List<string> alunosEmLista = new List<string>(alunos);
alunosEmLista.Sort();

Console.WriteLine(string.Join(", ", alunosEmLista));


Curso csharpCollections = new Curso("C# Coleções", "Felipe Freitas");
csharpCollections.Adiciona(new Aula("Trabalhando com listas",21));
csharpCollections.Adiciona(new Aula("Criando uma aula", 20));
csharpCollections.Adiciona(new Aula("Modelando com coleções", 24));

Aluno a1 = new Aluno("Fernando", 12354);
Aluno a2 = new Aluno("Josivaldo", 47896);
Aluno a3 = new Aluno("Fábio", 78956);

csharpCollections.Matricular(a1);
csharpCollections.Matricular(a2);
csharpCollections.Matricular(a3);

Console.WriteLine("Imprimindo os alunos matriculados");

foreach (var aluno in csharpCollections.Alunos)
{
    Console.WriteLine(aluno);
}

Console.WriteLine($"O aluno {a1.Nome} está matrículado?");
Console.WriteLine(csharpCollections.EstaMatriculado(a1));

Aluno tonini = new Aluno("Fernando", 12354);
Console.WriteLine("Tonini está matriculado? " + csharpCollections.EstaMatriculado(tonini));

Console.WriteLine("a1 é Equals a Tonini?");
Console.WriteLine(a1.Equals(tonini));

Console.WriteLine("Quem é o aluno com matrícula 78956");
Aluno aluno78956 = csharpCollections.BuscarMatricula(78956);
Console.WriteLine("Aluno: " + aluno78956);
//Funciona mas não é muito eficiente
//Implementar dicionário para realizar busca


// E se tentarmos adicionar outro aluno com a mesma matrícula 78956?

Aluno fabio = new Aluno("Fabio", 78956);
//csharpCollections.Matricular(fabio);
//E se quisermos trocar o aluno que tem a mesma chave?

csharpCollections.SubstituirAluno(fabio);
Console.WriteLine("Quem é o Aluno 78956 agora?");
Console.WriteLine(csharpCollections.BuscarMatricula(78956));
