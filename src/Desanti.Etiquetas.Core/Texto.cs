using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desanti.Etiquetas.Core
{
    public class Texto : ElementoImpressoComValor
    {
        public int Fonte { get; set; }

        
        public string Valor { get; set; }
    }

    public abstract class ElementoImpresso
        {
        public int Largura { get; set; }

        public int Altura { get; set; }

        public int PosicaoX { get; set; }
        public int PosicaoY { get; set; }

        public string Chave { get; set; }

    }

    public abstract class ElementoImpressoComValor
    {
       
    }
}
