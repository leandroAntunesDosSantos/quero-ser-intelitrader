// See https://aka.ms/new-console-template for more information

string mensagem = "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";

string[] mensagemArray = mensagem.Split(" ");

string novoArray = "";

for (int i = 0; i < mensagemArray.Length; i++)
{
    string primeiro = mensagemArray[i].Substring(0, 4);
    string segundo = mensagemArray[i].Substring(4, 4);
    string terceiro = segundo.Substring(0, 2);
    string quarto = segundo.Substring(2, 2);
    string quinto = terceiro.Substring(0, 1);
    if (quinto == "0")
    {
        quinto = "1";
    }
    else
    {
        quinto = "0";
    }
    string sexto = quarto.Substring(1, 1);
    if (sexto == "0")
    {
        sexto = "1";
    }
    else
    {
        sexto = "0";
    }
    string uniao = terceiro + quinto + sexto + primeiro + ' ';
    novoArray += uniao;
}

string[] mensagemFinal = novoArray.Split(" ");

string mensagemFinalString = "";
for (int i = 0; i < mensagemFinal.Length - 1; i++)
{
    mensagemFinalString += Convert.ToChar(Convert.ToInt32(mensagemFinal[i], 2));
}
Console.WriteLine(mensagemFinalString);

