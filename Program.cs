// See https://aka.ms/new-console-template for more information
//Console.Clear();
//Console.WriteLine("Hello, World!");


using ProgBackend.Classes;

Console.Clear();

Utils.BarraCarregamento("Iniciando", 3,".");

string? opcao;
    do {
        Console.WriteLine(@$"

            ========================================================
            |         Bem Vindo ao Sistema de Cadastro             |
            |         de Pessoas Fisicas e Juridicas               |
            ========================================================
            |          Digite o Número da Opção desejada           |
            ========================================================
            |                                                      |
            |               1- Pessoa Fisica                       |
            |               2- Pessoa Juridica                     |
            |               0- Sair                                |
            ========================================================
        ");
opcao = Console.ReadLine();
Thread.Sleep(1000);

        switch (opcao)
        {
            case "1":
                    PessoaFisica novaPF = new PessoaFisica();
                    Endereco novoEndPF = new Endereco();

                    novaPF.nome = "Cerutti";
                    novaPF.cpf = "12345678945";
                    novaPF.rendimento = 7000f;
                    novaPF.dataNasc = new DateTime(2000/01/01);

                    float resultado = novaPF.CalcularImposto(novaPF.rendimento);
                    Console.WriteLine(resultado);

                    DateTime temp = new DateTime(2004,05,08);
                    // Console.WriteLine(novaPF.ValidarDataNasc(temp));
                    Console.WriteLine(novaPF.ValidarDataNasc("05/08/2004"));

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
                    Console.WriteLine($"Para continuar, tecle Enter");
                    Console.ReadLine();
                break;
            case "2":
                    PessoaJuridica novaPJ = new PessoaJuridica();
                    Endereco novoEndPJ = new Endereco();
                    Console.WriteLine(novaPJ.ValidarCnpj("13.902.709/0001-24"));

                    novaPJ.cnpj = "13.902.709/0001-24";
                    Console.WriteLine(@$"
                    CNPJ: {novaPJ.cnpj}
                    Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}
                    ");

                    novoEndPJ.Logradouro = "Rua Sergipe";
                    novoEndPJ.numero = 200;
                    novoEndPJ.complemento = "Prédio";
                    novoEndPJ.endComercial = true;
                    novaPJ.endereco = novoEndPJ;

                    float impostoPagar = novaPJ.CalcularImposto(2000f);
                    Console.WriteLine($"R$ {impostoPagar:0.00}");
                    Console.WriteLine($"{impostoPagar.ToString("C")}");
                    Console.WriteLine($"Para continuar, tecle Enter");
                    Console.ReadLine();

                break;

            case "0":
                    Console.WriteLine($"Obrigado por utilizar nosso sistema");
                    
                break;

            default:
                    Console.WriteLine($"Opção Inválida, digite um valor indicado");
                    Console.WriteLine($"Para continuar, tecle Enter");
                    Console.ReadLine();
            
                break;
        }
    } while (opcao != "0");
    
Utils.BarraCarregamento("Finalizando", 9,"_");








