// See https://aka.ms/new-console-template for more information


//int[] array1 = {-1, 5};
//int[] array2 = {26, 6};

//int[] array1 = {1, 2, 3, 5, 7,-1,-8,5,-4,-9};
//int[] array2 = {10, 20, 30, 40, 26,6,-12,45,99,100};

int[] array1 = { 1, 2, 3, 5, 7, -1, -8, 10, -4, -9 };
int[] array2 = { 99, 100, 101, 102, 103, 104, 105, 106, 107, 108 };

int resultAux = array1[0] - array2[0];

if (resultAux < 0)
{
    resultAux *= -1;
}

int menorDistancia = resultAux;

for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {
        int result = array1[i] - array2[j];
        if (result < 0)
        {
            result *= -1;
        }
        if (result < menorDistancia)
        {
            menorDistancia = result;
        }
    }
}

Console.WriteLine(menorDistancia);

