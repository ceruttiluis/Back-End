// See https://aka.ms/new-console-template for more information
//Console.Clear();
//Console.WriteLine("Hello, World!");


using ProgBackend.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Cerutti";
novaPF.cpf = "12345678945";
novaPF.rendimento = 7000f;
float resultado = novaPF.CalcularImposto(novaPF.rendimento);
Console.WriteLine(resultado);

// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine($"----------------------------------------------");

// Console.WriteLine($"Nome: {novaPF.nome}  Cpf:  {novaPF.cpf} ");
// Console.WriteLine($"----------------------------------------------");


// Console.WriteLine("Nome: " +novaPF.nome+  " Cpf: "  +novaPF.cpf+"");

PessoaJuridica novaPJ = new PessoaJuridica();
float impostoPagar = novaPJ.CalcularImposto(2000f);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"{impostoPagar.ToString("C")}");



