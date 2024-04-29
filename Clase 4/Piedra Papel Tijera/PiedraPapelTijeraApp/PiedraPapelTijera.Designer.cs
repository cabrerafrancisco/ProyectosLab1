
namespace PiedraPapelTijeraApp
{
    partial class PiedraPapelTijera
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
            this.picSelectPy = new System.Windows.Forms.PictureBox();
            this.picSelectPC = new System.Windows.Forms.PictureBox();
            this.pointGamePy = new System.Windows.Forms.TextBox();
            this.pointGamePc = new System.Windows.Forms.TextBox();
            this.gBoxSelect = new System.Windows.Forms.GroupBox();
            this.imgTijera = new System.Windows.Forms.PictureBox();
            this.imgPapel = new System.Windows.Forms.PictureBox();
            this.imgPiedra = new System.Windows.Forms.PictureBox();
            this.gBoxPartida = new System.Windows.Forms.GroupBox();
            this.lblRival = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bntJugar = new System.Windows.Forms.Button();
            this.lblRondas = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectPy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectPC)).BeginInit();
            this.gBoxSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTijera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPiedra)).BeginInit();
            this.gBoxPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSelectPy
            // 
            this.picSelectPy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSelectPy.Image = global::PiedraPapelTijeraApp.Properties.Resources.pregunta;
            this.picSelectPy.Location = new System.Drawing.Point(134, 150);
            this.picSelectPy.Name = "picSelectPy";
            this.picSelectPy.Size = new System.Drawing.Size(101, 102);
            this.picSelectPy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelectPy.TabIndex = 0;
            this.picSelectPy.TabStop = false;
            this.picSelectPy.Click += new System.EventHandler(this.picSelectPy_Click);
            // 
            // picSelectPC
            // 
            this.picSelectPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSelectPC.Image = global::PiedraPapelTijeraApp.Properties.Resources.pregunta;
            this.picSelectPC.Location = new System.Drawing.Point(516, 150);
            this.picSelectPC.Name = "picSelectPC";
            this.picSelectPC.Size = new System.Drawing.Size(101, 102);
            this.picSelectPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelectPC.TabIndex = 1;
            this.picSelectPC.TabStop = false;
            this.picSelectPC.Click += new System.EventHandler(this.picSelectPC_Click);
            // 
            // pointGamePy
            // 
            this.pointGamePy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointGamePy.Location = new System.Drawing.Point(283, 192);
            this.pointGamePy.Name = "pointGamePy";
            this.pointGamePy.Size = new System.Drawing.Size(19, 29);
            this.pointGamePy.TabIndex = 2;
            this.pointGamePy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointGamePy.TextChanged += new System.EventHandler(this.pointGamePy_TextChanged);
            // 
            // pointGamePc
            // 
            this.pointGamePc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointGamePc.Location = new System.Drawing.Point(449, 192);
            this.pointGamePc.Name = "pointGamePc";
            this.pointGamePc.Size = new System.Drawing.Size(19, 29);
            this.pointGamePc.TabIndex = 3;
            this.pointGamePc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gBoxSelect
            // 
            this.gBoxSelect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gBoxSelect.Controls.Add(this.imgTijera);
            this.gBoxSelect.Controls.Add(this.imgPapel);
            this.gBoxSelect.Controls.Add(this.imgPiedra);
            this.gBoxSelect.Location = new System.Drawing.Point(188, 342);
            this.gBoxSelect.Name = "gBoxSelect";
            this.gBoxSelect.Size = new System.Drawing.Size(393, 104);
            this.gBoxSelect.TabIndex = 4;
            this.gBoxSelect.TabStop = false;
            this.gBoxSelect.Text = "Seleccion";
            // 
            // imgTijera
            // 
            this.imgTijera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTijera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTijera.Image = global::PiedraPapelTijeraApp.Properties.Resources.tiijera;
            this.imgTijera.Location = new System.Drawing.Point(305, 20);
            this.imgTijera.Name = "imgTijera";
            this.imgTijera.Size = new System.Drawing.Size(82, 78);
            this.imgTijera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTijera.TabIndex = 2;
            this.imgTijera.TabStop = false;
            this.imgTijera.Click += new System.EventHandler(this.imgTijera_Click);
            // 
            // imgPapel
            // 
            this.imgPapel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPapel.Image = global::PiedraPapelTijeraApp.Properties.Resources.paapel;
            this.imgPapel.Location = new System.Drawing.Point(157, 20);
            this.imgPapel.Name = "imgPapel";
            this.imgPapel.Size = new System.Drawing.Size(82, 78);
            this.imgPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPapel.TabIndex = 1;
            this.imgPapel.TabStop = false;
            this.imgPapel.Click += new System.EventHandler(this.imgPapel_Click);
            // 
            // imgPiedra
            // 
            this.imgPiedra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPiedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPiedra.Image = global::PiedraPapelTijeraApp.Properties.Resources.piiedra;
            this.imgPiedra.Location = new System.Drawing.Point(7, 20);
            this.imgPiedra.Name = "imgPiedra";
            this.imgPiedra.Size = new System.Drawing.Size(82, 78);
            this.imgPiedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPiedra.TabIndex = 0;
            this.imgPiedra.TabStop = false;
            this.imgPiedra.Click += new System.EventHandler(this.imgPiedra_Click);
            // 
            // gBoxPartida
            // 
            this.gBoxPartida.Controls.Add(this.lblRondas);
            this.gBoxPartida.Controls.Add(this.lblResult);
            this.gBoxPartida.Controls.Add(this.lblRival);
            this.gBoxPartida.Controls.Add(this.lblName);
            this.gBoxPartida.Location = new System.Drawing.Point(113, 86);
            this.gBoxPartida.Name = "gBoxPartida";
            this.gBoxPartida.Size = new System.Drawing.Size(522, 225);
            this.gBoxPartida.TabIndex = 5;
            this.gBoxPartida.TabStop = false;
            this.gBoxPartida.Text = "Partida";
            // 
            // lblRival
            // 
            this.lblRival.AutoSize = true;
            this.lblRival.Location = new System.Drawing.Point(483, 45);
            this.lblRival.Name = "lblRival";
            this.lblRival.Size = new System.Drawing.Size(21, 13);
            this.lblRival.TabIndex = 1;
            this.lblRival.Text = "PC";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Player";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(181, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 40);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "PIEDRA, PAPEL O TIJERA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntJugar
            // 
            this.bntJugar.Location = new System.Drawing.Point(671, 415);
            this.bntJugar.Name = "bntJugar";
            this.bntJugar.Size = new System.Drawing.Size(75, 23);
            this.bntJugar.TabIndex = 2;
            this.bntJugar.Text = "Reiniciar";
            this.bntJugar.UseVisualStyleBackColor = true;
            this.bntJugar.Click += new System.EventHandler(this.bntJugar_Click);
            // 
            // lblRondas
            // 
            this.lblRondas.AutoSize = true;
            this.lblRondas.Location = new System.Drawing.Point(224, 202);
            this.lblRondas.Name = "lblRondas";
            this.lblRondas.Size = new System.Drawing.Size(90, 13);
            this.lblRondas.TabIndex = 8;
            this.lblRondas.Text = "Rondas Jugadas:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(203, 106);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 27);
            this.lblResult.TabIndex = 3;
            // 
            // PiedraPapelTijera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PiedraPapelTijeraApp.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gBoxSelect);
            this.Controls.Add(this.bntJugar);
            this.Controls.Add(this.pointGamePc);
            this.Controls.Add(this.pointGamePy);
            this.Controls.Add(this.picSelectPC);
            this.Controls.Add(this.picSelectPy);
            this.Controls.Add(this.gBoxPartida);
            this.Name = "PiedraPapelTijera";
            this.Text = "Piedra Papel Tijera";
            ((System.ComponentModel.ISupportInitialize)(this.picSelectPy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectPC)).EndInit();
            this.gBoxSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTijera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPiedra)).EndInit();
            this.gBoxPartida.ResumeLayout(false);
            this.gBoxPartida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSelectPy;
        private System.Windows.Forms.PictureBox picSelectPC;
        private System.Windows.Forms.TextBox pointGamePy;
        private System.Windows.Forms.TextBox pointGamePc;
        private System.Windows.Forms.GroupBox gBoxSelect;
        private System.Windows.Forms.GroupBox gBoxPartida;
        private System.Windows.Forms.Label lblRival;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgTijera;
        private System.Windows.Forms.PictureBox imgPapel;
        private System.Windows.Forms.PictureBox imgPiedra;
        private System.Windows.Forms.Button bntJugar;
        private System.Windows.Forms.Label lblRondas;
        private System.Windows.Forms.Label lblResult;
    }
}

