using System;
using System.Linq;
using Estatistica.Calculos.Contratos;
using Estatistica.Registry;

namespace Estatistica.Calculos {
  internal class CalculoVariancia : ICalculoDouble{
     
    public Double Calcula(CalculosValoresBase bases) {
      ICalculoDouble calculoMedia = CalculosRegistry.GetCalculoDouble(typeof(CalculoMedia));

      Double media = calculoMedia.Calcula(bases);
      Double diferenca = bases.Rol.Sum(num => Math.Pow(num - media, 2));
      return diferenca /bases.Rol.Count;
    }

  }
}
