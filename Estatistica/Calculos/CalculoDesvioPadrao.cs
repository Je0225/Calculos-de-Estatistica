using System;
using Estatistica.Calculos.Contratos;
using Estatistica.Registry;

namespace Estatistica.Calculos {
  internal class CalculoDesvioPadrao : ICalculoDouble{

    public Double Calcula(CalculosValoresBase bases) {
      ICalculoDouble calculoVariancia = CalculosRegistry.GetCalculoDouble(typeof(CalculoVariancia));

      Double variancia = calculoVariancia.Calcula(bases);
      return Math.Sqrt(variancia);
    }

  }
}
