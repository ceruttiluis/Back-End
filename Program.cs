// See https://aka.ms/new-console-template for more information
//Console.Clear();
//Console.WriteLine("Hello, World!");


using ProgBackend.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Cerutti";
novaPF.cpf = "12345678945";

Console.WriteLine(novaPF.nome);
Console.WriteLine(novaPF.cpf);
Console.WriteLine($"----------------------------------------------");

Console.WriteLine($"Nome: {novaPF.nome}  Cpf:  {novaPF.cpf} ");
Console.WriteLine($"----------------------------------------------");


Console.WriteLine("Nome: " +novaPF.nome+  " Cpf: "  +novaPF.cpf+"");

