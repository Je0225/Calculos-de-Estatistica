using System;
using Estatistica.Calculos.Contratos;

namespace Estatistica.Calculos {
  internal class CalculoMedia : ICalculoDouble{

    public Double Calcula(CalculosValoresBase bases) {
      return bases.Soma / bases.Rol.Count;
    }

  }
}
