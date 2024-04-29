using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroRandom
{
    public partial class RandomForm : Form
    {
        public RandomForm()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void RandomForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Int32 num = r.Next(1,7);
            OpenFileDialog seleccionarImg = new OpenFileDialog();

            //textRandom.Text = "Su numero es --> " + Convert.ToString(num);


            switch (Convert.ToString(num))
            {
                case "1":
                    picDados.Image = NumeroRandom.Properties.Resources.dado1;
                    break;
                case "2":
                    picDados.Image = NumeroRandom.Properties.Resources.dado2;
                    break;
                case "3":
                    picDados.Image = NumeroRandom.Properties.Resources.dado3;
                    break;
                case "4":
                    picDados.Image = NumeroRandom.Properties.Resources.dado4;
                    break;
                case "5":
                    picDados.Image = NumeroRandom.Properties.Resources.dado5;
                    break;
                case "6":
                    picDados.Image = NumeroRandom.Properties.Resources.dado6;
                    break;
                default:
                    break;
            }



        }

        private void picDados_Click(object sender, EventArgs e)
        {

        }
    }
}
