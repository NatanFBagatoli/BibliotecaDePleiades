public class ExercicioWriteLine
{
    public static void ExecutarWriteLine()
    {

        // ============================================
        // 1. WriteLine x Write
        // ============================================

        Console.WriteLine("Hello World");               //Console.WriteLine("Something"); escreve uma mensagem no console e pula uma linha 
        Console.WriteLine();                            //Console.WriteLine(); só pula linha
        Console.Write("Hello World 2");                 //Console.Write("Something 2"); escreve uma mensagem no console 
        Console.WriteLine();                            //pula linha manualmente após o Write

        // ============================================
        // 2. Concatenação com +
        // ============================================

        Console.WriteLine("Hello" + " " + "World"); 

        // ============================================
        // 3. Caracteres de escape
        // ============================================

        Console.WriteLine("Linha 1\nLinha 2");          // \n = quebra de linha
        Console.WriteLine("Nome:\tJoão");               // \t = tabulação
        Console.WriteLine("Ele disse: \"Olá!\"");       // \" = aspas dentro da string
        Console.WriteLine("C:\\pasta\\arquivo.txt");    // \\ = barra invertida

        // ============================================
        // 4. Expressoes aritméticas direto no WriteLine
        // ============================================

        Console.WriteLine($"2 + 2 = {2 + 2}");          //$ = Texto Interpolado(um texto onde você pode colocar valores e contas dentro dele)
        Console.WriteLine(4 + 4);
        Console.WriteLine($"5 - 4 = {5 - 4}");
        Console.WriteLine(10 - 5);
        Console.WriteLine($"5 * 5 = {5 * 5}");
        Console.WriteLine(3 * 3);
        Console.WriteLine($"12 / 4 = {12 / 4}");
        Console.WriteLine(12 / 3);

        // ============================================
        // 5. Formatação composta
        // ============================================

        Console.WriteLine("Nome: {0}, Idade: {1}, altura: {2}", "João", 19, 1.80);

        // ============================================
        // 6. ReadLine
        // ============================================

        Console.WriteLine("===== FIM DO PROGRAMA =====");
        Console.Write("Pressione Enter para sair...");
        Console.ReadLine();

    }
}