using System;
using System.Collections.Generic;
using System.Text;

namespace CalcoloAree
{
    public class CQuadrato : CRettangolo
    {
        private float lato;
        public float Lato
        {
            get
            {
                return lato;
            }
            set
            {
                lato = value;
            }
        }
        public CQuadrato(string Nome, float Lato) : base(Nome, Lato,Lato)
        {
            this.Lato = Lato;
        }

        public override float Area()
        {
            float area = lato * lato;
            return area;
        }

        public override float Perimetro()
        {
            float perimetro = lato * 4;
            return perimetro;
        }

        public override string Descrizione()
        {
            return base.Descrizione();
        }
    }
}
