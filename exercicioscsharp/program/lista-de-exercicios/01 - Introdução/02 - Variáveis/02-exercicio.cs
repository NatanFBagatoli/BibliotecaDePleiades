public class ExercicioVariaveis2
{
    public static void ExecutarVariaveis2()
    {
        string nome;                // string = texto
        char inicial;               // char = caractere único
        int idade;                  // int = inteiro de 32 bits
        long matricula;             // long = inteiro de 64 bits
        float altura;               // float = números com vírgula 32 bits
        double mediafinal;          // double = números com vírgula 64 bits
        decimal mensalidade;        // decimal = números com vírgula 128 bits
        bool matriculado;           // bool = verdadeiro ou falso
        byte qntddisciplinas;       // inteiro de 0 a 255
        short datadenasc;           // inteiro de -32.768 a 32.767 (2 bytes)
        uint codigoturma;           // inteiro sem sinal, 0 a 4.294.967.295
        ulong idsistema;            // inteiro sem sinal de 64 bits
        sbyte diffidade;            // inteiro de -128 até 127
        ushort maxalunos;           // inteiro sem sinal, 0 a 65.535

        //VariavelX = Console.ReadLine(); => O valor pode ser armazenado em uma variável para ser utilizado posteriormente.
        //Parse serve para converter um texto(string) em outro tipo de dado.

        Console.WriteLine("===== CADASTRO DO ESTUDANTE =====");
        Console.WriteLine();

        Console.Write("Nome: ");
        nome = Console.ReadLine(); 
        Console.WriteLine(); 

        Console.Write("Inicial: ");
        inicial = Console.ReadLine()[0];
        Console.WriteLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Matrícula: ");
        matricula = long.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Altura: ");
        altura = float.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Média final: ");
        mediafinal = double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Mensalidade: R$ ");
        mensalidade = decimal.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Está matriculado? (true/false): ");
        matriculado = bool.Parse(Console.ReadLine());
        Console.WriteLine();
        
        Console.Write("Quantidade de disciplinas: ");
        qntddisciplinas = byte.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Ano de nascimento: ");
        datadenasc = short.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Código da turma: ");
        codigoturma = uint.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Identificador do sistema: ");
        idsistema = ulong.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Diferença de idade: ");
        diffidade = sbyte.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Máximo de alunos: ");
        maxalunos = ushort.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===== DADOS DO ESTUDANTE =====");
        Console.WriteLine();
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Inicial: {inicial}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Matrícula: {matricula}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Média final: {mediafinal}");
        Console.WriteLine($"Mensalidade: R$ {mensalidade}");
        Console.WriteLine($"Está matriculado?: {matriculado}");
        Console.WriteLine($"Quantidade de disciplinas: {qntddisciplinas}");
        Console.WriteLine($"Ano de nascimento: {datadenasc}");
        Console.WriteLine($"Código da turma: {codigoturma}");
        Console.WriteLine($"Identificador do sistema: {idsistema}");
        Console.WriteLine($"Diferença de idade: {diffidade}");
        Console.WriteLine($"Máximo de alunos: {maxalunos}");
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadLine();
    }
}