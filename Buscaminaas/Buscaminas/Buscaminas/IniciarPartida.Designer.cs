namespace Buscaminas
{
    partial class IniciarPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarPartida));
            this.lbNuero = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.bttSalir = new System.Windows.Forms.Button();
            this.gbDificultad = new System.Windows.Forms.GroupBox();
            this.rbDificil = new System.Windows.Forms.RadioButton();
            this.rbIntermedio = new System.Windows.Forms.RadioButton();
            this.rbFacil = new System.Windows.Forms.RadioButton();
            this.gbDificultad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNuero
            // 
            this.lbNuero.AutoSize = true;
            this.lbNuero.Location = new System.Drawing.Point(87, 97);
            this.lbNuero.Name = "lbNuero";
            this.lbNuero.Size = new System.Drawing.Size(186, 17);
            this.lbNuero.TabIndex = 0;
            this.lbNuero.Text = "Número de filas y columnas:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(315, 94);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(186, 22);
            this.tbNumero.TabIndex = 1;
            this.tbNumero.TextChanged += new System.EventHandler(this.tbNumero_TextChanged);
            // 
            // bttAceptar
            // 
            this.bttAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttAceptar.Enabled = false;
            this.bttAceptar.Location = new System.Drawing.Point(125, 432);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(94, 33);
            this.bttAceptar.TabIndex = 2;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // bttSalir
            // 
            this.bttSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttSalir.Location = new System.Drawing.Point(403, 432);
            this.bttSalir.Name = "bttSalir";
            this.bttSalir.Size = new System.Drawing.Size(98, 33);
            this.bttSalir.TabIndex = 3;
            this.bttSalir.Text = "Salir";
            this.bttSalir.UseVisualStyleBackColor = true;
            // 
            // gbDificultad
            // 
            this.gbDificultad.Controls.Add(this.rbDificil);
            this.gbDificultad.Controls.Add(this.rbIntermedio);
            this.gbDificultad.Controls.Add(this.rbFacil);
            this.gbDificultad.Location = new System.Drawing.Point(81, 202);
            this.gbDificultad.Name = "gbDificultad";
            this.gbDificultad.Size = new System.Drawing.Size(462, 150);
            this.gbDificultad.TabIndex = 4;
            this.gbDificultad.TabStop = false;
            this.gbDificultad.Text = "Dificultad";
            // 
            // rbDificil
            // 
            this.rbDificil.AutoSize = true;
            this.rbDificil.Location = new System.Drawing.Point(344, 74);
            this.rbDificil.Name = "rbDificil";
            this.rbDificil.Size = new System.Drawing.Size(62, 21);
            this.rbDificil.TabIndex = 2;
            this.rbDificil.TabStop = true;
            this.rbDificil.Text = "Difícil";
            this.rbDificil.UseVisualStyleBackColor = true;
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.Location = new System.Drawing.Point(177, 74);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(95, 21);
            this.rbIntermedio.TabIndex = 1;
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = true;
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.Checked = true;
            this.rbFacil.Location = new System.Drawing.Point(28, 74);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(58, 21);
            this.rbFacil.TabIndex = 0;
            this.rbFacil.TabStop = true;
            this.rbFacil.Text = "Fácil";
            this.rbFacil.UseVisualStyleBackColor = true;
            // 
            // IniciarPartida
            // 
            this.AcceptButton = this.bttAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttSalir;
            this.ClientSize = new System.Drawing.Size(665, 534);
            this.Controls.Add(this.gbDificultad);
            this.Controls.Add(this.bttSalir);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNuero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IniciarPartida";
            this.Text = "Elige una opción...";
            this.gbDificultad.ResumeLayout(false);
            this.gbDificultad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNuero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.Button bttSalir;
        private System.Windows.Forms.GroupBox gbDificultad;
        private System.Windows.Forms.RadioButton rbDificil;
        private System.Windows.Forms.RadioButton rbIntermedio;
        private System.Windows.Forms.RadioButton rbFacil;
    }
}