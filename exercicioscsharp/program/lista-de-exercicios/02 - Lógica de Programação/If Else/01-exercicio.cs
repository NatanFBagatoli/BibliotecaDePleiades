class ExercicioIfElse
{
    public static void Executar6()
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

        //if(); se a condição x for verdadeira, tudo entre {} será executado
        //else if(); se a condição anterior for falsa, verifica outra condição de x
        //else(); caso as condições anteriores forem falsas, tudo entre {} será executado 
        //.ToUpper(); transforma uma string em letras maiúsculas
        //! = null-forgiving

        Console.WriteLine("===== DESEJA ALTERAR O CADASTRO? (Y/N)=====");
        string alterarcadastro = Console.ReadLine()!.ToUpper();

        if (alterarcadastro == "Y")
            {
            Console.WriteLine();
            Console.WriteLine("===== NOVO CADASTRO =====");
            Console.WriteLine();

            Console.Write("Nome: ");
            nome = Console.ReadLine()!;
            while (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Valor inválido");
                nome = Console.ReadLine()!;
            }
            
            Console.Write("Inicial do nome: ");
            inicial = char.Parse(Console.ReadLine()!);

            Console.Write("Idade: ");
            while(!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.WriteLine("Valor Inválido");
            }

            Console.Write("Altura: ");
            altura = float.Parse(Console.ReadLine()!);
            Console.Write("Ano de Nascimento: ");
            datadenasc = short.Parse(Console.ReadLine()!);

            Console.WriteLine();    
            Console.WriteLine("===== NOVO CADASTRO =====");
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
            
            }
        else if (alterarcadastro == "N")
            {
            Console.WriteLine("CADASTRO FINALIZADO");    
            }
        else
            {
                Console.WriteLine("Resposta inválida");
            }
    }
}