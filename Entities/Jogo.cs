using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AD220231.Entities
{
    public class Jogo
    {
        public Time TimeA { get; set; }
        public Time TimeB { get; set; }

        public int PontosA { get; }

        public int PontosB { get; }

        public Jogo(Time timeA, Time timeB, int pontosA, int pontosB)
        {
            TimeA = timeA;
            TimeB = timeB;
            PontosA = pontosA;
            PontosB = pontosB;
        }

        public Time VencedorJogo(){
            if(PontosA > PontosB){
                return TimeA;
            }else if(PontosB > PontosA){
                return TimeB;
            }else{
                return null;
            }
        }

        public override string ToString()
        {
            return ""+ TimeA.Nome + " "+PontosA+ " X "+TimeB.Nome+ " "+PontosB;
        }

    }
}