using System;
using System.Collections.Generic;
using Estatistica.Calculos.Contratos;

namespace Estatistica.Registry {
  internal static class CalculosRegistry {

    private static readonly Dictionary<Type,ICalculoDouble> calculosDouble = new Dictionary<Type,ICalculoDouble>();

    private static readonly Dictionary<Type, ICalculoString> calculosString = new Dictionary<Type, ICalculoString>();

    public static void Register(Type key, ICalculoDouble value) {
      calculosDouble.Add(key, value);
    }

    public static ICalculoDouble GetCalculoDouble(Type type) {
      return calculosDouble[type];
    }

    public static void Register(Type key, ICalculoString value) {
      calculosString.Add(key, value);
    }

    public static ICalculoString GetCalculoString(Type type) {
      return calculosString[type];
    }


  }
}
