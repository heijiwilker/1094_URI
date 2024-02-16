/*  Maria acabou de iniciar seu curso de graduação na faculdade de medicina e 
 *  precisa de sua ajuda para organizar os experimentos de um laboratório o qual
 *  ela é responsável. Ela quer saber no final do ano, quantas cobaias foram 
 *  utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.
 *  Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e
 *  coelhos. Para obter estas informações, ela sabe exatamente o número de 
 *  experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade 
 *  de cobaias utilizadas em cada experimento.
 *  
 *  
 *  Entrada
 *  A primeira linha de entrada contém um valor inteiro N que indica os vários casos
 *  de teste que vem a seguir. Cada caso de teste contém um inteiro Quantia 
 *  (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas e um 
 *  caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia 
 *  (R:Rato S:Sapo C:Coelho).
 *  
 *  Saída
 *  Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia 
 *  utilizada e o percentual de cada uma em relação ao total de cobaias 
 *  utilizadas, sendo que o percentual deve ser apresentado com dois dígitos
 *  após o ponto.
 * 
 */
// quantidade de casos de teste
using System.Globalization;

int N = Convert.ToInt32(Console.ReadLine());
int cont = 0, totalQuantia = 0, coelho = 0, sapo = 0, rato = 0;

while (cont < N)
{
    string[] vetor = Console.ReadLine().Split(' ');

    int quantia = int.Parse(vetor[0]);
    char tipo = char.Parse(vetor[1]);

    totalQuantia += quantia;

    if (tipo == 'C')
    {
        coelho += quantia;
    }
    else if (tipo == 'R')
    {
        rato += quantia;
    }
    else if (tipo == 'S')
    {
        sapo += quantia;
    }

    cont++;
}

double percCoelhos = (coelho * 100.00) / totalQuantia;
double percRato = (rato * 100.00) / totalQuantia;
double percSapo = (sapo * 100.00) / totalQuantia;

Console.WriteLine($"Total: {totalQuantia} cobaias");
Console.WriteLine($"Total de coelhos: {coelho}");
Console.WriteLine($"Total de ratos: {rato}");
Console.WriteLine($"Total de sapos: {sapo}");
Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F", CultureInfo.InvariantCulture) + " %");
Console.WriteLine("Percentual de ratos: " + percRato.ToString("F", CultureInfo.InvariantCulture) + " %");
Console.WriteLine("Percentual de sapos: " + percSapo.ToString("F", CultureInfo.InvariantCulture) + " %");

Console.ReadLine();