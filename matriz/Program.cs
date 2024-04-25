int qtdLinha = 0, qtdColunas = 0, opcao = 0;
float[,] matrizResultante;
float[,] matriz;
float[,] matriz2;

void imprimirMatriz(float[,] matriz, String mensagem)
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

void somarMatriz()
{
    for (int linha = 0; linha < qtdLinha; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matrizResultante[linha, coluna] = matriz[linha, coluna] + matriz2[linha, coluna];
    }

    imprimirMatriz(matrizResultante, "Matriz Soma: ");
}
void subtrairMatriz()
{
    for (int linha = 0; linha < qtdLinha; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matrizResultante[linha, coluna] = matriz[linha, coluna] - matriz2[linha, coluna];
    }

    imprimirMatriz(matrizResultante, "Matriz Subtração");
}

void multiplicarMatriz()
{
    for (int linha = 0; linha < qtdLinha; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            matrizResultante[linha, coluna] = matriz[linha, coluna] * matriz2[linha, coluna];
    }

    imprimirMatriz(matrizResultante, "Matris Multiplicação");
}

void dividirMatriz()
{
    for (int linha = 0; linha < qtdLinha; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
            if (matriz2[linha, coluna] != 0)
                matrizResultante[linha, coluna] = matriz[linha, coluna] / matriz2[linha, coluna];
            else
                matrizResultante[linha, coluna] = float.NaN;


    }

    imprimirMatriz(matrizResultante, "Matriz Divisão");
}


void definicaoTamanhoMatriz()
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
    matrizResultante = new float[qtdLinha, qtdColunas];
}

void escolherOption()
{
    Console.WriteLine("\nDigite se Deseja Soma [1], Subtrair [2], multiplica [3], " +
        "dividir [4], sair [qualque outro numero]");
    opcao = int.Parse(Console.ReadLine());

}

void sortearNumeros()
{
    for (int linha = 0; linha < qtdLinha; linha++)
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matriz[linha, coluna] = new Random().Next(1, 100);
            matriz2[linha, coluna] = new Random().Next(1, 100);
        }
}


definicaoTamanhoMatriz();

sortearNumeros();

imprimirMatriz(matriz, "Matriz 1: ");
 
imprimirMatriz(matriz2, "Matriz 2: ");

escolherOption();

switch (opcao)
{
    case 1:
        somarMatriz();
        break;

    case 2:
        subtrairMatriz();
        break;

    case 3:
        multiplicarMatriz();
        break;

    case 4:
        dividirMatriz();
    break;
    default:
        Console.WriteLine("Volte sempre!");
        break;
}


