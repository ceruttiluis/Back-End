// See https://aka.ms/new-console-template for more information
//Console.Clear();
//Console.WriteLine("Hello, World!");


using ProgBackend.Classes;

Console.Clear();

Utils.BarraCarregamento("Iniciando", 3,".");
Console.Clear();

List<PessoaFisica> listaPF = new List<PessoaFisica>();
List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();

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
                    PessoaFisica metodoPF = new PessoaFisica();
                    string? opcaoPF;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(@$"

                        ========================================================
                        |         Bem Vindo ao Sistema de Cadastro             |
                        |         de Pessoas Fisicas e Juridicas               |
                        ========================================================
                        |          Digite o Número da Opção desejada           |
                        ========================================================
                        |                                                      |
                        |               1- Cadastrar Pessoa Física             |
                        |               2- Mostrar Pessoas Físicas             |
                        |               0- Voltar ao menu anterior              |
                        ========================================================
                        ");
                        opcaoPF = Console.ReadLine();
                        switch (opcaoPF)
                        {
                            case "1":
                            Console.Clear();
                            Endereco novoEndPF = new Endereco();
                            PessoaFisica novaPF = new PessoaFisica(); 
                            Console.WriteLine($"Digite o Nome da pessoa física que deseja cadastrar");
                            novaPF.nome = Console.ReadLine();

                            bool dataValida;
                            do
                            {
                                Console.WriteLine($"Digite a data de nascimento");
                                string dataNasc = Console.ReadLine();

                                dataValida = metodoPF.ValidarDataNasc(dataNasc);

                                if (dataValida)
                                {
                                    novaPF.dataNasc = dataNasc;
                                } else {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine($"Data Inválida, pore favor digite uma data valida.");
                                    Console.ResetColor();
                                }     
                            } while (dataValida == false);

                            Console.WriteLine($"Digite o número de CPF");                                                
                            novaPF.cpf = Console.ReadLine();

                            Console.WriteLine($"Digite o Rendimento mensal(apenas números)");
                            novaPF.rendimento = float.Parse(Console.ReadLine());

                            Console.WriteLine($"Digite o Logradouro");
                            novoEndPF.Logradouro = Console.ReadLine();

                            Console.WriteLine($"Digite o número");
                            novoEndPF.numero = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Digite o complemento(aperte ENTER para vazio)");
                            novoEndPF.complemento = Console.ReadLine();

                            Console.WriteLine($"Este endereço é comercial?S ou N");
                            string endCom = Console.ReadLine().ToUpper();
                            if (endCom == "S")
                            {
                                novoEndPF.endComercial = true;
                            } else {
                                novoEndPF.endComercial = false;
                            }                            
                            novaPF.endereco = novoEndPF;
                            listaPF.Add(novaPF);
                            metodoPF.Inserir(novaPF);
                            // listaPF.Add(novaPF);

                            using (StreamWriter sw = new StreamWriter($"{novaPF.nome}.txt"))
                            {
                                sw.WriteLine(novaPF.nome);
                                sw.WriteLine(novaPF.dataNasc);
                                sw.WriteLine(novaPF.cpf);
                                sw.WriteLine(novaPF.rendimento);
                                sw.WriteLine(novoEndPF.Logradouro);
                                sw.WriteLine(novoEndPF.numero);
                                sw.WriteLine(novoEndPF.complemento);
                                sw.WriteLine(novoEndPF.endComercial);
                            }

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Cadastro realizado com sucesso!");
                            Console.ResetColor();

                                break;
                            case "2":
                                Console.Clear();
                                if (listaPF.Count > 0)
                                {
                                    List<PessoaFisica> ListaPF = metodoPF.Ler();
                                    foreach (PessoaFisica cadaItem in listaPF)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(cadaItem.ValidarDataNasc("05/08/2004"));
                                        Console.WriteLine(@$"
                                        Nome: {cadaItem.nome}
                                        Cpf: {cadaItem.cpf}
                                        Rendimento: {cadaItem.rendimento.ToString("C")}
                                        Nome da Rua: {cadaItem.endereco.Logradouro}, Num: {cadaItem.endereco.numero}
                                        Endereço Comercial?:{(((bool)cadaItem.endereco.endComercial)?"SIM" : "NÂO")}
                                        Impostos á pagar:{cadaItem.CalcularImposto(cadaItem.rendimento).ToString("C")}
                                        ");
                                        Console.WriteLine($"Para continuar, tecle Enter");
                                        Console.ReadLine();
                                    }
                                } else {
                                    Console.WriteLine($"Lista Vazia");
                                    Thread.Sleep(3000);
                                }

                                using (StreamReader sr = new StreamReader("LuisCerutti.txt"))
                                {
                                    string linha;
                                    while((linha = sr.ReadLine()) != null)
                                    {
                                        Console.WriteLine($"{linha}");
                                    }
                                }
                                Console.WriteLine($"Aperte ENTER para continuar");
                                Console.ReadLine();
                                break;
                            case "0":
                                Console.Clear();
                                break;    
                            default:
                                Console.Clear();
                                Console.WriteLine($"Opção Invalida, por favor digite outra opção!");
                                Thread.Sleep(3000);
                                break;
                        }
                        
                    } while (opcaoPF != "0");
                    
                     break;
            case "2":
                    PessoaJuridica metodoPJ = new PessoaJuridica();
                    string? opcaoPJ;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(@$"

                        ========================================================
                        |         Bem Vindo ao Sistema de Cadastro             |
                        |         de Pessoas Fisicas e Juridicas               |
                        ========================================================
                        |          Digite o Número da Opção desejada           |
                        ========================================================
                        |                                                      |
                        |               1- Cadastrar Pessoa Juridica           |
                        |               2- Mostrar Pessoas Juridicas           |
                        |               0- Voltar ao menu anterior             |
                        ========================================================
                        ");
                        opcaoPJ = Console.ReadLine();
                        switch (opcaoPJ)
                        {
                            case "1":
                            Console.Clear();
                            PessoaJuridica novaPJ = new PessoaJuridica();    
                            Endereco novoEndPJ = new Endereco();
                            // novaPJ.nome = "Novapj";
                            // novaPJ.cnpj = "00.000.000/0001-00";
                            // novaPJ.razaoSocial = "razao";
                            //  metodoPJ.Inserir(novaPJ);
                            Console.WriteLine($"Digite o nome da pessoa Juridica que deseja cadastrar");
                            novaPJ.nome = Console.ReadLine();
                           
                            Console.WriteLine($"Digite seu Cnpj");
                            novaPJ.cnpj = Console.ReadLine();
                            Console.WriteLine(novaPJ.ValidarCnpj(novaPJ.cnpj));

                            Console.WriteLine($"Digite sua Razão Social");
                            novaPJ.razaoSocial = Console.ReadLine();

                            Console.WriteLine($"Digite seu Rendimento Mensal");
                            novaPJ.rendimento = float.Parse(Console.ReadLine());

                            Console.WriteLine($"Digite o Logradouro");
                            novoEndPJ.Logradouro = Console.ReadLine();

                            Console.WriteLine($"Digite o Número");
                            novoEndPJ.numero = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Digite o Complemento(aperte ENTER para vazio)");
                            novoEndPJ.complemento = Console.ReadLine();

                            Console.WriteLine($"Este Endereço é comercial?S ou N");
                            string endCom = Console.ReadLine().ToUpper();
                            if (endCom == "S")
                            {
                                novoEndPJ.endComercial = true;
                            } else {
                                novoEndPJ.endComercial = false;
                            }
                            novaPJ.endereco = novoEndPJ;
                            listaPJ.Add(novaPJ);
                            metodoPJ.Inserir(novaPJ);

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Cadastro realizado com sucesso!");
                            Console.ResetColor();


                                break;
                            case "2":
                                Console.Clear();
                                if (listaPJ.Count > 0)
                                {
                                    List<PessoaJuridica> ListaPJ = metodoPJ.Ler();
                                    foreach (PessoaJuridica cadaItem in listaPJ)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(@$"
                                        Nome: {cadaItem.nome}
                                        CNPJ: {cadaItem.cnpj}
                                        Valido: {cadaItem.ValidarCnpj(cadaItem.cnpj)}
                                        Razão Social: {cadaItem.razaoSocial}
                                        Rendimento: {cadaItem.rendimento.ToString("C")}
                                        Nome da Rua: {cadaItem.endereco.Logradouro}, Num: {cadaItem.endereco.numero}
                                        Endereço Comercial?: {(((bool)cadaItem.endereco.endComercial)?"SIM" : "NÃO")}
                                        Impostos á Pagar: {cadaItem.CalcularImposto(cadaItem.rendimento).ToString("C")}
                                        ");
                                        Console.WriteLine($"Para continuar, tecle Enter");
                                        Console.ReadLine();
                                    }
                                } else {
                                    Console.WriteLine($"Lista Vazia");
                                    Thread.Sleep(3000);
                                }
                                break;
                            case "0":
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine($"Opção Invalida, por favor digite outra opção!");
                                Thread.Sleep(3000);
                                break;
                        }
                    }while (opcaoPJ != "0");
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




// float impostoPagar = cadaPessoa.CalcularImposto(2000f);
// Console.WriteLine($"R$ {impostoPagar:0.00}");
//  Console.WriteLine(cadaPessoa.ValidarCnpj("13.902.709/0001-24"));
//  novaPJ.cnpj = "13.902.709/0001-24";







