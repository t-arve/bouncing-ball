namespace WinPelota
{
    partial class WinPelota
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
            this.botonSalir = new System.Windows.Forms.Button();
            this.pbCancha = new System.Windows.Forms.PictureBox();
            this.botonMostrar = new System.Windows.Forms.Button();
            this.timerAnimacion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCancha)).BeginInit();
            this.SuspendLayout();
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(713, 415);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 0;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // pbCancha
            // 
            this.pbCancha.BackColor = System.Drawing.Color.White;
            this.pbCancha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCancha.Location = new System.Drawing.Point(12, 12);
            this.pbCancha.Name = "pbCancha";
            this.pbCancha.Size = new System.Drawing.Size(776, 397);
            this.pbCancha.TabIndex = 1;
            this.pbCancha.TabStop = false;
            this.pbCancha.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCancha_Paint);
            // 
            // botonMostrar
            // 
            this.botonMostrar.Location = new System.Drawing.Point(614, 415);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(75, 23);
            this.botonMostrar.TabIndex = 2;
            this.botonMostrar.Text = "Mostrar";
            this.botonMostrar.UseVisualStyleBackColor = true;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // timerAnimacion
            // 
            this.timerAnimacion.Enabled = true;
            this.timerAnimacion.Interval = 1;
            this.timerAnimacion.Tick += new System.EventHandler(this.timerAnimacion_Tick);
            // 
            // WinPelota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.pbCancha);
            this.Controls.Add(this.botonSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "WinPelota";
            this.Text = "WinPelota";
            ((System.ComponentModel.ISupportInitialize)(this.pbCancha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.PictureBox pbCancha;
        private System.Windows.Forms.Button botonMostrar;
        private System.Windows.Forms.Timer timerAnimacion;
    }
}

