namespace Caso1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCombos = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPlatosFuerte = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCantidadBebida = new System.Windows.Forms.Label();
            this.btnBebidasMas = new System.Windows.Forms.Button();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.lblBebidas = new System.Windows.Forms.Label();
            this.pnlAdicionales = new System.Windows.Forms.Panel();
            this.lblTotalCombo = new System.Windows.Forms.Label();
            this.lblCantidadAdicional = new System.Windows.Forms.Label();
            this.btnAdicionalesMas = new System.Windows.Forms.Button();
            this.cmbAditional = new System.Windows.Forms.ComboBox();
            this.lblAdicionales = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.lblOrdenes = new System.Windows.Forms.Label();
            this.lblTotalOrden = new System.Windows.Forms.Label();
            this.pnlCentral.SuspendLayout();
            this.pnlIzquierdo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAdicionales.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.pnlIzquierdo);
            this.pnlCentral.Controls.Add(this.pnlDerecho);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 0);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1103, 594);
            this.pnlCentral.TabIndex = 0;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.Controls.Add(this.panel3);
            this.pnlIzquierdo.Controls.Add(this.panel2);
            this.pnlIzquierdo.Controls.Add(this.panel1);
            this.pnlIzquierdo.Controls.Add(this.pnlAdicionales);
            this.pnlIzquierdo.Controls.Add(this.btnAgregar);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(763, 594);
            this.pnlIzquierdo.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbCombos);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 138);
            this.panel3.TabIndex = 5;
            // 
            // cmbCombos
            // 
            this.cmbCombos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCombos.FormattingEnabled = true;
            this.cmbCombos.Location = new System.Drawing.Point(0, 56);
            this.cmbCombos.Name = "cmbCombos";
            this.cmbCombos.Size = new System.Drawing.Size(763, 28);
            this.cmbCombos.TabIndex = 1;
            this.cmbCombos.SelectedIndexChanged += new System.EventHandler(this.cmbCombos_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(763, 56);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMBOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbPlatosFuerte);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 90);
            this.panel2.TabIndex = 3;
            // 
            // cmbPlatosFuerte
            // 
            this.cmbPlatosFuerte.FormattingEnabled = true;
            this.cmbPlatosFuerte.Location = new System.Drawing.Point(12, 26);
            this.cmbPlatosFuerte.Name = "cmbPlatosFuerte";
            this.cmbPlatosFuerte.Size = new System.Drawing.Size(727, 28);
            this.cmbPlatosFuerte.TabIndex = 1;
            this.cmbPlatosFuerte.SelectedIndexChanged += new System.EventHandler(this.cmbPlatosFuerte_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "PLATO FUERTE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCantidadBebida);
            this.panel1.Controls.Add(this.btnBebidasMas);
            this.panel1.Controls.Add(this.cmbBebidas);
            this.panel1.Controls.Add(this.lblBebidas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 153);
            this.panel1.TabIndex = 2;
            // 
            // lblCantidadBebida
            // 
            this.lblCantidadBebida.AutoSize = true;
            this.lblCantidadBebida.Location = new System.Drawing.Point(300, 82);
            this.lblCantidadBebida.Name = "lblCantidadBebida";
            this.lblCantidadBebida.Size = new System.Drawing.Size(17, 20);
            this.lblCantidadBebida.TabIndex = 12;
            this.lblCantidadBebida.Text = "0";
            // 
            // btnBebidasMas
            // 
            this.btnBebidasMas.Location = new System.Drawing.Point(166, 78);
            this.btnBebidasMas.Name = "btnBebidasMas";
            this.btnBebidasMas.Size = new System.Drawing.Size(94, 29);
            this.btnBebidasMas.TabIndex = 11;
            this.btnBebidasMas.Text = "Más";
            this.btnBebidasMas.UseVisualStyleBackColor = true;
            this.btnBebidasMas.Click += new System.EventHandler(this.btnBebidasMas_Click);
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(12, 44);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(727, 28);
            this.cmbBebidas.TabIndex = 2;
            this.cmbBebidas.SelectedIndexChanged += new System.EventHandler(this.cmbBebidas_SelectedIndexChanged);
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.Location = new System.Drawing.Point(301, 21);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(68, 20);
            this.lblBebidas.TabIndex = 0;
            this.lblBebidas.Text = "BEBIDAS";
            this.lblBebidas.Click += new System.EventHandler(this.lblBebidas_Click);
            // 
            // pnlAdicionales
            // 
            this.pnlAdicionales.Controls.Add(this.lblTotalCombo);
            this.pnlAdicionales.Controls.Add(this.lblCantidadAdicional);
            this.pnlAdicionales.Controls.Add(this.btnAdicionalesMas);
            this.pnlAdicionales.Controls.Add(this.cmbAditional);
            this.pnlAdicionales.Controls.Add(this.lblAdicionales);
            this.pnlAdicionales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdicionales.Location = new System.Drawing.Point(0, 381);
            this.pnlAdicionales.Name = "pnlAdicionales";
            this.pnlAdicionales.Size = new System.Drawing.Size(763, 161);
            this.pnlAdicionales.TabIndex = 1;
            this.pnlAdicionales.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdicionales_Paint);
            // 
            // lblTotalCombo
            // 
            this.lblTotalCombo.AutoSize = true;
            this.lblTotalCombo.Location = new System.Drawing.Point(674, 118);
            this.lblTotalCombo.Name = "lblTotalCombo";
            this.lblTotalCombo.Size = new System.Drawing.Size(17, 20);
            this.lblTotalCombo.TabIndex = 17;
            this.lblTotalCombo.Text = "0";
            // 
            // lblCantidadAdicional
            // 
            this.lblCantidadAdicional.AutoSize = true;
            this.lblCantidadAdicional.Location = new System.Drawing.Point(300, 113);
            this.lblCantidadAdicional.Name = "lblCantidadAdicional";
            this.lblCantidadAdicional.Size = new System.Drawing.Size(17, 20);
            this.lblCantidadAdicional.TabIndex = 16;
            this.lblCantidadAdicional.Text = "0";
            // 
            // btnAdicionalesMas
            // 
            this.btnAdicionalesMas.Location = new System.Drawing.Point(166, 109);
            this.btnAdicionalesMas.Name = "btnAdicionalesMas";
            this.btnAdicionalesMas.Size = new System.Drawing.Size(94, 29);
            this.btnAdicionalesMas.TabIndex = 15;
            this.btnAdicionalesMas.Text = "Más";
            this.btnAdicionalesMas.UseVisualStyleBackColor = true;
            this.btnAdicionalesMas.Click += new System.EventHandler(this.btnAdicionalesMas_Click);
            // 
            // cmbAditional
            // 
            this.cmbAditional.FormattingEnabled = true;
            this.cmbAditional.Location = new System.Drawing.Point(12, 75);
            this.cmbAditional.Name = "cmbAditional";
            this.cmbAditional.Size = new System.Drawing.Size(727, 28);
            this.cmbAditional.TabIndex = 13;
            this.cmbAditional.SelectedIndexChanged += new System.EventHandler(this.cmbAditional_SelectedIndexChanged);
            // 
            // lblAdicionales
            // 
            this.lblAdicionales.AutoSize = true;
            this.lblAdicionales.Location = new System.Drawing.Point(300, 32);
            this.lblAdicionales.Name = "lblAdicionales";
            this.lblAdicionales.Size = new System.Drawing.Size(102, 20);
            this.lblAdicionales.TabIndex = 0;
            this.lblAdicionales.Text = "ADICIONALES";
            this.lblAdicionales.Click += new System.EventHandler(this.lblAdicionales_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(0, 542);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(763, 52);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Añadir";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.Controls.Add(this.lblOrdenes);
            this.pnlDerecho.Controls.Add(this.lblTotalOrden);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDerecho.Location = new System.Drawing.Point(763, 0);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(340, 594);
            this.pnlDerecho.TabIndex = 0;
            // 
            // lblOrdenes
            // 
            this.lblOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrdenes.Location = new System.Drawing.Point(0, 0);
            this.lblOrdenes.Name = "lblOrdenes";
            this.lblOrdenes.Size = new System.Drawing.Size(340, 519);
            this.lblOrdenes.TabIndex = 1;
            this.lblOrdenes.Text = "Combos: ";
            // 
            // lblTotalOrden
            // 
            this.lblTotalOrden.AutoSize = true;
            this.lblTotalOrden.Location = new System.Drawing.Point(262, 542);
            this.lblTotalOrden.Name = "lblTotalOrden";
            this.lblTotalOrden.Size = new System.Drawing.Size(17, 20);
            this.lblTotalOrden.TabIndex = 0;
            this.lblTotalOrden.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 594);
            this.Controls.Add(this.pnlCentral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCentral.ResumeLayout(false);
            this.pnlIzquierdo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAdicionales.ResumeLayout(false);
            this.pnlAdicionales.PerformLayout();
            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Panel pnlAdicionales;
        private System.Windows.Forms.Label lblAdicionales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBebidas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbCombos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlatosFuerte;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.Label lblCantidadBebida;
        private System.Windows.Forms.Button btnBebidasMas;
        private System.Windows.Forms.Label lblCantidadAdicional;
        private System.Windows.Forms.Button btnAdicionalesMas;
        private System.Windows.Forms.ComboBox cmbAditional;
        private System.Windows.Forms.Label lblTotalCombo;
        private System.Windows.Forms.Label lblTotalOrden;
        private System.Windows.Forms.Label lblOrdenes;
    }
}

