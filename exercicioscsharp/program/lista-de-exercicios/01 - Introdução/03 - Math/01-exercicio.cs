
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
        double arredondamento = 7.573489;

        //Math é uma classe do C# que fornece vários métodos matemáticos.

        Console.WriteLine($"A soma de {a} mais {b} é igual a: {adicao}");
        Console.WriteLine($"A soma de {a} menos {b} é igual a: {subtracao}");
        Console.WriteLine($"A soma de {a} vezes {b} é igual a: {multiplicacao}");
        Console.WriteLine($"A soma de {a} dividido por {b} é igual a: {divisao}");
        Console.WriteLine($"A soma da porcentagem de {b} em relação a {a} é igual a: {porcentagem}");
        Console.WriteLine($"A soma de {a} elevado a {b} é igual a: {potencia}");
        Console.WriteLine($"A raiz quadrada de 9 é: {raizquadrada}");
        Console.WriteLine($"A raiz cúbica de 9 é: {raizcubica}");
        Console.WriteLine($"{log}");
        Console.WriteLine($"{absoluto1}");
        Console.WriteLine($"{absoluto2}");
        Console.WriteLine($"{mediaaritmetica}");
        Console.WriteLine($"{mediaponderada}");
        Console.WriteLine(Math.Round(arredondamento));
        Console.WriteLine(Math.Round(arredondamento, 3));

    }
}