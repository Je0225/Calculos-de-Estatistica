using System;
using System.Collections.Generic;
using System.Linq;
using Estatistica.Calculos.Contratos;

namespace Estatistica.Calculos {
  internal class CalculoModa : ICalculoString {

    public String Calcula(CalculosValoresBase bases) {
      String valorModa = "Default";
      KeyValuePair<Int32, Int32> moda = new KeyValuePair<Int32, Int32>();
      Boolean todosIguais = bases.Ocorrencias.Values.All(v => v == bases.Ocorrencias.Values.First());

      if (todosIguais) {
        valorModa = "Amodal";
      } else {
        foreach (KeyValuePair<Int32, Int32> ocorrencia in bases.Ocorrencias) {
          if (ocorrencia.Value > moda.Value) {
            moda = ocorrencia;
            valorModa = moda.Key.ToString();
          } else if (ocorrencia.Value == moda.Value) {
            valorModa = valorModa + ", " + ocorrencia.Key;
          }
        }
      }
      return valorModa;
    }

  }
}
