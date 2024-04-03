namespace compras
{
    internal class Program
    {
        static int resposta;
        static void Main(string[] args)
        {
            string[] nome_itens = new string[999];
            double[] preco_itens = new double[999];
            
            int opcao=0;
            while (opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("Listas de Compras:");
                Console.WriteLine("1 - Cadastrar itens");
                Console.WriteLine("2 - Listar itens");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine()!);
                switch(opcao)
                {
                    case 1:

                        Console.Clear();
                        Console.Write("Quantos itens deseja cadastrar na lista? ");
                        resposta = int.Parse(Console.ReadLine()!);
                        Console.Clear();
                        for (int i = 0; i < resposta;i++)
                        {
                            Console.Write($"Qual o nome do {i+1}° item? ");
                            nome_itens[i] = Console.ReadLine()!;
                            Console.Write($"Qual o preço do {i+1}° item? ");
                            preco_itens[i] = double.Parse(Console.ReadLine()!);
                            Console.WriteLine("");
                        }
                        Console.WriteLine("Cadastro Finalizado.");
                        string supermecado = @"c:\Lista";                             
                        if (!Directory.Exists(supermecado))                                 
                        {
                            Directory.CreateDirectory(supermecado);                               
                        }
                        StreamWriter sw;                                                       
                        if (File.Exists(@"c:\Lista\Lista de Compras.txt"))      
                        {
                            File.Delete(@"c:\Lista\Lista de Compras.txt");       
                        }
                        sw = new StreamWriter(@"c:\Lista\Lista de Compras.txt");
                        sw.WriteLine("Listagem dos itens:");
                        for (int i = 0; i < resposta; i++)
                        {
                            sw.WriteLine("============================");
                            sw.WriteLine($"Produto: {nome_itens[i]} - R$ {preco_itens[i]}");
                            sw.WriteLine("============================");
                        }
                        sw.Close();
                        Console.WriteLine("Aperte qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.Clear();
                        StreamReader sr = new StreamReader(@"c:\Lista\Lista de Compras.txt");
                        while (!sr.EndOfStream)
                        {
                            Console.WriteLine(sr.ReadLine());          
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine("Cai fora.");
                        Console.WriteLine("Aperte qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine("Opção não existe.");
                        Console.WriteLine("Aperte qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;
                }

            }
        }
    }
}