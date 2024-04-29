
namespace NumeroRandom
{
    partial class RandomForm
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.picDados = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(170, 363);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(205, 48);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Generar Numero";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // picDados
            // 
            this.picDados.BackgroundImage = global::NumeroRandom.Properties.Resources.dadoGirando;
            this.picDados.Image = global::NumeroRandom.Properties.Resources.dadoGirando;
            this.picDados.Location = new System.Drawing.Point(106, 12);
            this.picDados.Name = "picDados";
            this.picDados.Size = new System.Drawing.Size(340, 329);
            this.picDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDados.TabIndex = 2;
            this.picDados.TabStop = false;
            this.picDados.Click += new System.EventHandler(this.picDados_Click);
            // 
            // RandomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 423);
            this.Controls.Add(this.picDados);
            this.Controls.Add(this.btnRandom);
            this.Name = "RandomForm";
            this.Text = "Numero Aleatorio";
            this.Load += new System.EventHandler(this.RandomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.PictureBox picDados;
    }
}

