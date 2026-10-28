using System;
using System.Collections.Generic;
using System.Text;
namespace CalcoloAree
{
    public class CCerchio : CFigura
    {
        private float raggio;

        public float Raggio
        {
            get
            {
                return raggio;
            }
            set
            {
                raggio = value;
            }
        }

        public CCerchio(string Nome, float Raggio) : base(Nome)
        {
            this.Raggio = Raggio;
        }

        public override float Area()
        {
            float area = (float)Math.PI * (Raggio * Raggio);
            return area;
        }

        public override float Perimetro()
        {
            float perimetro = 2 * (float)Math.PI * (Raggio);
            return perimetro;
        }

        public override string Descrizione()
        {
            return base.Descrizione();
        }
    }
}
