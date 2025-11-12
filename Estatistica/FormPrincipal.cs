using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Estatistica.Entidades;

namespace Estatistica {

  public partial class FormPrincipal : Form {

    private List<Int32> numeros { get; }

    private CalculadorDoForm calculadorDoForm { get; set; }

    public FormPrincipal() {
      InitializeComponent();
      numeros = new List<Int32>();
      tbNumero.Select();
    }

    private void AddValorListasNumeros() {
      if (!PodeAdicionarNumero()) {
        return;
      }
      Int32 numeroInformado = Convert.ToInt32(tbNumero.Text);
      lvNumeros.Items.Add(new ListViewItem(new[] { numeroInformado.ToString() }));
      numeros.Add(numeroInformado);
      tbNumero.Clear();
      tbNumero.Select();
    }

    private void PopulaListasRol() {
      if (!PodeGerarRol()) {
        return;
      }
      calculadorDoForm = new CalculadorDoForm(numeros);
      lvNumerosRol.Items.Clear();
      foreach (var numero in calculadorDoForm.Rol) {
        lvNumerosRol.Items.Add(new ListViewItem(new[] { numero.ToString() }));
      }
    }

    private void Calcular() {
      if (!PodeCalcular()) {
        return;
      }
      PreecheCampos();
      btnLimpar.Select();
    }

    private void PreecheCampos() {
      lbMaiorNumeroResult.Text = calculadorDoForm.ValorMaximo.ToString();
      lbMenorNumeroResult.Text = calculadorDoForm.ValorMinimo.ToString();
      lbModaResult.Text = calculadorDoForm.Moda;
      lbVarianciaResult.Text = calculadorDoForm.Variancia.ToString("F");
      lbDesvioPadraoResult.Text = calculadorDoForm.DesvioPadrao.ToString("F");
      lbModaPearsonResult.Text = calculadorDoForm.ModaDePearson.ToString("F");
      lbMediaResult.Text = calculadorDoForm.Media.ToString("F");
      lbMedianaResult.Text = calculadorDoForm.Mediana.ToString("F");
    }

    private void LimpaCampos() {
      numeros.Clear();
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

      tbNumero.Select();
    }

    private Boolean PodeGerarRol() {
      if (numeros.Count == lvNumerosRol.Items.Count) {
        MessageBox.Show(@"Já existe um rol para os números informados");
        return false;
      }
      return true;
    }

    private Boolean PodeCalcular() {
      if (lvNumerosRol.Items.Count == 0 && numeros.Count > 0) {
        MessageBox.Show(@"Clique no botão 'Gerar Rol' antes de calcular os valores");
        return false;
      }
      if (numeros.Count == 0) {
        MessageBox.Show(@"Não há valores para calcular, informe os números e clique em 'Gerar Rol' antes de calcular os valores");
        return false;
      }
      return true;
    }

    private Boolean PodeAdicionarNumero() {
      if (!Int32.TryParse(tbNumero.Text.Trim(), out Int32 outroNumero)) {
        MessageBox.Show(@" não é um valor válido, digite um número inteiro!");
        return false;
      }
      return true;
    }

    private void btnAdicionar_Click(Object sender, EventArgs e) {
      AddValorListasNumeros();
    }

    private void btnGerarRol_Click(Object sender, EventArgs e) {
      PopulaListasRol();
    }

    private void btnCalcular_Click(Object sender, EventArgs e) {
      Calcular();
    }

    private void btnLimpar_Click(Object sender, EventArgs e) {
      LimpaCampos();
    }

    private void tbNumero_KeyDown(Object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        AddValorListasNumeros();
      }
    }

    private void tbNumero_KeyPress(Object sender, KeyPressEventArgs e) {
      e.Handled = !Char.IsDigit(e.KeyChar) &&
          !e.KeyChar.Equals((Char)Keys.Back) &&
          !e.KeyChar.Equals((Char)Keys.Enter);
    }

  }

}