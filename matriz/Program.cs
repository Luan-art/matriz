int qtdLinha = 2, atdColunas = 2;
int[,] matriz = new int[qtdLinha, atdColunas];
int[,] matriz2 = new int[qtdLinha, atdColunas];
int[,] matrizResultante = new int[qtdLinha, atdColunas];

for (int linha = 0; linha < qtdLinha; linha++) 
    for (int coluna = 0; coluna < atdColunas; coluna++)
        matriz[linha, coluna] = new Random().Next(1, 100);




for (int linha = 0; linha < qtdLinha; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < atdColunas; coluna++)
        Console.Write(matriz[linha, coluna] + " ");
    
}

for (int linha = 0; linha < qtdLinha; linha++)
{
    for (int coluna = 0; coluna < atdColunas; coluna++)
        matriz2[linha, coluna] = new Random().Next(1, 100);
}


for (int linha = 0; linha < qtdLinha; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < atdColunas; coluna++)
        Console.Write(matriz2[linha, coluna] + " ");

}

for (int linha = 0; linha < qtdLinha; linha++)
{
    for (int coluna = 0; coluna < atdColunas; coluna++)
        matrizResultante[linha, coluna] = matriz[linha, coluna] + matriz2[linha, coluna];
}

for (int linha = 0; linha < qtdLinha; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < atdColunas; coluna++)
        Console.Write(matrizResultante[linha, coluna] + " ");

}