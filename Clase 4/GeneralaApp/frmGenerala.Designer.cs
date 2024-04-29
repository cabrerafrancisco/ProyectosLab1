
namespace GeneralaApp
{
    partial class frmGenerala
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
            this.pctDado1 = new System.Windows.Forms.PictureBox();
            this.pctDado5 = new System.Windows.Forms.PictureBox();
            this.pctDado4 = new System.Windows.Forms.PictureBox();
            this.pctDado3 = new System.Windows.Forms.PictureBox();
            this.pctDado2 = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.bntVolverJugar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado2)).BeginInit();
            this.SuspendLayout();
            // 
            // pctDado1
            // 
            this.pctDado1.Image = global::GeneralaApp.Properties.Resources.dadoGirando;
            this.pctDado1.Location = new System.Drawing.Point(18, 24);
            this.pctDado1.Name = "pctDado1";
            this.pctDado1.Size = new System.Drawing.Size(123, 120);
            this.pctDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDado1.TabIndex = 0;
            this.pctDado1.TabStop = false;
            // 
            // pctDado5
            // 
            this.pctDado5.Image = global::GeneralaApp.Properties.Resources.dadoGirando;
            this.pctDado5.Location = new System.Drawing.Point(534, 24);
            this.pctDado5.Name = "pctDado5";
            this.pctDado5.Size = new System.Drawing.Size(123, 120);
            this.pctDado5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDado5.TabIndex = 1;
            this.pctDado5.TabStop = false;
            // 
            // pctDado4
            // 
            this.pctDado4.Image = global::GeneralaApp.Properties.Resources.dadoGirando;
            this.pctDado4.Location = new System.Drawing.Point(405, 24);
            this.pctDado4.Name = "pctDado4";
            this.pctDado4.Size = new System.Drawing.Size(123, 120);
            this.pctDado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDado4.TabIndex = 2;
            this.pctDado4.TabStop = false;
            // 
            // pctDado3
            // 
            this.pctDado3.Image = global::GeneralaApp.Properties.Resources.dadoGirando;
            this.pctDado3.Location = new System.Drawing.Point(276, 24);
            this.pctDado3.Name = "pctDado3";
            this.pctDado3.Size = new System.Drawing.Size(123, 120);
            this.pctDado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDado3.TabIndex = 3;
            this.pctDado3.TabStop = false;
            // 
            // pctDado2
            // 
            this.pctDado2.Image = global::GeneralaApp.Properties.Resources.dadoGirando;
            this.pctDado2.Location = new System.Drawing.Point(147, 24);
            this.pctDado2.Name = "pctDado2";
            this.pctDado2.Size = new System.Drawing.Size(123, 120);
            this.pctDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctDado2.TabIndex = 4;
            this.pctDado2.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(18, 174);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(639, 78);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Beige;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(18, 270);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(639, 54);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // bntVolverJugar
            // 
            this.bntVolverJugar.BackColor = System.Drawing.Color.Silver;
            this.bntVolverJugar.Enabled = false;
            this.bntVolverJugar.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntVolverJugar.Location = new System.Drawing.Point(18, 330);
            this.bntVolverJugar.Name = "bntVolverJugar";
            this.bntVolverJugar.Size = new System.Drawing.Size(639, 54);
            this.bntVolverJugar.TabIndex = 7;
            this.bntVolverJugar.Text = "Volver a Jugar";
            this.bntVolverJugar.UseVisualStyleBackColor = false;
            this.bntVolverJugar.Click += new System.EventHandler(this.bntVolverJugar_Click);
            // 
            // frmGenerala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(675, 390);
            this.Controls.Add(this.bntVolverJugar);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pctDado2);
            this.Controls.Add(this.pctDado3);
            this.Controls.Add(this.pctDado4);
            this.Controls.Add(this.pctDado5);
            this.Controls.Add(this.pctDado1);
            this.Name = "frmGenerala";
            this.Text = "Generala";
            ((System.ComponentModel.ISupportInitialize)(this.pctDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDado2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDado1;
        private System.Windows.Forms.PictureBox pctDado5;
        private System.Windows.Forms.PictureBox pctDado4;
        private System.Windows.Forms.PictureBox pctDado3;
        private System.Windows.Forms.PictureBox pctDado2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button bntVolverJugar;
    }
}

