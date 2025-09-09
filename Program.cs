
(string linkedin, string gitHub) LNKGTH()

{
    string linkedin = $"https://www.linkedin.com/in/mauricio-stuart-fontes-83b45318a";
    string gitHub = $"https://github.com/stuartfontes";
    return (linkedin, gitHub);
}
void MenuGeral(){
Console.WriteLine(@"
█░█ █░█ █▄▄   █▀▄ █▀▀   ▄▀█ ▀█▀ █ █░█ █ █▀▄ ▄▀█ █▀▄ █▀▀ █▀
█▀█ █▄█ █▄█   █▄▀ ██▄   █▀█ ░█░ █ ▀▄▀ █ █▄▀ █▀█ █▄▀ ██▄ ▄█");

Console.WriteLine("\nEsse é o menu geral de atividades da Alura\n" +
                  "Foram realizadas por mim e transformadas em um Hub para melhor visualição\n" +
                  "Acesse as redes;\n");
(string linkedin, string gitHub) = LNKGTH(); 
    Console.WriteLine($"Linkedin: {linkedin}\n" +
                      $"GitHub: {gitHub}\n");
    
    
 
}

void hub()
{
    Console.WriteLine("Digito 1: Acessar a atividade 'Exibindo n-ésima posição em lista'\n");
    Console.WriteLine("Digito 2: Acessar a atividade 'Calculador de números em Lista'\n");
    Console.WriteLine("Digito 3: Acessar a atividade 'Sistema de Login e Senha'\n");
    Console.WriteLine("Digito 4: Acessar projeto geral 'Curso C# - Alura'\n");

    switch (Console.ReadKey(intercept: true).Key)
    {
        case ConsoleKey.D1: Console.WriteLine("Você escolheu a Atividade 1;" +
                                              "\nPara mais informações pressione ENTER\n");
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Essa atividade consiste em uma lista de números escolhidos pelo usuário" +
                                      "que irá ser visualizada pós finalização e, então, escolhido uma posição" +
                                      "de escolha do usuário para ser visualizada\n");
                    Console.WriteLine("Pressione Enter para prosseguir para Atividade n°1;" +
                                      "\nPressione BACKSPACE para retornar ao Hub;");
                    switch (Console.ReadKey(intercept:true).Key)
                    {
                        case ConsoleKey.Enter:
                            Console.WriteLine("Prosseguindo para Atividade n°1;\nAguarde...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            menuAtividade1();
                            List<float> listaDeNumeros = listas();
                            posicoes(listaDeNumeros);
                            break;
                        case ConsoleKey.Backspace:
                            Console.WriteLine("Retornando ao Hub;\nAguarde...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            MenuGeral();
                            hub();
                            break;
                        default:
                            Console.WriteLine("\nErro: Caracter inválido;\nPressione ENTER ou BACKSPACE;" +
                                              "\nRetornando ao Hub;\nAguarde...");
                            MenuGeral();
                            hub();
                            break;
                            
                    }
                    Thread.Sleep(2000);
                    Console.Clear();
              
                    break;
               default:
                   Console.WriteLine("\nErro: Caracter inválido;\nPressione ENTER ou BACKSPACE;" +
                                     "\nRetornando ao Hub;\nAguarde...");
                   hub();
                   break;
            }  
            break;
            
        case ConsoleKey.D2: 
            Console.WriteLine("Você escolheu a Atividade 2;" +
                                              "\nPara mais informações pressione ENTER\n");
            switch (Console.ReadKey(intercept:true).Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Essa atividade consiste na listagem, soma, subtração, multiplicação e divisão" +
                                      "de todos os números listados pelo usuário;\n");
                    Console.WriteLine("Pressione ENTER para prosseguir para Atividade 2;\n" +
                                      "Pressione BACKSPACE para retornar ao Hub;");
                    switch (Console.ReadKey(intercept: true).Key)
                    {
                        case ConsoleKey.Enter:
                            Console.WriteLine("Prosseguindo para Atividade 2;\nAguarde...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            menuAtividade2();
                            List<float> listaDeNumerosSomar = listas2();
                            somas(listaDeNumerosSomar);
                            subtracao(listaDeNumerosSomar);
                            multiplicacao(listaDeNumerosSomar);
                            hubContas(listaDeNumerosSomar);
                            break;
                        case ConsoleKey.Backspace:
                            Console.WriteLine("Retornando ao Hub;\nAguarde...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            hub();
                            break;
                    }
                    break;
            }
            
            Thread.Sleep(2000);
            Console.Clear();
            break;
        
        case ConsoleKey.D3:
            Console.WriteLine("Você escolheu a Atividade 3;" +
                              "\nPara mais informações pressione ENTER\n");
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Essa atividade simula um sistema de Login, que salva Usuários e senhas através" +
                                      "de uma função Dictionary\n");
                    Console.WriteLine("Pressione ENTER para prosseguir para Atividade 3;" +
                                      "\nPressione BACKSPACE para retornar ao Hub;");
                    switch (Console.ReadKey(intercept: true).Key)
                    {
                        case ConsoleKey.Enter:
                            Console.WriteLine("Prosseguindo para Atividade 3;\nAguarde...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            menuAtividade3();
                            string usuarioCadastrado = login();
                            break;
                    }
                    
                break;
            }
            break;
        
        case ConsoleKey.D4:
            Console.WriteLine("Você escolheo o Projeto  Geral - Curso C# - Alura;" +
                              "\nPara mais informaçes pressione ENTER\n");
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("O projeto chamado StuartFy é um introdutório da linguagem, nele você Cadastra" +
                                      "avalia e exibe a média das avaliações feitas;\n");
                    Console.WriteLine("Pressione ENTER para prosseguir para o Projeto Geral - Curso C# - Alura;" +
                                      "\nPressione BACKSPACE para retornar ao Hub;");
                    switch (Console.ReadKey(intercept: true).Key)
                    {
                        case ConsoleKey.Enter:
                            Console.WriteLine("Prosseguindo para o Projeto Geral;\nAguarde...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Exibir_menu();
                            break;
                    }
                    break;       
            }

            break;
        
        default:
            Console.WriteLine("\nErro: Caracter inválido;\nPressione ENTER ou BACKSPACE;" +
                              "\nRetornando ao Hub;\nAguarde...");
            Thread.Sleep(2000);
            Console.Clear();
            MenuGeral();
            hub();
            break;
    }
}


// Atividade 1 - Escrever  um programa que dado a entrada de dados de um número N inteiro, a partir do teclado
// exibir a n-ésima posição de uma lista (baseado na escolha do usuário)
void menuAtividade1()
{
    Console.WriteLine("Seja bem vindo a Atividade n°1, será breve e irá entregar uma lista," +
                      "insira seus digitos e posteriormente escolha qual será o número que desja informar na tela\n");
}

List<float> listas()
{
    Console.Write("Insira sua lista de números, lembre de separa-las por um espaço:\n");
    string entrada = Console.ReadLine();
    string entradaSemEspaço = entrada.Trim();
        
    List<float> numerosAtv1 = entradaSemEspaço
        .Split(" ")
        .Select(float.Parse)
        .ToList();
        

    Console.WriteLine("Você digitou os seguintes números: "+string.Join(" ",numerosAtv1)); 
    
    
    return numerosAtv1;
    
}

void posicoes(List<float> numerosAtv1)

{
    Console.Write("Insira a posição que deseja visualizar na lista: ");
    int n = int.Parse(Console.ReadLine());

    if (n > 0 && n <= numerosAtv1.Count)
    {
        Console.WriteLine($"\nO número na posição {n} é: {numerosAtv1[n - 1]}");
        Console.WriteLine("Pressione ENTER para gerar outra lista\nPressione BACKSPACE para retornar ao Hub;\n");
        switch (Console.ReadKey(intercept: true).Key)
        {
            case ConsoleKey.Enter:
                Console.WriteLine("Gerando novas listas;\nAguarde...");
                Thread.Sleep(2000);
                Console.Clear();
                menuAtividade1();
                List<float> listaDeNumeros = listas();
                posicoes(listaDeNumeros);
                break;
            case ConsoleKey.Backspace:
                Console.WriteLine("Retornando ao Hub;\nAguarde...");
                Thread.Sleep(2000);
                Console.Clear();
                MenuGeral();
                hub();
                break;
            default:
                Console.WriteLine("\nErro: Caractere inválido;\nPressione ENTER ou BACKSPACE;" +
                                  "\nRetornando a Atividade n°1;\nAguarde...");
                Thread.Sleep(2000);
                Console.Clear();
                menuAtividade1();
                break;
        }
        
    }
    else
    {
        Console.WriteLine("Posição inválida\nDigite uma posição válida baseada na quantidade de números digitados;\n");
        posicoes(numerosAtv1);
    }    
    
    
}


// Atividade 2 - Criar um programa que calcula as quatro operações de todos os elementos inteiros de uma lista, 
// utilizando a interpolação de Strings 

void menuAtividade2()
{

    Console.WriteLine("Seja bem vindo a Atividade n°2;\n" +
                      "A utilização consiste em inserir números que deseja para realizar operações matemáticas;\n" +
                      "Como: Soma, Subtração, Multiplicação e Divisão.\n");
}


List<float> listas2()

{
    Console.Write("Insira os números que deseja somar/subtrair/multiplicar e dividir: ");
     string numerosAtv2 = Console.ReadLine().Trim();
    List<float> dados = numerosAtv2
        .Split(" ")
        .Select(float.Parse)
        .ToList();
    Console.WriteLine("Você digitou os seguintes números: "+string.Join(" ",dados)); 
        Thread.Sleep(2000);
        hubContas(dados);
        

    return dados;
}

void hubContas(List<float> numerosAtv2)
{
    Console.WriteLine("Qual operação matemática deseja realizar?;");
    Console.WriteLine("\nPara Soma pressione 1;");
    Console.WriteLine("Para Subtração pressione 2;");
    Console.WriteLine("Para Multiplicação pressione 3;");
    Console.WriteLine("Para Divisão pressione 4;");
    Console.WriteLine("Para Sair pressione Q;\n");

    switch (Console.ReadKey(intercept: true).Key)
    {
        case ConsoleKey.D1:
            somas(numerosAtv2);
            break;
        case ConsoleKey.D2:
            subtracao(numerosAtv2);
            break;
        case ConsoleKey.D3:
            multiplicacao(numerosAtv2);
            break;
        case ConsoleKey.D4:
            divisao(numerosAtv2);
            break;
        case ConsoleKey.Q:
            (string linkedin, string gitHub) = LNKGTH();
            Console.WriteLine("Encerrando...");
            Console.WriteLine($"Linkedin: {linkedin}\nGitHub: {gitHub}");
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente!");
            hubContas(numerosAtv2);
            break;
    }
}
void somas(List<float> numerosAtv2)
{
    Console.WriteLine("Opção desejada: Somar\n");
    Thread.Sleep(2000);
    Console.Write("Para prosseguir pressione ENTER;\n" +
                  "Para retornar ao Hub de equações pressione BACKSPACE;\n");
    
    switch (Console.ReadKey(intercept: true).Key)
    {
        case ConsoleKey.Enter:
                    
            Console.Clear();
            float somas2 = (numerosAtv2).Sum();
            Console.WriteLine($"O resultado da operação escolhida é: {somas2}\n");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Para retornar ao Hub de equações pressione ENTER;\n" +
                                      "Para retornar ao Hub Principal pressione BACKSPACE;\n" +
                                      "Para encerrar pressione Q;\n");
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.Enter:
                    Console.Write("Retornando ao Hub de equações;\nAguarde...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    hubContas(numerosAtv2);
                    break;
                        
                case ConsoleKey.Backspace:
                    Console.WriteLine("Retornando ao Hub Principal;\nAguarde...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MenuGeral();
                    hub();
                    break;
                        
                case ConsoleKey.Q:
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Environment.Exit(0);
                    break;
            }
            break;
                
        case ConsoleKey.Backspace:  
            Console.WriteLine("Retornando ao Hub de equações;\nAguarde...");
            Thread.Sleep(2000);
            Console.Clear();
            hubContas(numerosAtv2);
            break;
    }
}


void subtracao(List<float> numerosAtv2)
{
    Console.WriteLine("Opção desejada: Subtrair\n");
    Thread.Sleep(2000);
    Console.Write("Para prosseguir pressione ENTER\n" +
                  "Para retornar ao Hub de equações pressione BACKSPACE;\n");
    switch (Console.ReadKey(intercept: true).Key)
    {
        case ConsoleKey.Enter:
            Console.Clear();
            float resultadoSubtracao =  numerosAtv2.Aggregate((x, y) => x - y);
            Console.WriteLine($"O resultado da operação escolhida é: {resultadoSubtracao}\n");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Para retornar ao Hub de equações pressione ENTER;\n" +
                                      "Para retornar ao Hub Principal pressione BACKSPACE;\n" +
                                      "Para encerrar pressione Q;\n");
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.Enter:
                    Console.Write("Retornando ao Hub de equações;\nAguarde...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    hubContas(numerosAtv2);
                    break;
                        
                case ConsoleKey.Backspace:
                    Console.WriteLine("Retornando ao Hub Principal;\nAguarde...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MenuGeral();
                    hub();
                    break;
                        
                case ConsoleKey.Q:
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Environment.Exit(0);
                    break;
            }
            break;
                
        case ConsoleKey.Backspace:  
            Console.WriteLine("Retornando ao Hub de equações;\nAguarde...");
            Thread.Sleep(2000);
            Console.Clear();
            hubContas(numerosAtv2);
            break;
    }
}

void multiplicacao(List<float> numerosAtv2)
{
    Console.WriteLine("Opção desejada: Multiplicar\n");
    Thread.Sleep(2000);
    Console.Write("Para prosseguir pressione ENTER\n" +
                  "Para retornar ao Hub de equações  pressione BACKSPACE;\n");
    
    switch (Console.ReadKey(intercept: true).Key)
    {
        case ConsoleKey.Enter:
                        
            Console.Clear();
            float resultadoMultiplicacao =  numerosAtv2.Aggregate((x, y) => x * y);
            Console.WriteLine($"O resultado da operação escolhida é: {resultadoMultiplicacao}\n");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Para retornar ao Hub de equações pressione ENTER;\n" +
                                      "Para retornar ao Hub Principal pressione BACKSPACE;\n" +
                                      "Para encerrar pressione Q;\n");
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.Enter:
                    Console.Write("Retornando ao Hub de equações;\nAguarde...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    hubContas(numerosAtv2);
                    break;
                        
                case ConsoleKey.Backspace:
                    Console.WriteLine("Retornando ao Hub Principal;\nAguarde...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MenuGeral();
                    hub();
                    break;
                        
                case ConsoleKey.Q:
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Environment.Exit(0);
                    break;
            } break;
                
        case ConsoleKey.Backspace:  
            Console.WriteLine("Retornando ao Hub de equações;\nAguarde...");
            Thread.Sleep(2000);
            Console.Clear();
            hubContas(numerosAtv2);
            break;
                
     }
}

void divisao(List<float> numerosAtv2)
{
    Console.WriteLine("Opção desejada: Divisão\n");
    Thread.Sleep(2000);
    Console.Write("Para prosseguir pressione ENTER\n" +
                  "Para retornar ao Hub de equações  pressione BACKSPACE;\n");
    switch (Console.ReadKey(intercept: true).Key)
    {
        case ConsoleKey.Enter:
            Console.Clear();
            float resultadoDivisao =  numerosAtv2.Aggregate((x, y) => x / y);
            Console.WriteLine($"O resultado da operação escolhida é: {resultadoDivisao}\n");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Para retornar ao Hub de equações pressione ENTER;\n" +
                              "Para retornar ao Hub Principal pressione BACKSPACE;\n" +
                              "Para encerrar pressione Q;\n");
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.Enter:
                    Console.Write("Retornando ao Hub de equações;\nAguarde...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    hubContas(numerosAtv2);
                    break;
                case ConsoleKey.Backspace:
                    Console.WriteLine("Retornando ao Hub Principal;\nAguarde...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MenuGeral();
                    hub();
                    break;
                case ConsoleKey.Q:
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Environment.Exit(0);
                    break; 
            } break;
                
        
        case ConsoleKey.Backspace:  
            Console.WriteLine("Retornando ao Hub de equações;\nAguarde...");
            Thread.Sleep(2000);
            Console.Clear();
            hubContas(numerosAtv2);
            break;

    }
    
}

// Atividade 3 - Criar um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

void menuAtividade3()
{
    Console.WriteLine("Bem vindo a atividade N°3\n" +
                      "\nO sistema irá criar uma função de dicionário que armazenará Login e Senha do usuário\n" +
                      "Utilizada em partes de sistema de proteção a dados e cadastro de usuários;\n");
}

Dictionary<string, string> usuarioSenha = new Dictionary<string, string>();

string login()
{
    Thread.Sleep(4000);
    Console.Clear();
    Console.WriteLine("\nCadastre o nome de Usuário:\n" +
                  "\nPara melhor segurança siga conforme instruções:\n" +
                  "1.Utilize letras maiúsculas e minúsculas;\n" +
                  "2.Não utilize caracteres especiais;\n" +
                  "3.Minimo de 5 digitos para o Login de usuário\n");
    Console.Write("Cadastre o usuário: ");
    string usuario;
    while (true)
    {
        usuario = Console.ReadLine();
        bool caracterEspecial = usuario.Any(c => !char.IsLetterOrDigit(c));
        bool tamanho = usuario.Length >= 5;
        bool maiuscula = usuario.Any(Char.IsUpper);
        bool minuscula = usuario.Any(Char.IsLower);
        
        if (!usuarioSenha.ContainsKey(usuario) && !caracterEspecial && tamanho && minuscula && maiuscula)
        {
            usuarioSenha.Add(usuario,"");
            Console.Write($"\nO usuário {usuario} foi cadastrado com sucesso: \n" +
                          $"Próxima etapa: Cadastre sua senha;\n");
            Thread.Sleep(2000);
            Console.Clear();
            senha(usuarioSenha, usuario);
            return usuario;
        }
    
        else if (caracterEspecial)
        {
            Console.WriteLine($"O usuário {usuario} possui caracter especial;\nTente novamente.\n");
            Thread.Sleep(2000);
            Console.Clear();
            return login();
        
        }
        else if (!tamanho)
        {
            Console.WriteLine($"O usuário {usuario} não possui o mínimo de digitos necessários;" +
                              $"Acrescente a quantidade de dígitos e tente novamente.\n");
            Thread.Sleep(2000);
            Console.Clear();
            return login();
        }
        else if (!maiuscula)
        {
            Console.WriteLine($"O usuário {usuario} não possui letras maiúsculas." +
                              $"Acrescente letras maiúsculas e tente novamente.\n");
            Thread.Sleep(2000);
            Console.Clear();
            return login();
        }
        else if (!minuscula)
        {
            Console.WriteLine($"O usuário {usuario} não possui letras minúsculas." +
                              $"Acrescente letras minúsculas e tente novamente.\n");
            Thread.Sleep(2000);
            Console.Clear();
            return login();
        }
        else
        {
            Console.WriteLine($"O usuário {usuario} já está cadastrado;\nTente novamente.\n");
            Thread.Sleep(2000);
            Console.Clear();
            return login();
        }
    }
}

void senha(Dictionary<string, string> usuarioSenha, string usuario)

{
    Console.Write($"Cadastre sua senha:\n" +
                  "\nPara melhor segurança siga conforme instruções:\n" +
                  "1. Utilize letras maiúsculas e minúsculas;\n" +
                  "2. Utilize caracteres especiais(Ex:!,@,#,$,%,^,&,*,)\n" +
                  "3. Mínimo de 10 digitos para a Senha de usuário;\n");
    string senha2;
    Console.Write("\nDigite sua senha: ");
    while (true)
    {
        senha2 = Console.ReadLine();
        bool caracterEspecial = senha2.Any(c => !char.IsLetterOrDigit(c));
        bool tamanho = senha2.Length >= 10;
        bool maiuscula = senha2.Any(char.IsUpper);
        bool minuscula = senha2.Any(char.IsLower);
        
        if (caracterEspecial && tamanho && maiuscula && minuscula)
        {
            Console.WriteLine($"\nA senha {senha2} foi gerada com sucesso.\n" +
                              $"Não entregue seu Usuário e Senha à ninguém;\n" +
                              $"Nossa equipe em nenhuma hipótese irá pedir dados de cadastro;\n");
            Console.WriteLine("Para visualizar seu último usuário e senha pressione ENTER;\n" +
                              "Para visualizar todos os usuários e senhas cadastrados pressione Z;\n" +
                          "Para retornar ao Hub de Atividades pressione BACKSPACE;\n" +
                          "Para sair do programa pressione Q;\n");
            usuarioSenha[usuario] = senha2;
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine($"Seu usuário cadastrado é: {usuario}\n" +
                                      $"Sua senha cadastrada é: {senha2}\n");
                    Console.WriteLine("Para retornar  ao Hub de Atividades pressione ENTER;\n" +
                                      "Para cadastrar novos usuários pressione BACKSPACE;\n");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Enter:
                            Console.WriteLine("Retornando ao Hub de atividades;\nAguarde...\n");
                            Thread.Sleep(2000);
                            Console.Clear();
                            hub();
                            break;
                        case ConsoleKey.Backspace:
                            Console.WriteLine("Cadastrando novos usuários.\nAguarde...\n");
                            Thread.Sleep(2000);
                            Console.Clear();
                            login();
                            senha(usuarioSenha, usuario);
                            break;
                    }
                    break;

                case ConsoleKey.Z:
                {
                    void todosOsCadastros(Dictionary<string, string> usuarios)
                    {
                        Console.Clear();
                        Thread.Sleep(2000);
                        if (usuarios.Count == 0)
                        {
                            Console.WriteLine("Não há nenhum usuário cadastrado;\nTente novamente e insira novos usuários;\n");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else
                        {
                            foreach (var cadastros in usuarios)
                            {
                                Console.WriteLine("Identificando todos os usuários cadastrados;\nAguarde...\n");
                                Console.WriteLine($"Usuário:{cadastros.Key}: {cadastros.Value}");
                                Thread.Sleep(5000);
                                Console.Clear();
                            }
                        }
                    }
                    break;
                }
                case ConsoleKey.Backspace:
                {
                    Console.WriteLine("Retornando ao Hub de Atividades;\nAguarde...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    MenuGeral();
                    hub();
                    break;
                }
                case ConsoleKey.Q:
                {
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Environment.Exit(0);
                    break;
                }
            }
        }    
        else if (!caracterEspecial)
        {
            Console.WriteLine($"A senha {senha2} não possui caracteres especiais.\n" +
                              $"Inclua caracter especial e tente novamente.\n");
            Thread.Sleep(2000);
            Console.Clear();
            senha(usuarioSenha, usuario);
        }
        else if (!tamanho)
        {
            Console.WriteLine($"A senha {senha2} não possui tamanho adequado.\n" +
                              $"Inclua a quantidade necessária e tente novamente.\n");
            Thread.Sleep(2000);
            Console.Clear();
            senha(usuarioSenha, usuario);
        }
        else if (!maiuscula)
        {
            Console.WriteLine($"A senha {senha2} não possui letras maiúsculas.\n" +
                              $"Inclua letras maíusculas e tente novamente.\n");
            Thread.Sleep(2000);
            Console.Clear();
            senha(usuarioSenha, usuario);
        }
        else if (!minuscula)
        {
            Console.WriteLine($"A senha {senha2} não possui letras minúsculas.Qn" +
                              $"Inclua letras minúsculas e tente novamente.\n");
            Thread.Sleep(2000);
            Console.Clear();
            senha(usuarioSenha, usuario);
        }
        
    }
}



void todosOsCadastros(Dictionary<string, string> usuarios)
{
    Console.Clear();
    Thread.Sleep(2000);
    if (usuarios.Count == 0)
    {
        Console.WriteLine("Não há nenhum usuário cadastrado;\nTente novamente e insira novos usuários;\n");
        Thread.Sleep(2000);
        Console.Clear();
    }
    else
    {
        foreach (var cadastros in usuarios)
        {
            Console.WriteLine("Identificando todos os usuários cadastrados;\nAguarde...\n");
            Console.WriteLine($"Usuário:{cadastros.Key}: {cadastros.Value}");
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}

// Projeto geral StuartFy - Curso C# Alura: É um sistema que introduz e avalia bandas, foi feito para introduzir à linguagem

void menuProjetoGeral()
{
    Console.WriteLine("Bem vindo ao projeto Geral\n" +
                      "\nO sistema consiste em Introduzir, avaliar e realizar a média de avaliações de cada banda\n" +
                      "Foi feito com base no curso introdutório de C# da Alura\n");
}

string mensagemDeInicio = "\nBoas vindas ao StuartFy, um aplicativo de músicas teste baseado em aprendizados de C#.";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗████████╗██╗░░░██╗░█████╗░██████╗░████████╗███████╗██╗░░░██╗
██╔════╝╚══██╔══╝██║░░░██║██╔══██╗██╔══██╗╚══██╔══╝██╔════╝╚██╗░██╔╝
╚█████╗░░░░██║░░░██║░░░██║███████║██████╔╝░░░██║░░░█████╗░░░╚████╔╝░
░╚═══██╗░░░██║░░░██║░░░██║██╔══██║██╔══██╗░░░██║░░░██╔══╝░░░░╚██╔╝░░
██████╔╝░░░██║░░░╚██████╔╝██║░░██║██║░░██║░░░██║░░░██║░░░░░░░░██║░░░
╚═════╝░░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░░░░░░░╚═╝░░░");
    Console.WriteLine(mensagemDeInicio);
}

void Exibir_menu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite: 1 para registrar uma banda;");
    Console.WriteLine("Digite: 2 para mostrar todas as bandas;");
    Console.WriteLine("Digite: 3 para avaliar uma banda;");
    Console.WriteLine("Digite: 4 para exibir a média de avaliações de uma banda;");
    Console.WriteLine("Digite: -1 para sair;");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhida2 = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhida2)
    {
        case 1: RegistrarBanda();
            break;
        case 2: mostrarBandasRegistradas();
            break;
        case 3: avaliarUmaBanda();
            break;
        case 4: mediaDeBandas();
            break;
        case -1:Console.WriteLine("Para encerrar todo o Programa pressione BACKSPACE;\n" +
                                  "Para retornar ao Hub geral pressione ENTER;");
            Console.ReadKey();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Backspace:
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Environment.Exit(0);
                    break;
                
                case ConsoleKey.Enter:
                    Console.WriteLine("Retornando ao Hub Geral;\nAguarde...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    hub();
                    break;
                    
            }

            break;
        default: Console.WriteLine("Error 1: Opção inválida");
            break;
    
    }
}

    void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro das Bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso" +
                          $"\nRetornando ao menu;" +
                          $"\nAguarde...");
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Thread.Sleep(2000);
        Console.Clear();
        Exibir_menu();
    }

    void mostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo as bandas registradas");
  
        Console.WriteLine("\nAs bandas registradas são\n");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"{banda}\n");
        }
        Thread.Sleep(2000);
        Console.WriteLine("Pressione uma tecla para retornar ao Menu: ");
        Console.ReadKey();
        Console.Clear();
        Exibir_menu();

    }

    void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.Write(asteriscos + "\n");
        Console.Write(titulo + "\n");
        Console.Write(asteriscos + "\n");
    }

    void avaliarUmaBanda()
    {

        Console.Clear();
        ExibirTituloDaOpcao("Avaliar bandas registradas");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.WriteLine($"A banda {nomeDaBanda} foi selecionada com sucesso;");
        Console.WriteLine("Iniciando avaliação da banda;\n");
        Thread.Sleep(2000);
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Qual a nota deseja atribuir a banda {nomeDaBanda}: ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.Write($"Registrando nota {nota};\nAguarde...\n");
            Thread.Sleep(2000);
            Console.Write($"A nota {nota} foi registrada para a banda {nomeDaBanda}");
            Thread.Sleep(5000);
            Console.Clear();
            Exibir_menu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada:");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal;");
            Console.ReadKey();
            Console.Clear();
            Exibir_menu();
        }
    }

    void mediaDeBandas()
    {
    Console.Clear();
    ExibirTituloDaOpcao("Media de bandas registradas");
    Console.Write("\nDigite o nome da banda que deseja visualizar a média de avaliações: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A banda {nomeDaBanda} foi escolhida com sucesso;\n");
        Thread.Sleep(2000);
        Console.WriteLine($"Canculando a média de avaliações da banda {nomeDaBanda};\nAguarde...\n");
        Thread.Sleep(2000);
        Console.Clear();
        Console.Write($"A média de notas da banda {nomeDaBanda}: é {notas.Average()}");
        Console.WriteLine("Pressione ENTER para retornar ao Hub geral;\n" +
                          "Pressione BACKSPACE para retornar ao Hub do Projeto;\n" +
                          "Pressione Q para encerrar o programa;\n");
        Console.ReadKey();
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Enter:
                Console.WriteLine("Retornando ao Hub Geral;\nAguarde...\n");
                Thread.Sleep(2000);
                Console.Clear();
                hub();
                break;
            
            case ConsoleKey.Backspace:
                Console.WriteLine("Retornando ao Hub do Projeto;\nAguarde...\n");
                Thread.Sleep(2000);
                Console.Clear();
                Exibir_menu();
                break;
            
            case ConsoleKey.Q:
                (string linkedin, string gitHub) = LNKGTH();
                Console.WriteLine("Encerrando o programa;\nAguarde...");
                Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                Console.WriteLine($"{linkedin}");
                Console.WriteLine($"{gitHub}");
                Environment.Exit(0);
                break; 
        }
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada:");
        Console.WriteLine("Pressione ENTER para retornar ao Hub do projeto;\n" +
                          "Pressione BACKSPACE para retornar ao Hub Geral;\n");
        Console.ReadKey();
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Enter:
                Console.WriteLine("Retornando ao Hub do Projeto;\n" +
                                  "Aguarde...\n");
                Thread.Sleep(2000);
                Console.Clear();
                Exibir_menu();
                break;
            case ConsoleKey.Backspace:
                Console.WriteLine("Retornando ao Hub Geral;\n" +
                                  "Aguarde...\n");
                Thread.Sleep(2000);
                Console.Clear();
                hub();
                break;
        }
    }
    }
    
    MenuGeral();
    hub();
