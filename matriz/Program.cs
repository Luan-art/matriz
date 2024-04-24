int qtdLinha = 2, atdColunas = 2, opcao = 0;
float[,] matriz = new float[qtdLinha, atdColunas];
float[,] matriz2 = new float[qtdLinha, atdColunas];
float[,] matrizResultante = new float[qtdLinha, atdColunas];

void imprimirMatriz(float[,] matriz)
{

    for (int linha = 0; linha < qtdLinha; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < atdColunas; coluna++)
            Console.Write(matriz[linha, coluna] + " ");

    }

    Console.WriteLine();

}

do
{
    Console.WriteLine("Digite se deja aleatorizar as matrizes [1] ou colocar os dados a mão [2]: ");
    opcao = int.Parse(Console.ReadLine());

} while (opcao != 1 && opcao != 2);


switch (opcao)
{
    case 1:
        for (int linha = 0; linha < qtdLinha; linha++)
            for (int coluna = 0; coluna < atdColunas; coluna++)
            {
                matriz[linha, coluna] = new Random().Next(1, 100);
                matriz2[linha, coluna] = new Random().Next(1, 100);
            }
        break;

    case 2:
        for (int linha = 0; linha < qtdLinha; linha++)
            for (int coluna = 0; coluna < atdColunas; coluna++)
            {
                Console.WriteLine("Digite os valores da primeira Matriz");
                matriz[linha, coluna] = float.Parse(Console.ReadLine());
               
            }

        for (int linha = 0; linha < qtdLinha; linha++)
            for (int coluna = 0; coluna < atdColunas; coluna++)
            {
                do
                {
                    Console.WriteLine("Digite os valores da segunda Matriz");
                    matriz2[linha, coluna] = float.Parse(Console.ReadLine());
                } while (matriz2[linha, coluna] == 0);
       

            }
        break;

    default:
        break;
}

Console.WriteLine("\nMatriz 1");
imprimirMatriz(matriz);

Console.WriteLine("\nMatriz 2");

imprimirMatriz(matriz2);

for (int linha = 0; linha < qtdLinha; linha++)
{
    for (int coluna = 0; coluna < atdColunas; coluna++)
        matrizResultante[linha, coluna] = matriz[linha, coluna] + matriz2[linha, coluna];
}

Console.WriteLine("Matriz Somas");

imprimirMatriz(matrizResultante);

Console.WriteLine("\nMatriz Subtração");
for (int linha = 0; linha < qtdLinha; linha++)
{
    for (int coluna = 0; coluna < atdColunas; coluna++)
        matrizResultante[linha, coluna] = matriz[linha, coluna] - matriz2[linha, coluna];
}

imprimirMatriz(matrizResultante);

Console.WriteLine("\nMatriz Multiplicação");

for (int linha = 0; linha < qtdLinha; linha++)
{
    for (int coluna = 0; coluna < atdColunas; coluna++)
        matrizResultante[linha, coluna] = matriz[linha, coluna] * matriz2[linha, coluna];
}

imprimirMatriz(matrizResultante);

Console.WriteLine("\nMatriz Divisão");
for (int linha = 0; linha < qtdLinha; linha++)
{
    for (int coluna = 0; coluna < atdColunas; coluna++)
        if (matriz2[linha, coluna] != 0)
            matrizResultante[linha, coluna] = matriz[linha, coluna] / matriz2[linha, coluna];     
        else
            matrizResultante[linha, coluna] = float.NaN;
            

}

imprimirMatriz(matrizResultante);

