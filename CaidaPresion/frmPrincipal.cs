using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaidaPresion
{
    public partial class frmPrincipal : Form
    {        
        public frmPrincipal()
        {
            InitializeComponent();
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
           // frmGrafica frmGrafica = new frmGrafica();
            double.TryParse(txtDeltaP.Text, out double DeltaP);
            double.TryParse(txtVelLinealGas.Text, out double VelLinealGas);
            Utilities.Class1.GetCalculosHidrodinamicos(DeltaP, VelLinealGas);
           // frmGrafica.ShowDialog();
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnCalibrar.Enabled = radioButton1.Checked;
            txtDeltaP .ReadOnly = radioButton1.Checked;
            txtVelLinealGas.ReadOnly = radioButton1.Checked;
            txtVelLinealGas.Clear();
            txtDeltaP.Clear();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnCalibrar.Enabled = radioButton1.Checked;
            txtDeltaP.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalibrar_Click(object sender, EventArgs e)
        {

        }
    }
}
