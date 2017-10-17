using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Had
    {
        private Hlava hlava;
        private List<CastHada> castiTela;

        private Smer smer;
        private int rychlost;
        private int skore;

        public Had()
        {
            hlava = new Hlava();
            castiTela = new List<CastHada>();
            for (int i = 0; i < 3; i++)
            {
                castiTela.Add(new CastHada());
            }
            smer = Smer.Doprava;
            rychlost = 1;
            skore = 0;
        }
    }

    public enum Smer
    {
        Nahoru,
        Doprava,
        Dolu,
        Doleva
    }
}
