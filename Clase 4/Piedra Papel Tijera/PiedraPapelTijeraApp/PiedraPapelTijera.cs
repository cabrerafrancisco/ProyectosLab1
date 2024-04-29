using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiedraPapelTijeraApp
{
    public partial class PiedraPapelTijera : Form
    {
        Random r = new Random(); //Objeto generador de Num

        Int32 J = 0; //Contador puntos Jugador
        Int32 C = 0; //Contador puntos PC
        Int32 P = 0; //Contador de Partidas jugadas
        
        public PiedraPapelTijera()
        {
            InitializeComponent();
        }


        private void imgPiedra_Click(object sender, EventArgs e)
        {
            picSelectPy.Image = PiedraPapelTijeraApp.Properties.Resources.piiedra;

            Int32 x = r.Next(1, 4);

            switch (x)
            {
                case 1:
                    picSelectPC.Image = PiedraPapelTijeraApp.Properties.Resources.piiedra;
                    if (J < 3 || C < 3)
                    {
                        lblResult.Text = "Empate!!!";
                    }
                    break;
                case 2:
                    picSelectPC.Image = PiedraPapelTijeraApp.Properties.Resources.paapel;
                    
                    if (J < 3 || C < 3)
                    {
                        lblResult.Text = "Perdiste!!!";
                        C++;
                    }
                    break;
                case 3:
                    picSelectPC.Image = PiedraPapelTijeraApp.Properties.Resources.tiijera;
                    if (J < 3 || C < 3)
                    {
                        lblResult.Text = "Ganaste!!!";
                        J++;
                    }
                    break;
            }
            if (J == 3)
            {
                lblResult.Text = "WIN";
                imgPapel.Enabled = false;
                imgPiedra.Enabled = false;
                imgTijera.Enabled = false;
                bntJugar.Enabled = true;
            }
            if (C == 3)
            {
                lblResult.Text = "LOSER";
                imgPapel.Enabled = false;
                imgPiedra.Enabled = false;
                imgTijera.Enabled = false;
                bntJugar.Enabled = true;
            }

            if (J < 3 || C < 3)
            {
                pointGamePy.Text = J.ToString();
                pointGamePc.Text = C.ToString();
            }
        }

        private void imgPapel_Click(object sender, EventArgs e)
        {
            picSelectPy.Image = PiedraPapelTijeraApp.Properties.Resources.paapel;
            
            Int32 x = r.Next(1, 4);

            switch (x)
            {
                case 1:
                    picSelectPC.Image = PiedraPapelTijeraApp.Properties.Resources.piiedra;
                    if (J < 3 || C < 3)
                    {
                        lblResult.Text = "Ganaste!!!";
                        J++;
                    }

                    break;
                case 2:
                    picSelectPC.Image = PiedraPapelTijeraApp.Properties.Resources.paapel;

                    if (J < 3 || C < 3)
                    {
                        lblResult.Text = "Empate!!!";
                    }

                    break;
                case 3:
                    picSelectPC.Image = PiedraPapelTijeraApp.Properties.Resources.tiijera;
                    if (J < 3 || C < 3)
                    {
                        lblResult.Text = "Perdiste!!!";
                        C++;
                    }
                    break;
            }
            if (J == 3)
            {

                lblResult.Text = "WIN :) !!!";
                imgPapel.Enabled = false;
                imgPiedra.Enabled = false;
                imgTijera.Enabled = false;
                bntJugar.Enabled = true;

            }
            if (C == 3)
            {
                lblResult.Text = "LOSER !!!";
                imgPapel.Enabled = false;
                imgPiedra.Enabled = false;
                imgTijera.Enabled = false;
                bntJugar.Enabled = true;
            }

            if (J < 3 || C < 3)
            {
                pointGamePy.Text = J.ToString();
                pointGamePc.Text = C.ToString();
                
            }
        }

        private void imgTijera_Click(object sender, EventArgs e)
        {
            picSelectPy.Image = PiedraPapelTijeraApp.Properties.Resources.tiijera;
            
            Int32 x = r.Next(1, 4);

            switch (x)
            {
                case 1:
                    picSelectPC.Image = PiedraPapelTijeraApp.Properties.Resources.piiedra;
                    if (J < 3 || C < 3)
                    {
                        lblResult.Text = "Perdiste!!!";
                        C++;
                    }
                    break;
                case 2:
                    picSelectPC.Image = PiedraPapelTijeraApp.Properties.Resources.paapel;
                    if (J < 3 || C < 3)
                    {
                        lblResult.Text = "Ganaste!!!";
                        J++;
                    }
                    break;
                case 3:
                    picSelectPC.Image = PiedraPapelTijeraApp.Properties.Resources.tiijera;
                    if (J < 3 || C < 3)
                    {
                        lblResult.Text = "Empate!!!";
                    }
                    break;
            }
            if (J == 3)
            {
                lblResult.Text = "WIN";
                imgPapel.Enabled = false;
                imgPiedra.Enabled = false;
                imgTijera.Enabled = false;
                bntJugar.Enabled = true;
            }
            if (C == 3)
            {
                lblResult.Text = "LOSER";
                imgPapel.Enabled = false;
                imgPiedra.Enabled = false;
                imgTijera.Enabled = false;
                bntJugar.Enabled = true;
            }
            if (J < 3 || C < 3)
            {
                pointGamePy.Text = J.ToString();
                pointGamePc.Text = C.ToString();
            }
        }
        private void bntJugar_Click(object sender, EventArgs e)
        {
            imgPapel.Enabled = true;
            imgPiedra.Enabled = true;
            imgTijera.Enabled = true;
            bntJugar.Enabled = false;
            pointGamePy.Text = "0";
            pointGamePc.Text = "0";
            J = 0;
            C = 0;
            P++;
            lblRondas.Text = "Rondas Jugadas: " + P;
            lblResult.Text = "";

        }
        private void picSelectPy_Click(object sender, EventArgs e)
        {

        }
        private void picSelectPC_Click(object sender, EventArgs e)
        {

        }

        private void pointGamePy_TextChanged(object sender, EventArgs e)
        {

        }

        private void puntosPy_Click(object sender, EventArgs e)
        {

        }

    }
}
