using System;
using System.Collections.Generic;
using System.Linq;

namespace Estatistica {

  internal class CalculosValoresBase {

    public Double Soma { get; private set; }

    public Int32 ValorMinimo { get; private set; }

    public Int32 ValorMaximo { get; private set; }

    public List<Int32> Rol { get; private set; }

    public Dictionary<Int32, Int32> Ocorrencias { get; }

    public CalculosValoresBase(List<Int32> numeros) {
      Ocorrencias = new Dictionary<Int32, Int32>();
      ValorMinimo = Int32.MaxValue;
      ValorMaximo = Int32.MinValue;
      OrdenaNumeros(numeros);
      GetSoma();
      GetValorMaximoEMinimo();
      GetOcorrencias();
    }

    private void OrdenaNumeros(List<Int32> numeros) {
      Rol = numeros.OrderBy(numeroOrdenado => numeroOrdenado).ToList();
    }

    private void GetSoma() {
      foreach (int numero in Rol) {
        Soma += numero;
      }
    }

    private void GetValorMaximoEMinimo() {
      foreach (Int32 numero in Rol) {
        ValorMaximo = numero > ValorMaximo ? numero : ValorMaximo;
        ValorMinimo = numero < ValorMinimo ? numero : ValorMinimo;
      }
    }

    private void GetOcorrencias() {
      foreach (Int32 numero in Rol) {
        if (Ocorrencias.ContainsKey(numero)) {
          Ocorrencias[numero] += 1;
        } else {
          Ocorrencias.Add(numero, 1);
        }
      }
    }

  }

}