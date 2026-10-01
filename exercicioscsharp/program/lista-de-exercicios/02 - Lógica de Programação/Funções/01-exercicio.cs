//O que é uma função ?
//uma função é um bloco de código criado para executar uma determinada tarefa.

//qual utilidade da função?
//suponha que você tenha "Console.WriteLine("hello world");" se você precisar repetir hello world 10 vezes, você poderia escrever console 10 vezes. 
//Porem, você também poderia criar uma função

//Como eu crio uma função?
//você adiciona static void e nomeia a função ficando static void dizerhelloworld().
//depois você engloba dentro dela a ação que você desejar, por exemplo:

//static void dizerhelloworld()
//{
//    Console.WriteLine("hello world");
//}
//você pode chamá-la agora quantas vezes forem necessária usando dizerhelloworld();

//static = modificador, significa que o método pertence à classe, e não a uma instância específica dela.
//void = retorno, indica que a função não devolve nenhum valor. caso devolvesse por exemplo o retorno de uma soma, ficaria static int Somar();.
//() = parâmetros, é possivel definir parametros também, por exemplo: 

//static int Somar(int a, int b)            nota: parâmetros = (int a, int b) argumentos = (10, 20)
//{
//    return a + b;      
//}
//
using System.Net.NetworkInformation;

public class ExercicioFuncoes
{
    public static void ExecutarFuncoes()
    {

        static void dizeroi()
        {
            Console.WriteLine("Oie");
        }
        static int somar()
        {
            return 2 + 2;
        }
        static void nome(string nome)
        {
            Console.Write($"Olá, {nome}");
        }
        nome("Edward");
        nome("Natan");
        somar();
        dizeroi();

        static int returnint()
        {
            return 2;
        }
        static double returndouble()
        {
            return 2.5;
        }
        static char returnchar()
        {
            return 'E';
        }
        static bool returnbool()
        {
            return true;
        }

        returnint();
        returndouble();
        returnchar();
        returnbool();


        static int dobrar(int numero)
        {
            return numero * 2;
        }

        static bool maiordeidade(int idade)
        {
            if (idade >= 18)
            {
                return true;
            }//else
            return false;
        }

        static void contar(int limite)
        {
            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine(i);
            }
        }
        contar(10);
        maiordeidade(20);
        dobrar(4);

        static void mostrarnumeros(int[] numeros)
        {
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
    }
int[] valores = {1,2,3,4,5,6,7,8,9,10};
mostrarnumeros(valores);



    }

}
