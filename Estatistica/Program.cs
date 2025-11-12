using System;
using System.Windows.Forms;
using Estatistica.Calculos;
using Estatistica.Registry;

namespace Estatistica {
  internal static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      RegistraCalculos();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormPrincipal());
    }

    static void RegistraCalculos() {
      CalculosRegistry.Register(typeof(CalculoMedia), new CalculoMedia());
      CalculosRegistry.Register(typeof(CalculoMediana), new CalculoMediana());
      CalculosRegistry.Register(typeof(CalculoModaPearson), new CalculoModaPearson());
      CalculosRegistry.Register(typeof(CalculoDesvioPadrao), new CalculoDesvioPadrao());
      CalculosRegistry.Register(typeof(CalculoVariancia), new CalculoVariancia());
      CalculosRegistry.Register(typeof(CalculoModa), new CalculoModa());
    }
  }
}
