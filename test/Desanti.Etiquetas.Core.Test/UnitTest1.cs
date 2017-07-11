using System;
using System.Collections.Generic;
using Xunit;

namespace Desanti.Etiquetas.Core.Test
{
   
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var listaDeEtiquetas = new List<EtiquetasDto>();

            listaDeEtiquetas.Add(new EtiquetasDto() { CodigoBarra = "123", DescricaoProduto = "Calça" });
            listaDeEtiquetas.Add(new EtiquetasDto() { CodigoBarra = "123", DescricaoProduto = "Calça" });
            listaDeEtiquetas.Add(new EtiquetasDto() { CodigoBarra = "123", DescricaoProduto = "Calça" });
            listaDeEtiquetas.Add(new EtiquetasDto() { CodigoBarra = "123", DescricaoProduto = "Calça" });

            var impressaoEtiquetas = new GeradorEtiquetas(new Configuracao() { Quantidade = 3 });

            foreach (var item in listaDeEtiquetas)
            {
                var dados = new DadosEtiqueta();
                dados.Add("CodigoBarras", item.CodigoBarra);
                dados.Add("Descricao", item.DescricaoProduto);

                impressaoEtiquetas.Adicionar(dados);
            }

            string s = impressaoEtiquetas.Gerar(new ArgoxPplBStrategy());


        }
    }
}
