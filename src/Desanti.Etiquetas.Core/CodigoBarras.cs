using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desanti.Etiquetas.Core
{
    public class CodigoBarras : ElementoImpressoComValor
    {
        public int Tipo
        { get; set; }

        public string Valor { get; set; }
    }

    public class Linha : ElementoImpresso
    {       
    }


    public class Configuracao
    {
        public int LarguraPapel { get; set; }

        public int LarguraEtiqueta { get; set; }

        public int AlturaEtiqueta { get; set; }

        public int LarguraGap { get; set; }

        public int AlturaGap { get; set; }

        public int Quantidade { get; set; }

        public List<ElementoImpresso> Elementos { get; set; }
    }

    public class ConfiguracaoPapel
    {
        public int LarguraPapel { get; set; }
    }

    public class ConfiguracaoEtiqueta
    {
        public int LarguraEtiqueta { get; set; }

        public int AlturaEtiqueta { get; set; }

        public int LarguraGap { get; set; }

        public int AlturaGap { get; set; }

        public int QuantidadePorPagina { get; set; }
    }

}
