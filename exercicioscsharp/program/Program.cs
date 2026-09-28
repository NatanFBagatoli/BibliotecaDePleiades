class Program
{
    static void Main()
    {
        Console.WriteLine("===== Assuntos de CSharp =====");
        Console.WriteLine();
        Console.WriteLine("01 - Introdução");
        Console.WriteLine();
        Console.WriteLine("02 - Lógica de Programação");
        Console.WriteLine();
        Console.WriteLine("03 - Poo");
        Console.WriteLine();
        Console.WriteLine("Deseja Ver Sobre Qual Assunto?: ");
        Console.WriteLine();

        int assunto = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch(assunto)
        {
            case 1:
                Console.WriteLine("===== Introdução ao CSharp =====");
                Console.WriteLine();
                Console.WriteLine("01 - Exercicios sobre Console");
                Console.WriteLine();
                Console.WriteLine("02 - Exercicios sobre Variáveis");
                Console.WriteLine();
                Console.WriteLine("03 - Exercicios sobre Math.");
                Console.WriteLine();
                    int exercicio = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                        switch(exercicio)
                        {
                        case 1:
                        ExercicioWriteLine.Executar();
                        break;
                        case 2:
                        ExercicioVariaveis.Executar2();
                        break;
                        case 3:
                        ExercicioMath.Executar3();
                        break;
                        }    
            break;

            case 2:
                ExercicioVariaveis.Executar2();
                break;

            default:
            Console.WriteLine("Opção inválida");
            break;
        }
    }
}