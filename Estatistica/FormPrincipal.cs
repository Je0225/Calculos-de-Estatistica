using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Estatistica {

  public partial class FormPrincipal : Form {

    private List<Int32> numeros { get; set; }

    private Calculos Calculo { get; set; }

    public FormPrincipal() {
      InitializeComponent();
      numeros = new List<Int32>(); ;
    }

    private void AdicionarValor() {
      if (!Int32.TryParse(tbNumero.Text.Trim(), out Int32 outroNumero)) {
        MessageBox.Show(@" não é um valor válido, digite um número inteiro!");
      } else {
        Int32 numeroInformado = Convert.ToInt32(tbNumero.Text);
        lvNumeros.Items.Add(new ListViewItem(new[] { numeroInformado.ToString() }) { Tag = numeroInformado });
        numeros.Add(numeroInformado);
      }
      tbNumero.Clear();
      tbNumero.Focus();
    }

    private void btnAdicionar_Click(object sender, EventArgs e) {
      AdicionarValor();
    }

    private void btnGerarRol_Click(object sender, EventArgs e) {
      if (numeros.Count == lvNumerosRol.Items.Count) {
        MessageBox.Show(@"Já existe um rol para os números informados");
        return;
      }
      Calculo = new Calculos(numeros);
      lvNumerosRol.Items.Clear();
      foreach (var numero in Calculo.NumerosOrdenados) {
        lvNumerosRol.Items.Add(new ListViewItem(new[] { numero.ToString() }) { Tag = numero });
      }
    }

    private void btnCalcular_Click(object sender, EventArgs e) {
      if (Calculo.NumerosOrdenados.Count == 0 && numeros.Count > 0) {
        MessageBox.Show(@"Clique no botão 'Gerar Rol' antes de calcular os valores");
        return;
      }
      if (numeros.Count == 0) {
        MessageBox.Show(@"Não há valores para calcular, informe os números e clique em 'Gerar Rol' antes de calcular os valores");
        return;
      }
      CalculaEPreecheLabels();
      tbNumero.Focus();
    }

    private void tbNumero_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        AdicionarValor();
      }
    }

    private void tbNumero_KeyPress(object sender, KeyPressEventArgs e) {
      e.Handled = !Char.IsDigit(e.KeyChar) &&
          !e.KeyChar.Equals((Char)Keys.Back) &&
          !e.KeyChar.Equals((Char)Keys.Enter);
    }

    private void CalculaEPreecheLabels() {
      Calculos calculos = new Calculos(Calculo.NumerosOrdenados);

      lbMaiorNumeroResult.Text = calculos.ValorMaximo.ToString();
      lbMenorNumeroResult.Text = calculos.ValorMinimo.ToString();
      lbModaResult.Text = calculos.CalculaModa();
      lbVarianciaResult.Text = calculos.CalculaVariancia().ToString("F");
      lbDesvioPadraoResult.Text = calculos.CalculaDesvioPadrao().ToString("F");
      lbModaPearsonResult.Text = calculos.CalculaModaDePearson().ToString("F");
      lbMediaResult.Text = calculos.CalculaMedia().ToString("F");
      lbMedianaResult.Text = calculos.CalculaMediana().ToString("F");
    }

    private void btnLimpar_Click(object sender, EventArgs e) {
      numeros.Clear();
      Calculo.NumerosOrdenados.Clear();
      lvNumeros.Items.Clear();
      lvNumerosRol.Items.Clear();

      lbMaiorNumeroResult.Text = "";
      lbMenorNumeroResult.Text = "";
      lbModaResult.Text = "";
      lbVarianciaResult.Text = "";
      lbDesvioPadraoResult.Text = "";
      lbModaPearsonResult.Text = "";
      lbMediaResult.Text = "";
      lbMedianaResult.Text = "";
    }
  }

}