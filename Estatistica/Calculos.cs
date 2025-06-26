using System;
using System.Collections.Generic;
using System.Linq;

namespace Estatistica {

  internal class Calculos {

    private Double Soma { get; set; }

    public Int32 ValorMinimo { get; private set; }

    public Int32 ValorMaximo { get; private set; }

    public List<Int32> NumerosOrdenados { get; }

    private Dictionary<Int32, Int32> Ocorrencias { get; }

    public Calculos(List<Int32> numeros) {
      NumerosOrdenados = numeros.OrderBy(numeroOrdenado => numeroOrdenado).ToList();
      ValorMinimo = Int32.MaxValue;
      ValorMaximo = Int32.MinValue;
      Ocorrencias = new Dictionary<Int32, Int32>();
      CalculaSoma();
    }

    private void CalculaSoma() {
      foreach (int numero in NumerosOrdenados) {
        Soma += numero;
        ValorMaximo = numero > ValorMaximo ? numero : ValorMaximo;
        ValorMinimo = numero < ValorMinimo ? numero : ValorMinimo;
        if (Ocorrencias.ContainsKey(numero)) {
          Ocorrencias[numero] += 1;
        } else {
          Ocorrencias.Add(numero, 1);
        }
      }
    }

    public Int32 CalculaMediana() {
      Boolean listaEhPar = NumerosOrdenados.Count % 2 == 0;
      Int32 mediana;
      Int32 posicaoMediana;
      if (listaEhPar) {
        posicaoMediana = (NumerosOrdenados.Count / 2);
        int posicaoMediana2 = (NumerosOrdenados.Count / 2) + 1;
        mediana = (NumerosOrdenados[posicaoMediana - 1] + NumerosOrdenados[posicaoMediana2 - 1]) / 2;
      } else {
        posicaoMediana = (NumerosOrdenados.Count + 1) / 2;
        mediana = NumerosOrdenados[posicaoMediana - 1];
      }
      return mediana;
    }

    public String CalculaModa() {
      String valorModa = "Default";
      KeyValuePair<Int32, Int32> moda = new KeyValuePair<Int32, Int32>();
      bool todosIguais = Ocorrencias.Values.All(v => v == Ocorrencias.Values.First());

      if (todosIguais) {
        valorModa = "Amodal";
      } else {
        foreach (KeyValuePair<Int32, Int32> ocorrencia in Ocorrencias) {
          if (ocorrencia.Value >= moda.Value) {
            if (ocorrencia.Value > moda.Value) {
              moda = ocorrencia;
              valorModa = moda.Key.ToString();
            } else if (ocorrencia.Value == moda.Value) {
              valorModa = valorModa + ", " + ocorrencia.Key;
            }
          }
        }
      }
      return valorModa;
    }

    public Double CalculaModaDePearson() {
      return 3 * CalculaMediana() - (2 * CalculaMedia());
    }

    public Double CalculaMedia() {
      return Soma / NumerosOrdenados.Count;
    }

    public Double CalculaVariancia() {
      Double diferenca = 0;
      Double media = CalculaMedia();
      foreach (var num in NumerosOrdenados) {
        diferenca += Math.Pow(num - media, 2);
      }
      return diferenca / NumerosOrdenados.Count;
    }

    public Double CalculaDesvioPadrao() {
      return Math.Sqrt(CalculaVariancia());
    }

  }

}