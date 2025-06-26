namespace Estatistica
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.tbNumero = new System.Windows.Forms.TextBox();
      this.btnAdicionar = new System.Windows.Forms.Button();
      this.lvNumeros = new System.Windows.Forms.ListView();
      this.gbNumerosDigitados = new System.Windows.Forms.GroupBox();
      this.btnGerarRol = new System.Windows.Forms.Button();
      this.gbRol = new System.Windows.Forms.GroupBox();
      this.lvNumerosRol = new System.Windows.Forms.ListView();
      this.btnCalcular = new System.Windows.Forms.Button();
      this.cbResultados = new System.Windows.Forms.GroupBox();
      this.btnLimpar = new System.Windows.Forms.Button();
      this.lbDesvioPadraoResult = new System.Windows.Forms.Label();
      this.lbVarianciaResult = new System.Windows.Forms.Label();
      this.lbMenorNumeroResult = new System.Windows.Forms.Label();
      this.lbMaiorNumeroResult = new System.Windows.Forms.Label();
      this.lbMedianaResult = new System.Windows.Forms.Label();
      this.lbModaPearsonResult = new System.Windows.Forms.Label();
      this.lbModaResult = new System.Windows.Forms.Label();
      this.lbMediaResult = new System.Windows.Forms.Label();
      this.lbModaDePearson = new System.Windows.Forms.Label();
      this.lbDesvioPadrao = new System.Windows.Forms.Label();
      this.lbVariancia = new System.Windows.Forms.Label();
      this.lbMenorNumero = new System.Windows.Forms.Label();
      this.lbMaiorNumero = new System.Windows.Forms.Label();
      this.lbMediana = new System.Windows.Forms.Label();
      this.lbModa = new System.Windows.Forms.Label();
      this.lbMedia = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.gbNumerosDigitados.SuspendLayout();
      this.gbRol.SuspendLayout();
      this.cbResultados.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbNumero
      // 
      this.tbNumero.AcceptsReturn = true;
      this.tbNumero.AllowDrop = true;
      this.tbNumero.Cursor = System.Windows.Forms.Cursors.Default;
      this.tbNumero.Location = new System.Drawing.Point(6, 18);
      this.tbNumero.Name = "tbNumero";
      this.tbNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.tbNumero.Size = new System.Drawing.Size(212, 20);
      this.tbNumero.TabIndex = 1;
      this.tbNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumero_KeyDown);
      this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
      // 
      // btnAdicionar
      // 
      this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnAdicionar.Location = new System.Drawing.Point(223, 18);
      this.btnAdicionar.Name = "btnAdicionar";
      this.btnAdicionar.Size = new System.Drawing.Size(82, 21);
      this.btnAdicionar.TabIndex = 2;
      this.btnAdicionar.Text = "Adicionar";
      this.btnAdicionar.UseVisualStyleBackColor = true;
      this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
      // 
      // lvNumeros
      // 
      this.lvNumeros.HideSelection = false;
      this.lvNumeros.Location = new System.Drawing.Point(6, 19);
      this.lvNumeros.Name = "lvNumeros";
      this.lvNumeros.Size = new System.Drawing.Size(298, 65);
      this.lvNumeros.TabIndex = 0;
      this.lvNumeros.TabStop = false;
      this.lvNumeros.UseCompatibleStateImageBehavior = false;
      // 
      // gbNumerosDigitados
      // 
      this.gbNumerosDigitados.BackColor = System.Drawing.SystemColors.Control;
      this.gbNumerosDigitados.Controls.Add(this.btnGerarRol);
      this.gbNumerosDigitados.Controls.Add(this.lvNumeros);
      this.gbNumerosDigitados.Cursor = System.Windows.Forms.Cursors.Default;
      this.gbNumerosDigitados.ForeColor = System.Drawing.SystemColors.ControlText;
      this.gbNumerosDigitados.Location = new System.Drawing.Point(12, 57);
      this.gbNumerosDigitados.Name = "gbNumerosDigitados";
      this.gbNumerosDigitados.Padding = new System.Windows.Forms.Padding(4);
      this.gbNumerosDigitados.Size = new System.Drawing.Size(310, 117);
      this.gbNumerosDigitados.TabIndex = 3;
      this.gbNumerosDigitados.TabStop = false;
      this.gbNumerosDigitados.Text = "Números digitados";
      this.gbNumerosDigitados.UseCompatibleTextRendering = true;
      // 
      // btnGerarRol
      // 
      this.btnGerarRol.Location = new System.Drawing.Point(223, 89);
      this.btnGerarRol.Name = "btnGerarRol";
      this.btnGerarRol.Size = new System.Drawing.Size(82, 21);
      this.btnGerarRol.TabIndex = 1;
      this.btnGerarRol.Text = "Gerar Rol";
      this.btnGerarRol.UseVisualStyleBackColor = true;
      this.btnGerarRol.Click += new System.EventHandler(this.btnGerarRol_Click);
      // 
      // gbRol
      // 
      this.gbRol.Controls.Add(this.lvNumerosRol);
      this.gbRol.Controls.Add(this.btnCalcular);
      this.gbRol.Location = new System.Drawing.Point(12, 176);
      this.gbRol.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
      this.gbRol.Name = "gbRol";
      this.gbRol.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
      this.gbRol.Size = new System.Drawing.Size(310, 119);
      this.gbRol.TabIndex = 4;
      this.gbRol.TabStop = false;
      this.gbRol.Text = "Rol dos números";
      // 
      // lvNumerosRol
      // 
      this.lvNumerosRol.HideSelection = false;
      this.lvNumerosRol.Location = new System.Drawing.Point(6, 22);
      this.lvNumerosRol.Name = "lvNumerosRol";
      this.lvNumerosRol.Size = new System.Drawing.Size(298, 65);
      this.lvNumerosRol.TabIndex = 0;
      this.lvNumerosRol.TabStop = false;
      this.lvNumerosRol.UseCompatibleStateImageBehavior = false;
      // 
      // btnCalcular
      // 
      this.btnCalcular.Location = new System.Drawing.Point(223, 93);
      this.btnCalcular.Name = "btnCalcular";
      this.btnCalcular.Size = new System.Drawing.Size(82, 21);
      this.btnCalcular.TabIndex = 5;
      this.btnCalcular.Text = "Calcular";
      this.btnCalcular.UseVisualStyleBackColor = true;
      this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
      // 
      // cbResultados
      // 
      this.cbResultados.Controls.Add(this.btnLimpar);
      this.cbResultados.Controls.Add(this.lbDesvioPadraoResult);
      this.cbResultados.Controls.Add(this.lbVarianciaResult);
      this.cbResultados.Controls.Add(this.lbMenorNumeroResult);
      this.cbResultados.Controls.Add(this.lbMaiorNumeroResult);
      this.cbResultados.Controls.Add(this.lbMedianaResult);
      this.cbResultados.Controls.Add(this.lbModaPearsonResult);
      this.cbResultados.Controls.Add(this.lbModaResult);
      this.cbResultados.Controls.Add(this.lbMediaResult);
      this.cbResultados.Controls.Add(this.lbModaDePearson);
      this.cbResultados.Controls.Add(this.lbDesvioPadrao);
      this.cbResultados.Controls.Add(this.lbVariancia);
      this.cbResultados.Controls.Add(this.lbMenorNumero);
      this.cbResultados.Controls.Add(this.lbMaiorNumero);
      this.cbResultados.Controls.Add(this.lbMediana);
      this.cbResultados.Controls.Add(this.lbModa);
      this.cbResultados.Controls.Add(this.lbMedia);
      this.cbResultados.Location = new System.Drawing.Point(12, 296);
      this.cbResultados.Name = "cbResultados";
      this.cbResultados.Size = new System.Drawing.Size(310, 226);
      this.cbResultados.TabIndex = 23;
      this.cbResultados.TabStop = false;
      this.cbResultados.Text = "Resultados";
      // 
      // btnLimpar
      // 
      this.btnLimpar.Location = new System.Drawing.Point(223, 199);
      this.btnLimpar.Name = "btnLimpar";
      this.btnLimpar.Size = new System.Drawing.Size(82, 21);
      this.btnLimpar.TabIndex = 39;
      this.btnLimpar.Text = "Limpar";
      this.btnLimpar.UseVisualStyleBackColor = true;
      this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
      // 
      // lbDesvioPadraoResult
      // 
      this.lbDesvioPadraoResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lbDesvioPadraoResult.Location = new System.Drawing.Point(104, 199);
      this.lbDesvioPadraoResult.Margin = new System.Windows.Forms.Padding(3);
      this.lbDesvioPadraoResult.Name = "lbDesvioPadraoResult";
      this.lbDesvioPadraoResult.Size = new System.Drawing.Size(113, 21);
      this.lbDesvioPadraoResult.TabIndex = 38;
      this.lbDesvioPadraoResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
      this.lbDesvioPadraoResult.UseCompatibleTextRendering = true;
      // 
      // lbVarianciaResult
      // 
      this.lbVarianciaResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lbVarianciaResult.Location = new System.Drawing.Point(104, 173);
      this.lbVarianciaResult.Margin = new System.Windows.Forms.Padding(3);
      this.lbVarianciaResult.Name = "lbVarianciaResult";
      this.lbVarianciaResult.Size = new System.Drawing.Size(113, 21);
      this.lbVarianciaResult.TabIndex = 36;
      this.lbVarianciaResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbVarianciaResult.UseCompatibleTextRendering = true;
      // 
      // lbMenorNumeroResult
      // 
      this.lbMenorNumeroResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lbMenorNumeroResult.Location = new System.Drawing.Point(104, 145);
      this.lbMenorNumeroResult.Margin = new System.Windows.Forms.Padding(3);
      this.lbMenorNumeroResult.Name = "lbMenorNumeroResult";
      this.lbMenorNumeroResult.Size = new System.Drawing.Size(113, 21);
      this.lbMenorNumeroResult.TabIndex = 34;
      this.lbMenorNumeroResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbMenorNumeroResult.UseCompatibleTextRendering = true;
      // 
      // lbMaiorNumeroResult
      // 
      this.lbMaiorNumeroResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lbMaiorNumeroResult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbMaiorNumeroResult.Location = new System.Drawing.Point(104, 119);
      this.lbMaiorNumeroResult.Margin = new System.Windows.Forms.Padding(3);
      this.lbMaiorNumeroResult.Name = "lbMaiorNumeroResult";
      this.lbMaiorNumeroResult.Size = new System.Drawing.Size(113, 21);
      this.lbMaiorNumeroResult.TabIndex = 32;
      this.lbMaiorNumeroResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbMedianaResult
      // 
      this.lbMedianaResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lbMedianaResult.Location = new System.Drawing.Point(104, 94);
      this.lbMedianaResult.Margin = new System.Windows.Forms.Padding(3);
      this.lbMedianaResult.Name = "lbMedianaResult";
      this.lbMedianaResult.Size = new System.Drawing.Size(114, 21);
      this.lbMedianaResult.TabIndex = 30;
      this.lbMedianaResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbMedianaResult.UseCompatibleTextRendering = true;
      // 
      // lbModaPearsonResult
      // 
      this.lbModaPearsonResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lbModaPearsonResult.Location = new System.Drawing.Point(104, 67);
      this.lbModaPearsonResult.Margin = new System.Windows.Forms.Padding(3);
      this.lbModaPearsonResult.Name = "lbModaPearsonResult";
      this.lbModaPearsonResult.Size = new System.Drawing.Size(114, 21);
      this.lbModaPearsonResult.TabIndex = 28;
      this.lbModaPearsonResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbModaResult
      // 
      this.lbModaResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lbModaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbModaResult.Location = new System.Drawing.Point(104, 40);
      this.lbModaResult.Margin = new System.Windows.Forms.Padding(3);
      this.lbModaResult.Name = "lbModaResult";
      this.lbModaResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbModaResult.Size = new System.Drawing.Size(114, 21);
      this.lbModaResult.TabIndex = 26;
      this.lbModaResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbModaResult.UseMnemonic = false;
      // 
      // lbMediaResult
      // 
      this.lbMediaResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lbMediaResult.Location = new System.Drawing.Point(104, 14);
      this.lbMediaResult.Margin = new System.Windows.Forms.Padding(3);
      this.lbMediaResult.Name = "lbMediaResult";
      this.lbMediaResult.Size = new System.Drawing.Size(114, 21);
      this.lbMediaResult.TabIndex = 24;
      this.lbMediaResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbMediaResult.UseCompatibleTextRendering = true;
      // 
      // lbModaDePearson
      // 
      this.lbModaDePearson.Location = new System.Drawing.Point(8, 69);
      this.lbModaDePearson.Name = "lbModaDePearson";
      this.lbModaDePearson.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbModaDePearson.Size = new System.Drawing.Size(97, 13);
      this.lbModaDePearson.TabIndex = 27;
      this.lbModaDePearson.Text = "Moda de Pearson: ";
      this.lbModaDePearson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbDesvioPadrao
      // 
      this.lbDesvioPadrao.Location = new System.Drawing.Point(15, 204);
      this.lbDesvioPadrao.Name = "lbDesvioPadrao";
      this.lbDesvioPadrao.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbDesvioPadrao.Size = new System.Drawing.Size(87, 13);
      this.lbDesvioPadrao.TabIndex = 37;
      this.lbDesvioPadrao.Text = "Desvio Padrão:";
      this.lbDesvioPadrao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbVariancia
      // 
      this.lbVariancia.Location = new System.Drawing.Point(17, 177);
      this.lbVariancia.Name = "lbVariancia";
      this.lbVariancia.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbVariancia.Size = new System.Drawing.Size(87, 13);
      this.lbVariancia.TabIndex = 35;
      this.lbVariancia.Text = "Variância: ";
      this.lbVariancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbMenorNumero
      // 
      this.lbMenorNumero.Location = new System.Drawing.Point(18, 151);
      this.lbMenorNumero.Name = "lbMenorNumero";
      this.lbMenorNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbMenorNumero.Size = new System.Drawing.Size(87, 13);
      this.lbMenorNumero.TabIndex = 33;
      this.lbMenorNumero.Text = "Menor número: ";
      this.lbMenorNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbMaiorNumero
      // 
      this.lbMaiorNumero.Location = new System.Drawing.Point(17, 124);
      this.lbMaiorNumero.Name = "lbMaiorNumero";
      this.lbMaiorNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbMaiorNumero.Size = new System.Drawing.Size(87, 13);
      this.lbMaiorNumero.TabIndex = 31;
      this.lbMaiorNumero.Text = "Maior número:";
      this.lbMaiorNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbMediana
      // 
      this.lbMediana.Location = new System.Drawing.Point(18, 97);
      this.lbMediana.Name = "lbMediana";
      this.lbMediana.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbMediana.Size = new System.Drawing.Size(87, 13);
      this.lbMediana.TabIndex = 29;
      this.lbMediana.Text = "Mediana: ";
      this.lbMediana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbModa
      // 
      this.lbModa.Location = new System.Drawing.Point(18, 44);
      this.lbModa.Name = "lbModa";
      this.lbModa.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbModa.Size = new System.Drawing.Size(87, 13);
      this.lbModa.TabIndex = 25;
      this.lbModa.Text = "Moda: ";
      this.lbModa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lbMedia
      // 
      this.lbMedia.Location = new System.Drawing.Point(18, 18);
      this.lbMedia.Name = "lbMedia";
      this.lbMedia.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbMedia.Size = new System.Drawing.Size(87, 13);
      this.lbMedia.TabIndex = 23;
      this.lbMedia.Text = "Média: ";
      this.lbMedia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.tbNumero);
      this.groupBox2.Controls.Add(this.btnAdicionar);
      this.groupBox2.Location = new System.Drawing.Point(12, 8);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(310, 47);
      this.groupBox2.TabIndex = 24;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Informar Valor";
      // 
      // FormPrincipal
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.AutoScroll = true;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(334, 533);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.cbResultados);
      this.Controls.Add(this.gbNumerosDigitados);
      this.Controls.Add(this.gbRol);
      this.Cursor = System.Windows.Forms.Cursors.Default;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(350, 486);
      this.Name = "FormPrincipal";
      this.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Estatística";
      this.gbNumerosDigitados.ResumeLayout(false);
      this.gbRol.ResumeLayout(false);
      this.cbResultados.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView lvNumeros;
        private System.Windows.Forms.GroupBox gbNumerosDigitados;
        private System.Windows.Forms.Button btnGerarRol;
        private System.Windows.Forms.GroupBox gbRol;
        private System.Windows.Forms.ListView lvNumerosRol;
        private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.GroupBox cbResultados;
    private System.Windows.Forms.Button btnLimpar;
    private System.Windows.Forms.Label lbDesvioPadraoResult;
    private System.Windows.Forms.Label lbVarianciaResult;
    private System.Windows.Forms.Label lbMenorNumeroResult;
    private System.Windows.Forms.Label lbMaiorNumeroResult;
    private System.Windows.Forms.Label lbMedianaResult;
    private System.Windows.Forms.Label lbModaPearsonResult;
    private System.Windows.Forms.Label lbModaResult;
    private System.Windows.Forms.Label lbMediaResult;
    private System.Windows.Forms.Label lbModaDePearson;
    private System.Windows.Forms.Label lbDesvioPadrao;
    private System.Windows.Forms.Label lbVariancia;
    private System.Windows.Forms.Label lbMenorNumero;
    private System.Windows.Forms.Label lbMaiorNumero;
    private System.Windows.Forms.Label lbMediana;
    private System.Windows.Forms.Label lbModa;
    private System.Windows.Forms.Label lbMedia;
    private System.Windows.Forms.GroupBox groupBox2;
  }
}

