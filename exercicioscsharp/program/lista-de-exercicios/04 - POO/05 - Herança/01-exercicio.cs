public class Funcionario
{
    public string Nome;
    public double Salario;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário: R$ {Salario}");
    }
}

public class Gerente : Funcionario
{
    public int QntdFuncionarios;

    public void Gerenteinfo()
    {
        ExibirInformacoes();
        Console.WriteLine($"Quantidade de Funcionários: {QntdFuncionarios}");
    }
}

public class Desenvolvedor : Funcionario
{
    public string LinguagemPrincipal;

    public void Desenvolvedorinfo()
    {
        ExibirInformacoes();
        Console.WriteLine($"Linguagem principal: {LinguagemPrincipal}");
    }
}

public class Program
{
    public static void Main()
    {
        Gerente gerente = new Gerente();

        gerente.Nome = "Joestar";
        gerente.Salario = 8000;
        gerente.QntdFuncionarios = 12;

        Desenvolvedor desenvolvedor = new Desenvolvedor();

        desenvolvedor.Nome = "Edward";
        desenvolvedor.Salario = 5500;
        desenvolvedor.LinguagemPrincipal = "C#";

        Console.WriteLine("===== GERENTE =====");
        gerente.Gerenteinfo();

        Console.WriteLine();

        Console.WriteLine("===== DESENVOLVEDOR =====");
        desenvolvedor.Desenvolvedorinfo();
    }
}