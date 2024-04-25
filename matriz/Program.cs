int qtdLinha = 0, qtdColunas = 0;
float[,] matriz3;
float[,] matriz;
float[,] matriz2;

void ImprimirMatriz(float[,] matriz, String mensagem)
{
    Console.WriteLine("\n" + mensagem);

    for (int linha = 0; linha < qtdLinha; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            Console.Write(matriz[linha, coluna] + " ");

    }

    Console.WriteLine();

}

float[,] SomarMatriz()
{
    float[,] matrizResultante = new float[qtdLinha, qtdColunas];

    for (int linha = 0; linha < qtdLinha; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matrizResultante[linha, coluna] = matriz[linha, coluna] + matriz2[linha, coluna];
    }

    return matrizResultante;
}
float[,] SubtrairMatriz()
{
    float[,] matrizResultante = new float[qtdLinha, qtdColunas];

    for (int linha = 0; linha < qtdLinha; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matrizResultante[linha, coluna] = matriz[linha, coluna] - matriz2[linha, coluna];
    }

    return matrizResultante;
}

float[,] MultiplicarMatriz()
{
    float[,] matrizResultante = new float[qtdLinha, qtdColunas];

    for (int linha = 0; linha < qtdLinha; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matrizResultante[linha, coluna] = matriz[linha, coluna] * matriz2[linha, coluna];
    }

    return matrizResultante;
}

float[,] DividirMatriz()
{
    float[,] matrizResultante = new float[qtdLinha, qtdColunas];

    for (int linha = 0; linha < qtdLinha; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            if (matriz2[linha, coluna] != 0)
                matrizResultante[linha, coluna] = matriz[linha, coluna] / matriz2[linha, coluna];
            else
                matrizResultante[linha, coluna] = float.NaN;


    }

    return matrizResultante;

}


void DefinicaoTamanhoMatriz()
{
    do
    {
        Console.WriteLine("Digite o numero de linhas da Matriz(diferente de 0): ");
        qtdLinha = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o numero de colunas da Matriz(diferente de 0): ");
        qtdColunas = int.Parse(Console.ReadLine());
    

    }while( qtdLinha < 0 || qtdColunas < 0);

    matriz = new float[qtdLinha, qtdColunas];
    matriz2 = new float[qtdLinha, qtdColunas];
}

int EscolherOption()
{
    int opcao;
    Console.WriteLine("\nDigite se Deseja Soma [1], Subtrair [2], multiplica [3], " +
        "dividir [4], sair [qualque outro numero]");
    opcao = int.Parse(Console.ReadLine());

    return opcao;

}

void SortearNumeros()
{
    for (int linha = 0; linha < qtdLinha; linha++)
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matriz[linha, coluna] = new Random().Next(1, 100);
            matriz2[linha, coluna] = new Random().Next(1, 100);
        }
}


DefinicaoTamanhoMatriz();

SortearNumeros();

ImprimirMatriz(matriz, "Matriz 1: ");
 
ImprimirMatriz(matriz2, "Matriz 2: ");

EscolherOption();

switch (EscolherOption())
{
    case 1:
        matriz3 = SomarMatriz();
        ImprimirMatriz(matriz3, "Soma Matriz");
        break;

    case 2:
        matriz3 = SubtrairMatriz();
        ImprimirMatriz(matriz3, "Subtrair Matriz");

        break;

    case 3:
        matriz3 = MultiplicarMatriz();
        ImprimirMatriz(matriz3, "Multiplicar Matriz");
        break;

    case 4:
        matriz3 = DividirMatriz();
        ImprimirMatriz(matriz3, "Dividir Matriz");
        break;
    default:
        Console.WriteLine("Volte sempre!");
        break;
}



