using System;
using System.Collections.Generic;
using System.Text;

namespace CalcoloAree
{
    public class CRettangolo : CFigura
    {
        private float baseRettangolo;
        private float altezzaRettangolo;
        
        public float BaseRettangolo
        {
            get
            {
                return baseRettangolo;
            }
            set
            {
                baseRettangolo = value;
            }
        }

        public float AltezzaRettangolo
        {
            get
            {
                return altezzaRettangolo;
            }
            set
            {
                altezzaRettangolo = value;
            }
        }

        public CRettangolo(string Nome, float BaseRettangolo, float AltezzaRettangolo) : base(Nome)
        {
            this.BaseRettangolo = BaseRettangolo;
            this.AltezzaRettangolo = AltezzaRettangolo;
        }

        public override float Area()
        {
            float area = baseRettangolo * AltezzaRettangolo;
            return area;
        }

        public override float Perimetro()
        {
            float perimetro = (BaseRettangolo + AltezzaRettangolo) * 2;
            return perimetro;
        }

        public override string Descrizione()
        {
            return base.Descrizione();
        }
    }
}
