
List<string> frutas = new List<string> 
{
    "abacate", "banana", "caqui", "damasco", "figo"
};

foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}


Console.WriteLine("Adicionando uma nova lista ligada (LINKED LIST)");
LinkedList<string> dias = new LinkedList<string>();
var d4 = dias.AddFirst("quarta");
Console.WriteLine("d4.Values: " + d4.Value);
var d2 = dias.AddBefore(d4,"segunda");
// linked list não ordena os itens, ele utiliza um nó para ter a referencia do item anterior
var d3 = dias.AddAfter(d2, "terça");

var d6 = dias.AddAfter(d4, "sexta");

var d7 = dias.AddAfter(d6, "sabado");

var d5 = dias.AddAfter(d6, "quinta");

var d1 = dias.AddAfter(d2, "domingo");

foreach (var dia in dias)
{
    Console.WriteLine(dia);
}

// LinkedList não dá suporte através de indice: dias[0]
// Por isso não podemos usar o for

var quarta = dias.Find("quarta");
Console.WriteLine(quarta.Value);


dias.Remove("quarta");
dias.Remove(d5);

Console.WriteLine("\n\n\n");

foreach (var dia in dias)
{
    Console.WriteLine(dia);
}