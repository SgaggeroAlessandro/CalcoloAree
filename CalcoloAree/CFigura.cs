using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalcoloAree
{
    public abstract class CFigura
    {
        private string nome;
        
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public CFigura(string Nome)
        {
            this.Nome = Nome;
        }

        public abstract float Area();
        public abstract float Perimetro();
        public virtual string Descrizione()
        {
            return $"Nome: {Nome}\nPerimetro: {Perimetro()}\nArea: {Area()}";
        }
    }
}
