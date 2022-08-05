// Exercício do dorso do Nélio Alves "Menor e Maior Altura"
// Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas. Fazer um programa que calcule e escreva:
// a maior e a menor altura do grupo;
// a média de altura das mulheres;
// o número de homens;


int N = int.Parse(Console.ReadLine());
double [] Altura = new double[N];
string [] Sexo = new string[N];

// Comando para ler as alturas e sexo;
for (int i = 0; i < N; i ++)
{
    string [] X = Console.ReadLine().Split(' ');
    Altura[i] = double.Parse(X[0]);
    Sexo[i] = X[1];
}

// Comando para definir maior e menor altura;
double MenorAltura = Altura[0];
double MaiorAltura = Altura[0];
for (int i = 0; i < N; i ++)
{
    if (Altura[i] < MenorAltura)
    {
        MenorAltura = Altura[i];
    }
    if (Altura[i] > MaiorAltura)
    {
        MaiorAltura = Altura[i];
    }
}

// Comando para mostrar na tela a média das alturas das mulheres;
int Cont = 0;
double MediaAlturas = 0.0;
for (int i = 0; i < N; i ++)
{
    if (Sexo[i] == "F")
    {
        MediaAlturas = MediaAlturas + Altura[i];
        Cont ++;
    }
}
MediaAlturas = MediaAlturas / Cont;

// Comando para contar quantidade de Homens;
int ContM = 0;
for (int i = 0; i < N; i ++)
{
    if (Sexo[i] == "M")
    {
        ContM ++;    
    }
}

// Comandos de saída;
Console.WriteLine(" ");
Console.WriteLine("Menor altura: " + MenorAltura.ToString("F2"));
Console.WriteLine("Maior altura: " + MaiorAltura.ToString("F2"));
Console.WriteLine("Média das alturas das mulheres: " + MediaAlturas.ToString("F2"));
Console.WriteLine("Quantidade de homens: " + ContM);
Console.WriteLine(" ");