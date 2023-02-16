// See https://aka.ms/new-console-template for more information
//Console.Clear();
//Console.WriteLine("Hello, World!");


using ProgBackend.Classes;

PessoaFisica novaPF = new PessoaFisica();
PessoaJuridica novaPJ = new PessoaJuridica();
Endereco novoEndPF = new Endereco();

//Console.WriteLine(novaPJ.ValidarCnpj("13.902.709/0001-24"));

novaPJ.cnpj = "13.902.709/0001-24";
Console.WriteLine(@$"
CNPJ: {novaPJ.cnpj}
Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}
");

Console.WriteLine($"--------------------------------------------------------");


novaPF.nome = "Cerutti";
novaPF.cpf = "12345678945";
novaPF.rendimento = 7000f;
novaPF.dataNasc = new DateTime(2000/01/01);

// float resultado = novaPF.CalcularImposto(novaPF.rendimento);
// Console.WriteLine(resultado);
// Console.WriteLine($"-------------------------------------------------");
//----------------------------------------------------------------------
DateTime temp = new DateTime(2004,05,08);
// Console.WriteLine(novaPF.ValidarDataNasc(temp));
Console.WriteLine(novaPF.ValidarDataNasc("05/08/2004"));

Console.WriteLine($"-------------------------------------------------");

novoEndPF.Logradouro = "Rua Niteroi";
novoEndPF.numero = 180;
novoEndPF.complemento = "Prédio";
novoEndPF.endComercial = true;

novaPF.endereco = novoEndPF;
Console.WriteLine(@$"
Nome: {novaPF.nome}
Nome da Rua: {novaPF.endereco.Logradouro}, Num: {novaPF.endereco.numero}
Maior de Idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
");


// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine($"----------------------------------------------");
// Console.WriteLine($"Nome: {novaPF.nome}  Cpf:  {novaPF.cpf} ");
// Console.WriteLine($"----------------------------------------------");
// Console.WriteLine("Nome: " +novaPF.nome+  " Cpf: "  +novaPF.cpf+"");
Console.WriteLine($"--------------------------------------------------");

//------------------------------------------------------
// float impostoPagar = novaPJ.CalcularImposto(2000f);
// Console.WriteLine($"R$ {impostoPagar:0.00}");
// Console.WriteLine($"{impostoPagar.ToString("C")}");
//-------------------------------------------------------


