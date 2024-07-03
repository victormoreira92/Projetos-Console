using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AD220231.Entities
{
    public class Time
    {
        public string Nome { get; set; }
        public int Pontucao { get; set; }

        public Time(string nome){
            Nome = nome;
            Pontucao = 0;
        }

        public void AdicionarPontos(int pontos){
            Pontucao+=pontos;
        }

        public override string ToString()
        {
            return ""+Nome
            +" - "+Pontucao;
        }

        public override bool Equals(object? obj)
        {
            return obj is Time time &&
                Nome.Equals(time.Nome);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }


    }
}