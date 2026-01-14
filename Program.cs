// As listas principais 
List<string> nomes = new List<string>();
List<double> medias = new List<double>();
List<string> situacoes = new List<string>();

Console.WriteLine("Quantos alunos deseja cadastrar?");
int quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"Cadastro do aluno {i + 1}");

    Console.WriteLine("Nome do aluno: ");
    string? nomeAluno = Console.ReadLine();

    Console.WriteLine("Nota 1: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Nota 2: ");
    double nota2 = double.Parse(Console.ReadLine());

    double media = CalcularMedia(nota1, nota2);
    string situacao = VerificarSituacao(media);

    nomes.Add(nomeAluno);
    medias.Add(media);
    situacoes.Add(situacao);
}

Console.WriteLine("Ranking de Alunos");
for (int i = 0; i < medias.Count; i++)
{
    for (int j = i + 1; j < medias.Count; j++)
    {
        if (medias[j] > medias[i])
        {
            double tempMedia = medias[i];
            medias[i] = medias[j];
            medias[j] = tempMedia;

            string tempAluno = nomes[i];
            nomes[i] = nomes[j];
            nomes[j] = tempAluno;
        }
    }
}

for(int i = 0; i<nomes.Count; i++)
{
    Console.WriteLine($"{i+1}º Lugar - {nomes[i]} | Media: {medias[i]:F2}");
}

Console.WriteLine($"Quantidade de alunos {nomes.Count}");

Console.WriteLine("Resultados finais: ");
for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"Aluno; {nomes[i]}");
    Console.WriteLine($"Media: {medias[i]}");
    Console.WriteLine($"Situação: {situacoes[i]}");

}

static double CalcularMedia(double n1, double n2)
{
    return (n1 + n2) / 2;
}

static string VerificarSituacao(double md)
{
    if (md >= 7)
    {
        return "Aprovado";
    }
    else if (md >= 5)
    {
        return "Recuperação";
    }
    else
    {
        return "Reprovado";
    }
}