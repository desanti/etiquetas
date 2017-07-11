using System;
using System.Collections.Generic;
using System.Linq;

namespace Desanti.Etiquetas.Core.Test
{
    public class GeradorEtiquetas
    {
        public GeradorEtiquetas(Configuracao configuracao)
        {
            this._configuracao = configuracao;
        }

        private Configuracao _configuracao;
        private List<DadosEtiqueta> _dadosEtiquetas = new List<DadosEtiqueta>();

        public void Adicionar(DadosEtiqueta dados)
        {
            _dadosEtiquetas.Add(dados);
        }

        public string Gerar(IGeradorEtiquetaStrategy strategy)
        {
            var retorno = string.Empty;

            var contador = 1;

            foreach (var etiqueta in _dadosEtiquetas)
            {
                var e = new Etiqueta();


                foreach (var item in _configuracao.Elementos)
                {



                    // var i = _dadosEtiquetas.IndexOf()
                }


                //var elemento = this._configuracao.Elementos.Where(t => t.Chave == etiqueta.Chave).FirstOrDefault();

                // FAz o calculo dos posicionamentos


                if (contador == this._configuracao.Quantidade)
                {
                    contador = 1;
                }
            }

            return retorno;
        }
    }
}