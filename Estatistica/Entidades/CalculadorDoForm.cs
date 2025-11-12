using System;
using System.Collections.Generic;
using Estatistica.Calculos;
using Estatistica.Registry;

namespace Estatistica.Entidades {
  internal class CalculadorDoForm {

    private CalculosValoresBase Bases { get; }

    public Int32 ValorMinimo { get; }

    public Int32 ValorMaximo { get; }

    public List<Int32> Rol { get; }

    public Dictionary<Int32, Int32> Ocorrencias { get; }

    public String Moda { get; private set; }

    public Double Mediana { get; private set; }

    public Double Media { get; private set; }

    public Double ModaDePearson { get; private set; }

    public Double DesvioPadrao { get; private set; }

    public Double Variancia { get; private set; }

    public CalculadorDoForm(List<Int32> numeros) {
      Bases = new CalculosValoresBase(numeros);
      ValorMinimo = Bases.ValorMinimo;
      ValorMaximo = Bases.ValorMaximo;
      Rol = Bases.Rol;
      Ocorrencias = Bases.Ocorrencias;
      Calcular();
    }

    private void Calcular() {
      Moda = CalculosRegistry.GetCalculoString(typeof(CalculoModa)).Calcula(Bases);
      Mediana = CalculosRegistry.GetCalculoDouble(typeof(CalculoMediana)).Calcula(Bases);
      Media = CalculosRegistry.GetCalculoDouble(typeof(CalculoMedia)).Calcula(Bases);
      ModaDePearson = CalculosRegistry.GetCalculoDouble(typeof(CalculoModaPearson)).Calcula(Bases);
      DesvioPadrao = CalculosRegistry.GetCalculoDouble(typeof(CalculoDesvioPadrao)).Calcula(Bases);
      Variancia = CalculosRegistry.GetCalculoDouble(typeof(CalculoVariancia)).Calcula(Bases);
    }

  }
}
