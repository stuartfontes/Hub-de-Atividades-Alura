
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
            
        case ConsoleKey.D2: Console.WriteLine("Você escolheu a Atividade 2;" +
                                              "\nPara mais informações pressione ENTER\n");
            switch (Console.ReadKey(intercept:true).Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Essa atividade consiste na listagem, soma, subtração, multiplicação e divisão" +
                                      "de todos os números listados pelo usuário;\n");
                    Console.WriteLine("Pressione ENTER para prosseguir para Atividade 2;\n" +
                                      "Pressione BACKSPACE para retornar ao Hub;");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Enter:
                            Console.WriteLine("Prosseguindo para Atividade 2;\nAguarde...");
                            Thread.Sleep(2000);
                            Console.Clear();
                            menuAtividade2();
                            List<float> listaDeNumerosSomar = listas2();
                            somas(listaDeNumerosSomar);
                            subtracao(listaDeNumerosSomar);
                            hubContas();
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
                      " insira seus digitos e posteriormente escolha qual será o número que desja informar na tela\n");
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
                      "A utilização consiste em inserir números que deseja realizar operações matemática;\n");
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
        hubContas();
        

    return dados;
}

void hubContas()
{
    Console.WriteLine("Qual operação matemática deseja realizar?;");
    Console.WriteLine("\nPara Soma pressione 1;");
    Console.WriteLine("Para Subtração pressione 2;");
    Console.WriteLine("Para Multiplicação pressione 3;");
    Console.WriteLine("Para Divisão pressione 4;");
    Console.WriteLine("Para Sair pressione -1;\n");
}
void somas(List<float> numerosAtv2)
{

 ConsoleKeyInfo entrada1Atv2 = Console.ReadKey(intercept: true);

    switch (entrada1Atv2.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("Opção desejada: Somar\n");
            Thread.Sleep(2000);
            Console.Write("Para prosseguir pressione ENTER;\n" +
                          "Para retornar pressione ao Hub de equações pressione BACKSPACE;\n");
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.Enter:
                    
                    Console.Clear();
                    float somas = (numerosAtv2).Sum();
                    Console.WriteLine($"O resultado da operação escolhida é: {somas}\n");
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
                            hubContas();
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
                
                case ConsoleKey.Backspace:  
                    Console.WriteLine("Retornando ao Hub de equações;\nAguarde...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    hubContas();
                    break;
            }
            break;
    }
}

void subtracao(List<float> numerosAtv2)
{
    ConsoleKeyInfo entrada2Atv2 = Console.ReadKey(intercept: true);

    switch (entrada2Atv2.Key)
    {
        case ConsoleKey.D2:
            Console.WriteLine("Opção desejada: Subtrair\n");
            Thread.Sleep(2000);
            Console.Write("Para prosseguir pressione ENTER\n");
            switch (Console.ReadKey(intercept: true).Key)
            {
                case ConsoleKey.Enter:
                    float resultadoSubtracao =  numerosAtv2.Aggregate((x, y) => x - y);
                    Console.Clear();
                    Console.WriteLine($"O resultado da operação escolhida é: {resultadoSubtracao}\n");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine("Para retornar ao Hub de equações pressione ENTER;\n" +
                                      "Para retornar ao Hub Principal pressione BACKSPACE;\n" +
                                      "Para encerrar pressione Q;\n");
                    switch (Console.ReadKey(intercept: true).Key)
                    {
                        case ConsoleKey.Enter:
                            Console.ReadKey(intercept: true);
                            break;
                    }
                    break;
            }

            break;
    }
}
 
 



