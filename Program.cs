// See https://aka.ms/new-console-template for more information
using AD220231.Entities;

try
{
  using StreamReader reader = new("doc/doc.csv");
  reader.ReadLine();
  Campeonato campeonato = new Campeonato();

  while(reader.Peek() >= 0){
    string linha = reader.ReadLine();
    var dados  = linha.Split(',');
    Time timeA = new Time(dados[4]);
    int pontosA = int.Parse(dados[6]);
    Time timeB = new Time(dados[5]);
    int pontosB = int.Parse(dados[7]);

    campeonato.AdicionarTime(timeA);
    campeonato.AdicionarTime(timeB);

    campeonato.AdicionarJogo(new Jogo(timeA, timeB, pontosA, pontosB));

  }
  campeonato.JogarCampeonato();
  campeonato.Tabela().ForEach(t => System.Console.WriteLine(t));


}
catch (System.Exception e)
{
  System.Console.WriteLine(e.Message);
}