using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AD220231.Entities
{
    public class Campeonato
    {
        public List<Jogo> Jogos { get; set; } = new List<Jogo>();
        public HashSet<Time> Times { get; set; } = new HashSet<Time>();

        public Campeonato(){
            
        }

        public void AdicionarJogo(Jogo jogo){
            Jogos.Add(jogo);
        }

        public void AdicionarTime(Time time){
            Times.Add(time);
        }

        public void JogarCampeonato(){
            foreach (var jogo in Jogos)
            {
                Time vencedor = jogo.VencedorJogo();
                if(vencedor != null){
                    Times.FirstOrDefault(i => i.Nome.Equals(vencedor.Nome)).AdicionarPontos(3);
                }
                
            }
        }

        public List<Time> Tabela(){
            return Times.OrderByDescending(t => t.Pontucao).ToList();
        }
    }
}