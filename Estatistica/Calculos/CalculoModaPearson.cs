using System;
using Estatistica.Calculos.Contratos;
using Estatistica.Registry;

namespace Estatistica.Calculos {
  internal class CalculoModaPearson : ICalculoDouble{

    public Double Calcula(CalculosValoresBase bases) {
      ICalculoDouble calculoMediana = CalculosRegistry.GetCalculoDouble(typeof(CalculoMediana));
      ICalculoDouble calculoMedia = CalculosRegistry.GetCalculoDouble(typeof(CalculoMedia));

      Double mediana = calculoMediana.Calcula(bases);
      Double media = calculoMedia.Calcula(bases);
      return 3 * mediana - (2 * media);
    }

  }
}
