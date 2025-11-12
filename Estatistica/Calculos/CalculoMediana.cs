using System;
using Estatistica.Calculos.Contratos;

namespace Estatistica.Calculos {
  internal class CalculoMediana : ICalculoDouble{

    public Double Calcula(CalculosValoresBase bases) {
      Boolean listaEhPar = bases.Rol.Count % 2 == 0;
      Int32 mediana;
      Int32 posicaoMediana;

      if (listaEhPar) {
        posicaoMediana = (bases.Rol.Count / 2);
        Int32 posicaoMediana2 = (bases.Rol.Count / 2) + 1;
        mediana = (bases.Rol[posicaoMediana - 1] + bases.Rol[posicaoMediana2 - 1]) / 2;
      } else {
        posicaoMediana = (bases.Rol.Count + 1) / 2;
        mediana = bases.Rol[posicaoMediana - 1];
      }
      return mediana;
    }

  }
}
