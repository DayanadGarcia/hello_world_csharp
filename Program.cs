class Program
{
  public static void Main(string[] args)
  {
    // Hello, World!
    Console.WriteLine("Hello, World!");


    // Leitura de dados
    Console.Write("Digite seu nome: ");
    string name = Console.ReadLine();


    // template string/concatenação
    Console.WriteLine($"Olá, {name}!!");


    // operação básica
    Console.Write("Digite o ano do seu nascimento: ");
    int year = int.Parse(Console.ReadLine());
    int age = 2022 - year;
    Console.WriteLine($"Pelo que observei aqui {name}, você deve completar {age} anos esse ano!");


    // condicional if else
    if (age >= 18) {
      Console.WriteLine("Você é maior de idade.");
    } else {
      Console.WriteLine("Você é menor de idade.");
    }


    // array
    string[] names = { "Dayana", "Miguel", "Noah" };


    // loop for
    for (int i = 0; i < names.Length; i++)
    {
      Console.WriteLine(names[i]);
    }


    // foreach
    foreach (string n in names)
    {
      Console.WriteLine(n);
    }


    // métodos de string
    string person = "Freddy";

    Console.WriteLine(person.Length);
    Console.WriteLine(person.EndsWith("dy"));
    Console.WriteLine(person.Contains("e"));
    Console.WriteLine(person.StartsWith("F"));
    Console.WriteLine(person.IndexOf("d"));


    string[] persons = {"Batata", "Batatinha", "Batatinhazinha"};

    Console.WriteLine(string.Join('-', persons));
  }
}
