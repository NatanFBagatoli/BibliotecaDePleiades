public class ExercicioVariaveis
{
    public static void Executar2()
    {

        string nome = "Natan";          //string = texto
        char inicial = 'N';             //char = caractere unico
        int idade = 22;                 //int = inteiro de 32 bits
        long matricula = 123456789;     //long = inteiro de 64 bits
        float altura = 1.80f;           //float = numeros com virgula 32bits
        double mediafinal = 8.5;        //double = numeros com virgula 64bits
        decimal mensalidade = 476.90m;  //decimal = numeros com virgula 128bits
        bool matriculado = true;        //bool = verdadeiro ou falso
        byte qntddisciplinas = 6;       //inteiro de 0 a 255
        short datadenasc = 2004;        //inteiro de -32.768 a 32.767(2bytes)
        uint codigoturma = 3434;        //inteiro sem sinal, 0 a 4.294.967.295
        ulong idsistema = 9876543210;   //inteiro sem sinal de 64 bits
        sbyte diffidade = -2;           //inteiro de -128 até 127
        ushort maxalunos = 46;          //inteiro sem sinal, 0 a 65.535

        Console.WriteLine("===== CADASTRO DO ESTUDANTE =====");
        Console.WriteLine();
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Inicial: {inicial}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Matrícula: {matricula}");
        Console.WriteLine($"Altura: {altura} m");
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

        //Console.Write(); escreve uma mensagem no console
        //Console.WriteLine(); escreve uma mensagem no console e pula uma linha
        //Console.ReadLine(); le uma linha digitada pelo usuário e retorna como string dentro de uma variável estipulada
        //$ = tudo entre {} é substituido pelo valor da variável
        
        }
    }


