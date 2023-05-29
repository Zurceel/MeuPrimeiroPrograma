const string textoOlamundo = "Olá Mundo, esse é meu primeiro programa C#!, feito por ";
string nomeComple;
int idade;

Console.WriteLine("Informe seu nome completo");
nomeComple = Console.ReadLine().ToString();

Console.WriteLine("Informe sua idade");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(textoOlamundo + nomeComple + "que tem " + idade + " anos");