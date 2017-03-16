namespace Buscaminas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttIniciar = new System.Windows.Forms.Button();
            this.tbTiempo = new System.Windows.Forms.TextBox();
            this.tbMinas = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMinas = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttIniciar
            // 
            this.bttIniciar.BackgroundImage = global::Buscaminas.Properties.Resources.carasonrienteminas;
            this.bttIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttIniciar.ImageIndex = 0;
            this.bttIniciar.Location = new System.Drawing.Point(171, 52);
            this.bttIniciar.Name = "bttIniciar";
            this.bttIniciar.Size = new System.Drawing.Size(58, 55);
            this.bttIniciar.TabIndex = 0;
            this.bttIniciar.TabStop = false;
            this.bttIniciar.UseVisualStyleBackColor = true;
            this.bttIniciar.Click += new System.EventHandler(this.bttIniciar_Click);
            // 
            // tbTiempo
            // 
            this.tbTiempo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTiempo.Location = new System.Drawing.Point(268, 79);
            this.tbTiempo.Name = "tbTiempo";
            this.tbTiempo.ReadOnly = true;
            this.tbTiempo.Size = new System.Drawing.Size(100, 22);
            this.tbTiempo.TabIndex = 2;
            this.tbTiempo.TabStop = false;
            // 
            // tbMinas
            // 
            this.tbMinas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbMinas.Location = new System.Drawing.Point(31, 79);
            this.tbMinas.Name = "tbMinas";
            this.tbMinas.ReadOnly = true;
            this.tbMinas.Size = new System.Drawing.Size(100, 22);
            this.tbMinas.TabIndex = 3;
            this.tbMinas.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carasonrienteminas.png");
            this.imageList1.Images.SetKeyName(1, "carastristeminas.png");
            this.imageList1.Images.SetKeyName(2, "mina.png");
            this.imageList1.Images.SetKeyName(3, "casilla.png");
            this.imageList1.Images.SetKeyName(4, "cero.png");
            this.imageList1.Images.SetKeyName(5, "flag.png");
            this.imageList1.Images.SetKeyName(6, "minabum.png");
            this.imageList1.Images.SetKeyName(7, "uno.png");
            this.imageList1.Images.SetKeyName(8, "dos.png");
            this.imageList1.Images.SetKeyName(9, "tres.png");
            this.imageList1.Images.SetKeyName(10, "cuatro.png");
            this.imageList1.Images.SetKeyName(11, "cinco.png");
            this.imageList1.Images.SetKeyName(12, "seis.png");
            this.imageList1.Images.SetKeyName(13, "siete.png");
            this.imageList1.Images.SetKeyName(14, "ocho.png");
            this.imageList1.Images.SetKeyName(15, "minamal.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jugarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jugarToolStripMenuItem
            // 
            this.jugarToolStripMenuItem.Name = "jugarToolStripMenuItem";
            this.jugarToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.jugarToolStripMenuItem.Text = "Jugar";
            this.jugarToolStripMenuItem.Click += new System.EventHandler(this.jugarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lbMinas
            // 
            this.lbMinas.AutoSize = true;
            this.lbMinas.Location = new System.Drawing.Point(47, 52);
            this.lbMinas.Name = "lbMinas";
            this.lbMinas.Size = new System.Drawing.Size(68, 17);
            this.lbMinas.TabIndex = 5;
            this.lbMinas.Text = "Nº minas:";
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Location = new System.Drawing.Point(288, 52);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(59, 17);
            this.lbTiempo.TabIndex = 6;
            this.lbTiempo.Text = "Tiempo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(422, 466);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.lbMinas);
            this.Controls.Add(this.tbMinas);
            this.Controls.Add(this.tbTiempo);
            this.Controls.Add(this.bttIniciar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Buscaminas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttIniciar;
        private System.Windows.Forms.TextBox tbTiempo;
        private System.Windows.Forms.TextBox tbMinas;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lbMinas;
        private System.Windows.Forms.Label lbTiempo;
    }
}

