using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosta_Markovic
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            txtboxKvadratura.Clear();
            txtboxLokacija.Clear();
            cbxGaraza.Checked= false;
            cbxGrejanje.Checked = false;    
            cbxKablovska.Checked = false;   
            cbxLift.Checked= false;
            richTextBox1.Clear();
            txtboxLokacija.Focus();
            
            
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {

            string ispis = "";
            

            ispis += txtboxLokacija.Text+ "\n";
            ispis += txtboxKvadratura.Text + "m2"+"\n";
            if (rbtnKuca.Checked)
            {
                ispis += "Kuca"+"\n";

            }
            else if (rbtnStan.Checked)
            {
                ispis += "Stan" + "\n";

            }
            else 
            {
                ispis += "Plac" + "\n";

            }
           if(cbxGaraza.Checked) { 
                ispis+="Garaza" + "\n"; 
            }
           if(cbxGrejanje.Checked)
            {
                ispis += "Grejanje" + "\n";

            }
            if (cbxLift.Checked)
                {
                ispis += "Lift" + "\n";

            }
            if(cbxKablovska.Checked)
            {
                ispis += "Lift" + "\n";
            }
            richTextBox1.Text=ispis;



        }
    }
}
