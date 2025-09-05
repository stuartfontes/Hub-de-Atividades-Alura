
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


MenuGeral();
hub();

// Atividade 1 - Escrever  um programa que dado a entrada de dados de um número N inteiro, a partir do teclado
// exibir a n-ésima posição de uma lista (baseado na escolha do usuário)
void menuAtividade1()
{
    Console.WriteLine("Seja bem vindo a Atividade n°1, será breve e irá entregar uma lista," +
                      "insira seus digitos e posteriormente escolha qual será o número que desja informar na tela\n");
}

List<float> listas()
{
    Console.Write("Insira sua lista de números, lembre de separa-las por um espaço:\n ");
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
        Console.WriteLine($"O número na posição {n} é: {numerosAtv1[n - 1]}");
        Console.WriteLine("Pressione ENTER para gerar outra lista\nPressione BACKSPACE para retornar ao Hub;");
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
                    hub();
                    break;
                        
                case ConsoleKey.Q:
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Console.WriteLine("Pressione qualquer tecla para encerrar o Programa;\n");
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
                    hub();
                    break;
                        
                case ConsoleKey.Q:
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Console.WriteLine("Pressione qualquer tecla para encerrar o Programa;\n");
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
                    hub();
                    break;
                        
                case ConsoleKey.Q:
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Console.WriteLine("Pressione qualquer tecla para encerrar o Programa;\n");
                    Console.ReadKey(intercept: true);
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
                    hub();
                    break;
                case ConsoleKey.Q:
                    (string linkedin, string gitHub) = LNKGTH();
                    Console.WriteLine("Encerrando o programa;\nAguarde...");
                    Console.WriteLine("Agradeço a utilização, para feedbacks e/ou sugestoes acesse;\n");
                    Console.WriteLine($"{linkedin}");
                    Console.WriteLine($"{gitHub}");
                    Console.WriteLine("Pressione qualquer tecla para encerrar o Programa;\n");
                    Console.ReadKey(intercept: true);
                    break;
            }
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
            Console.WriteLine("Para visualizar seu usário e senha pressione ENTER;\n" +
                          "Para retornar ao Hub de Atividades pressione BACKSPACE;\n" +
                          "Para sair do programa pressione Q;\n");
            usuarioSenha[usuario] = senha2;
            switch (Console.ReadKey().Key)
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
                    Console.WriteLine("Pressione qualquer tecla para encerrar o Programa;\n");
                    Console.ReadKey(intercept: true);
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

string usuarioCadastrado = login();
