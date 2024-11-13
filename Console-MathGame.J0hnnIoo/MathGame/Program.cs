namespace MathGame
{
    internal class Program
    {
        static List<string> jogosAnteriores = new List<string>();

        static void Main(string[] args)
        {
            // Inicia o jogo
            IniciarJogo();

            // Método que inicia o jogo e exibe o menu de opções
            void IniciarJogo()
            {
                Console.Clear();

                string? resposta;

                Console.WriteLine("Bem vindo ao MathGame!");
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("(+) - Soma");
                Console.WriteLine("(-) - Subtração");
                Console.WriteLine("(*) - Multiplicação");
                Console.WriteLine("(/) - Divisão");
                Console.WriteLine("(f) - Ver jogos anteriores");
                Console.WriteLine("(s) - Sair");

                // Lê a resposta do usuário
                resposta = Console.ReadLine();

                // Executa a operação escolhida pelo usuário
                switch (resposta.ToLower().Trim())
                {
                    case "+":
                        Console.Clear();
                        Soma();
                        break;
                    case "-":
                        Console.Clear();
                        Subtracao();
                        break;
                    case "*":
                        Console.Clear();
                        Multiplicacao();
                        break;
                    case "/":
                        Console.Clear();
                        Divisao();
                        break;
                    case "s":
                        Console.Clear();
                        Console.WriteLine("Obrigado por jogar!");
                        break;
                    case "f":
                        MostrarJogosAnteriores();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            // Método para realizar operações de soma
            void Soma()
            {
                int pontuacao = 0;

                for (int i = 0; i < 5; i++)
                {
                    GeraNumeros(out int n1, out int n2);

                    int resultadoCalculo;
                    int resultadoUsuario;

                    resultadoCalculo = n1 + n2;

                    Console.WriteLine($"Quanto é {n1} + {n2}?");
                    resultadoUsuario = int.Parse(Console.ReadLine());

                    if (resultadoUsuario == resultadoCalculo)
                    {
                        pontuacao += 5;
                    }
                    else
                    {
                        pontuacao -= 5;
                    }
                    Console.Clear();
                }
                Console.WriteLine($"Sua pontuação final foi: {pontuacao}");
                jogosAnteriores.Add($"Soma: {pontuacao} pontos");

                Console.WriteLine("Deseja voltar ao menu? (s/n)");
                string? resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                    IniciarJogo();
            }

            // Método para realizar operações de subtração
            void Subtracao()
            {
                int pontuacao = 0;

                for (int i = 0; i < 5; i++)
                {
                    GeraNumeros(out int n1, out int n2);

                    int resultadoCalculo;
                    int resultadoUsuario;

                    // Verificar se n1 é maior que n2, se não for, trocar os valores
                    if (n1 < n2)
                    {
                        (n2, n1) = (n1, n2);
                    }

                    resultadoCalculo = n1 - n2;

                    Console.WriteLine($"Quanto é {n1} - {n2}?");
                    resultadoUsuario = int.Parse(Console.ReadLine());

                    if (resultadoUsuario == resultadoCalculo)
                    {
                        pontuacao += 5;
                    }
                    else
                    {
                        pontuacao -= 5;
                    }
                    Console.Clear();
                }
                Console.WriteLine($"Sua pontuação final foi: {pontuacao}");
                jogosAnteriores.Add($"Subtração: {pontuacao} pontos");

                Console.WriteLine("Deseja voltar ao menu? (s/n)");
                string? resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                    IniciarJogo();
            }

            // Método para realizar operações de multiplicação
            void Multiplicacao()
            {
                int pontuacao = 0;

                for (int i = 0; i < 5; i++)
                {
                    GeraNumeros(out int n1, out int n2);

                    int resultadoCalculo;
                    int resultadoUsuario;

                    resultadoCalculo = n1 * n2;

                    Console.WriteLine($"Quanto é {n1} * {n2}?");
                    resultadoUsuario = int.Parse(Console.ReadLine());

                    if (resultadoUsuario == resultadoCalculo)
                    {
                        pontuacao += 5;
                    }
                    else
                    {
                        pontuacao -= 5;
                    }
                    Console.Clear();
                }
                Console.WriteLine($"Sua pontuação final foi: {pontuacao}");
                jogosAnteriores.Add($"Multiplicação: {pontuacao} pontos");

                Console.WriteLine("Deseja voltar ao menu? (s/n)");
                string? resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                    IniciarJogo();
            }

            // Método para realizar operações de divisão
            void Divisao()
            {
                int pontuacao = 0;

                for (int i = 0; i < 5; i++)
                {
                    GeraNumeros(out int n1, out int n2);

                    int resultadoCalculo;
                    int resultadoUsuario;

                    // Verificar se n1 é divisível por n2, se não for, gerar novos números
                    if (n1 % n2 != 0)
                    {
                        i--;
                        continue;
                    }

                    resultadoCalculo = n1 / n2;

                    Console.WriteLine($"Quanto é {n1} / {n2}?");
                    resultadoUsuario = int.Parse(Console.ReadLine());

                    if (resultadoUsuario == resultadoCalculo)
                    {
                        pontuacao += 5;
                    }
                    else
                    {
                        pontuacao -= 5;
                    }
                    Console.Clear();
                }
                Console.WriteLine($"Sua pontuação final foi: {pontuacao}");
                jogosAnteriores.Add($"Divisão: {pontuacao} pontos");

                Console.WriteLine("Deseja voltar ao menu? (s/n)");
                string? resposta = Console.ReadLine();

                if (resposta.ToLower() == "s")
                    IniciarJogo();
            }

            // Método para gerar dois números aleatórios
            void GeraNumeros(out int n1, out int n2)
            {
                Random random = new Random();
                n1 = random.Next(1, 50);
                n2 = random.Next(1, 50);
            }

            // Método para exibir os jogos anteriores
            void MostrarJogosAnteriores()
            {
                Console.Clear();
                Console.WriteLine("Jogos anteriores:");
                foreach (var jogo in jogosAnteriores)
                {
                    Console.WriteLine(jogo);
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
                IniciarJogo();
            }
        }
    }
}
