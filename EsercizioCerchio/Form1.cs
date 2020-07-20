using EsercizioCerchio.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercizioCerchio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            var raggioStringa = tbx_raggio.Text;
            var altezzaStringa = tbx_altezza.Text;
            double raggio;
            if (double.TryParse(raggioStringa, out raggio) && double.TryParse(altezzaStringa, out double altezza))
            {
                MostraDati(raggio, altezza);
            }
            else
            {
                MessageBox.Show("Inserire solo numeri per raggio e altezza!", "ERRORE");
                tbx_altezza.Text = "";
                tbx_raggio.Text = "";
            }
        }

        private void MostraDati(double raggio, double altezza)
        {
            var cerchio = new Cerchio(raggio);
            var sfera = new Sfera(raggio);
            var cilindro = new Cilindro(raggio, altezza);
            var cono = new Cono(raggio, altezza);
            var decimali = 2;

            tbx_cerchioArea.Text = Math.Round(cerchio.Area, decimali).ToString();
            tbx_cerchioCirconferenza.Text = Math.Round(cerchio.Circonferenza, decimali).ToString();
            tbx_cerchioDiametro.Text = Math.Round(cerchio.Diametro, decimali).ToString();

            tbx_sferaSuperficie.Text = Math.Round(sfera.Superficie, decimali).ToString();
            tbx_sferaVolume.Text = Math.Round(sfera.Volume, decimali).ToString();

            tbx_cilindroAreaLaterale.Text = Math.Round(cilindro.AreaLaterale, decimali).ToString();
            tbx_cilindroAreaTotale.Text = Math.Round(cilindro.AreaTotale, decimali).ToString();
            tbx_cilindroVolume.Text = Math.Round(cilindro.Volume, decimali).ToString();

            tbx_conoVolume.Text = Math.Round(cono.Volume, decimali).ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach(var control in this.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }else if(control is Panel)
                {
                    foreach (var item in ((Panel)control).Controls)
                    {
                        if (item is TextBox) ((TextBox)item).Text = string.Empty;
                    }
                }
            }

            //tbx_cerchioArea.Text = string.Empty;
            //tbx_cerchioCirconferenza.Text = "";
            //tbx_cerchioDiametro.Text = string.Empty;
            //tbx_sferaSuperficie.Text = string.Empty;
            //tbx_sferaVolume.Text = string.Empty;
            //tbx_cilindroAreaLaterale.Text = string.Empty;
            //tbx_cilindroAreaTotale.Text = string.Empty;
            //tbx_cilindroVolume.Text = string.Empty;
            //tbx_conoVolume.Text = string.Empty;
            //tbx_altezza.Text = string.Empty;
            //tbx_raggio.Text = string.Empty;
        }
    }
}
