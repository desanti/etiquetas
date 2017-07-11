using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Desanti.Etiquetas.Core.Test
{
    public class DadosEtiqueta : Dictionary<string, string>
    {
        public DadosEtiqueta()
        {
        }

        public DadosEtiqueta(int capacity) : base(capacity)
        {
        }

        public DadosEtiqueta(IEqualityComparer<string> comparer) : base(comparer)
        {
        }

        public DadosEtiqueta(IDictionary<string, string> dictionary) : base(dictionary)
        {
        }

        public DadosEtiqueta(int capacity, IEqualityComparer<string> comparer) : base(capacity, comparer)
        {
        }

        public DadosEtiqueta(IDictionary<string, string> dictionary, IEqualityComparer<string> comparer) : base(dictionary, comparer)
        {
        }

        protected DadosEtiqueta(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }        
    }
}