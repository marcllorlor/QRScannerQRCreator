namespace ExerciciQRSysTray
{
    partial class fmMainQRSys
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMainQRSys));
            this.niIcona = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmMenuStripIcona = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activarCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarQRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbText = new System.Windows.Forms.Label();
            this.btCrearQR = new System.Windows.Forms.Button();
            this.tbQR = new System.Windows.Forms.TextBox();
            this.imgQR = new System.Windows.Forms.PictureBox();
            this.cmMenuStripIcona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).BeginInit();
            this.SuspendLayout();
            // 
            // niIcona
            // 
            this.niIcona.ContextMenuStrip = this.cmMenuStripIcona;
            this.niIcona.Icon = ((System.Drawing.Icon)(resources.GetObject("niIcona.Icon")));
            this.niIcona.Text = "Programa per detectar QR";
            this.niIcona.Visible = true;
            this.niIcona.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niIcona_MouseClick);
            // 
            // cmMenuStripIcona
            // 
            this.cmMenuStripIcona.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmMenuStripIcona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activarCamaraToolStripMenuItem,
            this.desactivarCamaraToolStripMenuItem,
            this.generarQRToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.cmMenuStripIcona.Name = "cmMenuStripIcona";
            this.cmMenuStripIcona.Size = new System.Drawing.Size(199, 100);
            // 
            // activarCamaraToolStripMenuItem
            // 
            this.activarCamaraToolStripMenuItem.Name = "activarCamaraToolStripMenuItem";
            this.activarCamaraToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.activarCamaraToolStripMenuItem.Text = "ActivarCamara";
            this.activarCamaraToolStripMenuItem.Click += new System.EventHandler(this.activarCamaraToolStripMenuItem_Click);
            // 
            // desactivarCamaraToolStripMenuItem
            // 
            this.desactivarCamaraToolStripMenuItem.Name = "desactivarCamaraToolStripMenuItem";
            this.desactivarCamaraToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.desactivarCamaraToolStripMenuItem.Text = "DesactivarCamara";
            this.desactivarCamaraToolStripMenuItem.Click += new System.EventHandler(this.desactivarCamaraToolStripMenuItem_Click);
            // 
            // generarQRToolStripMenuItem
            // 
            this.generarQRToolStripMenuItem.Name = "generarQRToolStripMenuItem";
            this.generarQRToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.generarQRToolStripMenuItem.Text = "GenerarQR";
            this.generarQRToolStripMenuItem.Click += new System.EventHandler(this.generarQRToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(154, 27);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(104, 16);
            this.lbText.TabIndex = 8;
            this.lbText.Text = "Introdueix un text";
            // 
            // btCrearQR
            // 
            this.btCrearQR.BackColor = System.Drawing.Color.YellowGreen;
            this.btCrearQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCrearQR.Location = new System.Drawing.Point(542, 74);
            this.btCrearQR.Name = "btCrearQR";
            this.btCrearQR.Size = new System.Drawing.Size(105, 33);
            this.btCrearQR.TabIndex = 7;
            this.btCrearQR.Text = "Crear QR";
            this.btCrearQR.UseVisualStyleBackColor = false;
            this.btCrearQR.Click += new System.EventHandler(this.btCrearQR_Click);
            // 
            // tbQR
            // 
            this.tbQR.Location = new System.Drawing.Point(153, 46);
            this.tbQR.Name = "tbQR";
            this.tbQR.Size = new System.Drawing.Size(494, 22);
            this.tbQR.TabIndex = 6;
            // 
            // imgQR
            // 
            this.imgQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgQR.Location = new System.Drawing.Point(153, 74);
            this.imgQR.Name = "imgQR";
            this.imgQR.Size = new System.Drawing.Size(350, 350);
            this.imgQR.TabIndex = 5;
            this.imgQR.TabStop = false;
            // 
            // fmMainQRSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 450);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btCrearQR);
            this.Controls.Add(this.tbQR);
            this.Controls.Add(this.imgQR);
            this.Name = "fmMainQRSys";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CodiExemple";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMainQRSys_FormClosing);
            this.Load += new System.EventHandler(this.fmMainQRSys_Load);
            this.cmMenuStripIcona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niIcona;
        private System.Windows.Forms.ContextMenuStrip cmMenuStripIcona;
        private System.Windows.Forms.ToolStripMenuItem activarCamaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desactivarCamaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarQRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btCrearQR;
        private System.Windows.Forms.TextBox tbQR;
        private System.Windows.Forms.PictureBox imgQR;
    }
}

