using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desanti.Etiquetas.Core
{
    public interface IGeradorEtiquetaStrategy
    {
        string Gerar();
    }



    public class ArgoxPplBStrategy : IGeradorEtiquetaStrategy
    {
        public string Gerar()
        {
            return string.Empty;
        }
    }



    public class Class2
    {
        public string ToArgoxPplB(CodigoBarras codigoBarras)
        {
            var codigo = new StringBuilder();

            //codigo.AppendFormat();

            return string.Empty;
        }

        public string ToArgoxPplB(Texto texto)
        {
            var codigo = new StringBuilder();

            codigo.AppendFormat("A{0},{1},{2},{3},{4},{5},{6},{7}", 
                texto.PosicaoX,
                texto.PosicaoY,
                "0",
                texto.Fonte,
                texto.Altura,
                texto.Largura,
                "N",
                texto.Valor
                );
                

            return string.Empty;
        }
    }

    public class ArgoxPplB : Texto
    {
        // Ficaria simples a implementação e bem dividida
        // O problema é o cálculo dos valores, por exemplo de transformar milimetro em dots


        public override string ToString()
        {
            var codigo = new StringBuilder();

            codigo.AppendFormat("A{0},{1},{2},{3},{4},{5},{6},{7}",
                this.PosicaoX,
                this.PosicaoY,
                "0",
                this.Fonte,
                this.Altura,
                this.Largura,
                "N",
                this.Valor
                );


            return codigo.ToString();
        }
    }
}
