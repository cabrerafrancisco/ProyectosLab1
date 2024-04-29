using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralaApp
{
    public partial class frmGenerala : Form
    {
        public frmGenerala()
        {
            InitializeComponent();
        }

        Random r = new Random();
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Int32 dado1 = r.Next(1, 7);
            Int32 dado2 = r.Next(1, 7);
            Int32 dado3 = r.Next(1, 7);
            Int32 dado4 = r.Next(1, 7);
            Int32 dado5 = r.Next(1, 7);

            switch (dado1)
            {
                case 1:
                    pctDado1.Image = GeneralaApp.Properties.Resources.dado1;
                    break;
                case 2:
                    pctDado1.Image = GeneralaApp.Properties.Resources.dado2;
                    break;
                case 3:
                    pctDado1.Image = GeneralaApp.Properties.Resources.dado3;
                    break;
                case 4:
                    pctDado1.Image = GeneralaApp.Properties.Resources.dado4;
                    break;
                case 5:
                    pctDado1.Image = GeneralaApp.Properties.Resources.dado5;
                    break;
                case 6:
                    pctDado1.Image = GeneralaApp.Properties.Resources.dado6;
                    break;
            }
            switch (dado2)
            {
                case 1:
                    pctDado2.Image = GeneralaApp.Properties.Resources.dado1;
                    break;
                case 2:
                    pctDado2.Image = GeneralaApp.Properties.Resources.dado2;
                    break;
                case 3:
                    pctDado2.Image = GeneralaApp.Properties.Resources.dado3;
                    break;
                case 4:
                    pctDado2.Image = GeneralaApp.Properties.Resources.dado4;
                    break;
                case 5:
                    pctDado2.Image = GeneralaApp.Properties.Resources.dado5;
                    break;
                case 6:
                    pctDado2.Image = GeneralaApp.Properties.Resources.dado6;
                    break;
            }
            switch (dado3)
            {
                case 1:
                    pctDado3.Image = GeneralaApp.Properties.Resources.dado1;
                    break;
                case 2:
                    pctDado3.Image = GeneralaApp.Properties.Resources.dado2;
                    break;
                case 3:
                    pctDado3.Image = GeneralaApp.Properties.Resources.dado3;
                    break;
                case 4:
                    pctDado3.Image = GeneralaApp.Properties.Resources.dado4;
                    break;
                case 5:
                    pctDado3.Image = GeneralaApp.Properties.Resources.dado5;
                    break;
                case 6:
                    pctDado3.Image = GeneralaApp.Properties.Resources.dado6;
                    break;
            }
            switch (dado4)
            {
                case 1:
                    pctDado4.Image = GeneralaApp.Properties.Resources.dado1;
                    break;
                case 2:
                    pctDado4.Image = GeneralaApp.Properties.Resources.dado2;
                    break;
                case 3:
                    pctDado4.Image = GeneralaApp.Properties.Resources.dado3;
                    break;
                case 4:
                    pctDado4.Image = GeneralaApp.Properties.Resources.dado4;
                    break;
                case 5:
                    pctDado4.Image = GeneralaApp.Properties.Resources.dado5;
                    break;
                case 6:
                    pctDado4.Image = GeneralaApp.Properties.Resources.dado6;
                    break;
            }
            switch (dado5)
            {
                case 1:
                    pctDado5.Image = GeneralaApp.Properties.Resources.dado1;
                    break;
                case 2:
                    pctDado5.Image = GeneralaApp.Properties.Resources.dado2;
                    break;
                case 3:
                    pctDado5.Image = GeneralaApp.Properties.Resources.dado3;
                    break;
                case 4:
                    pctDado5.Image = GeneralaApp.Properties.Resources.dado4;
                    break;
                case 5:
                    pctDado5.Image = GeneralaApp.Properties.Resources.dado5;
                    break;
                case 6:
                    pctDado5.Image = GeneralaApp.Properties.Resources.dado6;
                    break;
            }

            if (dado1 == dado2 && dado2 == dado3 && dado3 == dado4 && dado4 == dado5)
            {
                lblResultado.Text = "Generala!!!";
                btnJugar.Enabled = false;
                bntVolverJugar.Enabled = true;
                bntVolverJugar.BackColor = Color.Gold;
            }
            else
            {
                if (dado1 == dado2 && dado2 == dado3 && dado3 == dado4 ||
                    dado1 == dado2 && dado2 == dado3 && dado3 == dado5 ||
                    dado1 == dado2 && dado2 == dado4 && dado4 == dado5 ||
                    dado1 == dado3 && dado3 == dado4 && dado4 == dado5 ||
                    dado2 == dado3 && dado3 == dado4 && dado4 == dado5)
                {
                    lblResultado.Text = "Poker!!!";
                    btnJugar.Enabled = false;
                    bntVolverJugar.Enabled = true;
                    bntVolverJugar.BackColor = Color.Gold;
                }/*
                if (dado1 == dado2 && dado2 == dado3 && dado3 == dado5)
                {
                    lblResultado.Text = "Poker!!!";
                    btnJugar.Enabled = false;
                    bntVolverJugar.Enabled = true;
                    bntVolverJugar.BackColor = Color.Gold;
                }
                if (dado1 == dado2 && dado2 == dado4 && dado4 == dado4)
                {
                    lblResultado.Text = "Poker!!!";
                    btnJugar.Enabled = false;
                    bntVolverJugar.Enabled = true;
                    bntVolverJugar.BackColor = Color.Gold;
                }
                if (dado1 == dado3 && dado3 == dado4 && dado4 == dado5)
                {
                    lblResultado.Text = "Poker!!!";
                    btnJugar.Enabled = false;
                    bntVolverJugar.Enabled = true;
                    bntVolverJugar.BackColor = Color.Gold;
                }
                if (dado2 == dado3 && dado3 == dado4 && dado4 == dado5)
                {
                    lblResultado.Text = "Poker!!!";
                    btnJugar.Enabled = false;
                    bntVolverJugar.Enabled = true;
                    bntVolverJugar.BackColor = Color.Gold;
                }*/

                else
                {
                    Int32 suma = dado1 + dado2 + dado3 + dado4 + dado5;
                    if((dado1 != dado2 && dado1 != dado3 && dado1 != dado4 && dado1 != dado5 &&
                        dado2 != dado3 && dado2 != dado4 && dado2 != dado5 &&
                        dado3 != dado4 && dado3 != dado5 &&
                        dado4 != dado5) && (suma == 15 || suma == 20))
                    {
                        lblResultado.Text = "Escalera!!!";
                        btnJugar.Enabled = false;
                        bntVolverJugar.Enabled = true;
                        bntVolverJugar.BackColor = Color.Gold;
                    }
                }



            }
        }

        private void bntVolverJugar_Click(object sender, EventArgs e)
        {
            btnJugar.Enabled = true;
            bntVolverJugar.Enabled = false;
            bntVolverJugar.BackColor = Color.Silver;
            lblResultado.Text = "";
            pctDado1.Image = GeneralaApp.Properties.Resources.dadoGirando;
            pctDado2.Image = GeneralaApp.Properties.Resources.dadoGirando;
            pctDado3.Image = GeneralaApp.Properties.Resources.dadoGirando;
            pctDado4.Image = GeneralaApp.Properties.Resources.dadoGirando;
            pctDado5.Image = GeneralaApp.Properties.Resources.dadoGirando;

        }
    }
}
