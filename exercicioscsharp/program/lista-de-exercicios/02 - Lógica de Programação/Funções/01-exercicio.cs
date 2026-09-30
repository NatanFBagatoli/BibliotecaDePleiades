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
