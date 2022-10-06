using dio_botcamp_dotnet.Models;
// -----------------------------------------------------------
// refatorando o menu
// string Opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - cadastrar cliente");
//     Console.WriteLine("2 - buscar cliente");
//     Console.WriteLine("3 - apagar cliente");
//     Console.WriteLine("4 - encerrar");

//     Opcao = Console.ReadLine();

//     switch(Opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro do cliente");
//         break;

//         case "2":
//         Console.WriteLine("Buscar cliente");
//         break;

//         case "3":
//         Console.WriteLine("Apagar cliente");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar");
//         //Environment.Exit(0); para sair do programa, porém não será execultado mais nada
//         exibirMenu = false; // com essa forma o que tiver após o laço será execultado.
//         break;
        
//         default:
//         Console.WriteLine("Opção inválida.");
//         break;
//     };
// }
// Console.WriteLine("O programa se encerrou!");

// -----------------------------------------------------------
// Construindo um menu de opções simples.
// string Opcao;

// while(true)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - cadastrar cliente");
//     Console.WriteLine("2 - buscar cliente");
//     Console.WriteLine("3 - apagar cliente");
//     Console.WriteLine("4 - encerrar");

//     Opcao = Console.ReadLine();

//     switch(Opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro do cliente");
//         break;

//         case "2":
//         Console.WriteLine("Buscar cliente");
//         break;

//         case "3":
//         Console.WriteLine("Apagar cliente");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar");
//         Environment.Exit(0);
//         break;
        
//         default:
//         Console.WriteLine("Opção inválida.");
//         break;
//     };

// }

// -----------------------------------------------------------
// Estrutura de repetição.
// do while
// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número: (0 para parar.) ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"O total da soma dos números digitados é de: {soma}");
// while

// int numero = 5;
// int contador = 0;

// while(contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}° execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if(contador == 6)
//     {
//         break;
//     }
// }

//Console.WriteLine("Fim!");

// For

// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// -----------------------------------------------------------
// increment
// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento = 10);

// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);
// // -----------------------------------------------------------
// // decrement
// int numeroDecremento = 20;

// Console.WriteLine("Decrementando o 20");

// numeroDecremento--;

// Console.WriteLine(numeroDecremento);

// -----------------------------------------------------------
// Chamando a classe.
// Calculadora calc = new Calculadora();
// calc.RaizQuadrada(9);
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);
// calc.Potencia(3, 3);
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

// -----------------------------------------------------------
// Oprerador Lógico.
// Operador NOT (!)

// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!");
// }
// else{
//     Console.Write("Vou pedalar outro dia!");
// }

// Operador AND (&&)
// bool possuiPresencaMinima = true;
// double media = 7.5;

// if(possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aluno aprovado.");
// }
// else
// {
//     Console.WriteLine("Aluno reprovado");
// }

// Operador OR (Pipe, ||)
// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel);
// {
//     Console.WriteLine("Entrada liberada.");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada.");
// }

// -----------------------------------------------------------
// Operadores condicionais.
// switch case.
// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("A letra digitada é uma vogal."):
//         break;
    
//     default:
//         Console.Write("A letra digitada não é uma vogal.");
//         break;
// }

// Ex. Sem o switch
// if(letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u")
//    {
//     Console.WriteLine("A letra digitada é uma vogal!");
//    }
//    else
//    {
//     Console.WriteLine("A letra digitada não é uma vogal!");
//    }

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Qunatidade comprada: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada.");
// }

// -----------------------------------------------------------
// Convertendo tipo de variáveis (cast-casting)
// int a = Convert.ToInt32("5"); // ou int a = int.Parse("5");

// Console.WriteLine(a);

// -----------------------------------------------------------
// Combinando operadores.
// int a = 10;
//  int b = 20;

// int c = a + b;

// c = c + 5; Pode ser usado também c += 5

// Console.WriteLine(c);

// -----------------------------------------------------------
// Operedor de atribuição.
// int a = 10;
// int b = 20;

// int c = a + b;

// Console.WriteLine(c);

// -----------------------------------------------------------
// Usando o DateTime
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

// -----------------------------------------------------------
//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Lucas";
//pessoa1.Idade = 25;
//pessoa1.Apresentar();

// -----------------------------------------------------------
// Exemplos tipos de dados

// string apresentacao = "Olá, seja bem vindo.";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);