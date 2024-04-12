using System;

string boasVindas = "Bem vinde á Tech School ";
//List<string> listaDosCursos = new List<string> {"Java", "C#", "Python", "PHP", "Go"};

Dictionary<string, List<int>> cursosRegistrados = new Dictionary<string, List<int>>();
cursosRegistrados.Add("Ruby", new List<int> { 10, 6, 8 });
cursosRegistrados.Add("Shell", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

████████╗███████╗░█████╗░██╗░░██╗  ░██████╗░█████╗░██╗░░██╗░█████╗░░█████╗░██╗░░░░░
╚══██╔══╝██╔════╝██╔══██╗██║░░██║  ██╔════╝██╔══██╗██║░░██║██╔══██╗██╔══██╗██║░░░░░
░░░██║░░░█████╗░░██║░░╚═╝███████║  ╚█████╗░██║░░╚═╝███████║██║░░██║██║░░██║██║░░░░░
░░░██║░░░██╔══╝░░██║░░██╗██╔══██║  ░╚═══██╗██║░░██╗██╔══██║██║░░██║██║░░██║██║░░░░░
░░░██║░░░███████╗╚█████╔╝██║░░██║  ██████╔╝╚█████╔╝██║░░██║╚█████╔╝╚█████╔╝███████╗
░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░░╚════╝░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝
");
    Console.WriteLine(boasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar um curso");
    Console.WriteLine("Digite 2 para mostrar todos os cursos");
    Console.WriteLine("Digite 3 para avaliar um curso");
    Console.WriteLine("Digite 4 para exibir a média de um curso");
    Console.WriteLine("Digite -1 para Sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            registrarCursos();
            break;
        case 2:
            mostrarCursosRegistrados();
            break;
        case 3:
            avaliarCursos();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Até Logo!!!");
            break;
        default: Console.WriteLine("Opção Inválida!!");
            break;
    }
}

void registrarCursos()
{
    Console.Clear();
   ExibirTituloDaOpcao("Registro de Cursos");
  
    Console.Write("Digite o nome do Curso que deseja: ");
    string nomeDoCurso = Console.ReadLine()!;
    cursosRegistrados.Add(nomeDoCurso, new List<int>());
    Console.WriteLine($"O {nomeDoCurso} foi registrado!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void mostrarCursosRegistrados()
{
    Console.Clear();
   
    ExibirTituloDaOpcao("Exibindo os Cursos Registrados: ");
   
    foreach (string curso in cursosRegistrados.Keys)
    {
        Console.WriteLine($"Curso de: {curso}");
    }

    Console.WriteLine("\nPressione uma tecla para voltar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void avaliarCursos()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avalie esse curso");
    Console.WriteLine("Digite o nome do Curso que deseja avaliar: ");
    string nomeDoCurso = Console.ReadLine()!;
    if (cursosRegistrados.ContainsKey(nomeDoCurso))
    {
        Console.WriteLine($"Qual nota que o curso {nomeDoCurso} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        cursosRegistrados[nomeDoCurso].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o curso {nomeDoCurso}!!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }  else
    {
        Console.WriteLine($"O curso {nomeDoCurso} não foi encontrado!");
        Console.WriteLine("\nPressione uma tecla para voltar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    
    Console.WriteLine($"Obrigada pela avaliação!!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*') ;
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média do curso");
    Console.WriteLine("Digite o nome do Curso que deseja exibir a média: ");
    string nomeDoCurso = Console.ReadLine()!;
    if (cursosRegistrados.ContainsKey (nomeDoCurso)) 
    {
        List<int> notasDoCurso = cursosRegistrados[nomeDoCurso];
        Console.WriteLine($"\nA média do curso {nomeDoCurso} é {notasDoCurso.Average()}");
        Console.WriteLine("\nPressione uma tecla para voltar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"O curso {nomeDoCurso} não foi encontrado!");
        Console.WriteLine("\nPressione uma tecla para voltar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();