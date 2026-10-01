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
                Console.WriteLine("02 - Exercicios sobre Variáveis 1");
                Console.WriteLine();
                Console.WriteLine("03 - Exercicios sobre Variáveis 2.");
                Console.WriteLine();
                Console.WriteLine("04 - Exercicios sobre Math.");
                Console.WriteLine();

                    int exercicio = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                        switch(exercicio)
                        {
                        case 1:
                        ExercicioWriteLine.ExecutarWriteLine();
                        break;
                        case 2:
                        ExercicioVariaveis.ExecutarVariaveis1();
                        break;
                        case 3:
                        ExercicioVariaveis2.ExecutarVariaveis2();
                        break;
                        case 4:
                        ExercicioMath.ExecutarMath();
                        break;
                        }    
            break;

            case 2:
                ExercicioFuncoes.ExecutarFuncoes();
                break;
            case 3:
                ExercicioPoo.ExecutarPoo();
            break;
            default:
            Console.WriteLine("Opção inválida");
            break;
        }
    }
}