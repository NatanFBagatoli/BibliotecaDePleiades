
public class ExercicioMath
{
    public static void Executar3()
    {
        
        int a = 10;
        int b = 5;
        int adicao = a + b;
        int subtracao = a - b;
        int multiplicacao = a * b;
        int divisao = a / b;
        double porcentagem = b * (a / 100.0);
        double potencia = Math.Pow(a, b);
        double raizquadrada = Math.Sqrt(9);
        double raizcubica = Math.Cbrt(18);
        double log = Math.Log(a);
        double absoluto1 = Math.Abs(-10);
        double absoluto2 = Math.Abs(10);
        double mediaaritmetica = (10 + 10 + 10) / 3;
        double mediaponderada = (10 + 10 + 10) / (12 + 12);
        double arredondamento = 7.573489;                       //arredonda o número, exemplo: 7,7 = 8 & 7,4 = 7 (mathround), tbm é possivel definir no numero de casas decimais 
        double removerdecimal = 7.573489;        
        double pi = Math.PI;
        double maiorvalor = Math.Max(10, 20);
        double menorvalor = Math.Min(10, 20);
        double euler = Math.E;
        double seno = Math.Sin(Math.PI / 2);
        double cosseno = Math.Cos(0);
        double tangente = Math.Tan(Math.PI / 4);
        double arcoseno = Math.Asin(1);
        double arcocosseno = Math.Acos(1);
        double arcotangente = Math.Atan(1);
        int x = 10;
        int y = 10;
        double arcotangente2 = Math.Atan2(y, x);                //é utilizado para descobrir a direção entre pontos, rotação de objetos, mira, trajetória etc.   


        //Math é uma classe do C# que fornece vários métodos matemáticos.

Console.WriteLine($"A soma de {a} mais {b} é igual a: {adicao}");
Console.WriteLine($"A subtração de {a} menos {b} é igual a: {subtracao}");
Console.WriteLine($"A multiplicação de {a} vezes {b} é igual a: {multiplicacao}");
Console.WriteLine($"A divisão de {a} por {b} é igual a: {divisao}");
Console.WriteLine($"A porcentagem de {b}% de {a} é igual a: {porcentagem}");
Console.WriteLine($"{a} elevado a {b} é igual a: {potencia}");
Console.WriteLine($"A raiz quadrada de 9 é igual a: {raizquadrada}");
Console.WriteLine($"A raiz cúbica de 18 é igual a: {raizcubica}");
Console.WriteLine($"O logaritmo natural de {a} é igual a: {log}");
Console.WriteLine($"O valor absoluto de -10 é igual a: {absoluto1}");
Console.WriteLine($"O valor absoluto de 10 é igual a: {absoluto2}");
Console.WriteLine($"A média aritmética é igual a: {mediaaritmetica}");
Console.WriteLine($"A média ponderada é igual a: {mediaponderada}");
Console.WriteLine($"O número {arredondamento} arredondado para 3 casas decimais é: {Math.Round(arredondamento, 3)}");
Console.WriteLine($"O número {removerdecimal} sem a parte decimal é: {Math.Truncate(removerdecimal)}");
Console.WriteLine($"O valor de PI é: {pi}");
Console.WriteLine($"O maior valor entre 10 e 20 é: {maiorvalor}");
Console.WriteLine($"O menor valor entre 10 e 20 é: {menorvalor}");
Console.WriteLine($"O número de Euler é: {euler}");
Console.WriteLine($"O seno de 90 graus (π/2 radianos) é aproximadamente: {seno}");
Console.WriteLine($"O cosseno de 0 radianos é: {cosseno}");
Console.WriteLine($"A tangente de π/4 radianos (45 graus) é aproximadamente: {tangente}");
Console.WriteLine($"O arco seno de 1, em radianos, é: {arcoseno}");
Console.WriteLine($"O arco cosseno de 1, em radianos, é: {arcocosseno}");
Console.WriteLine($"O arco tangente de 1, em radianos, é: {arcotangente}");
Console.WriteLine($"O ângulo da direção (x = {x}, y = {y}), em radianos, é: {arcotangente2}");

    }
}