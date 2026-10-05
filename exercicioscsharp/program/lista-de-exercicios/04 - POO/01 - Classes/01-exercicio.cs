public class ExercicioPoo
{
    public static void ExecutarPoo()
    {
        ContaBancaria conta = new ContaBancaria("Joestar", 17000, "superSenha1234$");
        Console.WriteLine("===== Sistema Bancário =====");
        Console.WriteLine();
        Console.WriteLine("Informe o nome do titular da conta: ");
        string titular = Console.ReadLine()!;
        Console.WriteLine("Informe a senha da conta: ");
        string senha = Console.ReadLine()!;
        if (titular == conta.Titular && senha == conta.Senha)
        {
            Console.WriteLine("Deseja depositar ou retirar dinheiro? (D/R)");
            string opcao = Console.ReadLine()!;
            if (opcao.ToUpper() == "D")
            {
                Console.WriteLine("Informe o valor a ser depositado: ");
                decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());
                conta.Depositar(valorDeposito);
                Console.WriteLine($"Depósito realizado com sucesso! Saldo novo: R$ {conta.Saldo}");
            }
            else if (opcao.ToUpper() == "R")
            {
                Console.WriteLine("Informe o valor a ser retirado: ");
                decimal valorRetirado = Convert.ToDecimal(Console.ReadLine());
                conta.Retirar(valorRetirado);
                Console.WriteLine($"Retirada realizada com sucesso! Saldo novo: R$ {conta.Saldo}");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
        else
        {
             Console.WriteLine("Titular ou senha incorretos.");
        }
    }
}

public class ContaBancaria
{
    public string Titular { get; set;}
    public decimal Saldo { get; set;}
    public string Senha { get; set;}

    public ContaBancaria(string titular, decimal saldo, string senha)
    {
        Titular = titular;
        Saldo = saldo;
        Senha = senha;

    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }
    public void Retirar(decimal valor)
    {
        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }else{
            Saldo -= valor;
        }
        
    }
}

    
