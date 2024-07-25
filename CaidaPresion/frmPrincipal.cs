using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            // frmGrafica frmGrafica = new frmGrafica();

            double.TryParse(txtDeltaP.Text, out double DeltaP);
            double.TryParse(txtVelLinealGas.Text, out double VelLinealGas);
            double.TryParse(txtJsl.Text, out double Jsl);

            if (DeltaP == 0)
            {
                MessageBox.Show("Delta p debe ser mayor que 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (VelLinealGas == 0)
            {
                MessageBox.Show("velocidad lineal gas debe ser mayor que 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Jsl == 0)
            {
                MessageBox.Show("Jsl debe ser mayor que 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double reynold = Utilities.CaidaPresion.CalcularValorReynold(DeltaP, VelLinealGas, Jsl);
            string[] columns = { "Variable", "Resultado" };
            DataTable dt = Utilities.CaidaPresion.GetDataTable(columns);
            string[] values = { "Reynold", reynold.ToString() };
            Utilities.CaidaPresion.SetRow(dt, columns, values);
            string[] values2 = { "Ub", Utilities.CaidaPresion.ub.ToString() };
            Utilities.CaidaPresion.SetRow(dt, columns, values2);
            string[] values3 = { "Hold up", Utilities.CaidaPresion.holdup.ToString() };
            Utilities.CaidaPresion.SetRow(dt, columns, values3);
            dataGridView1.DataSource = dt;
            // frmGrafica.ShowDialog();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnCalibrar.Enabled = radioButton1.Checked;
            txtDeltaP.ReadOnly = radioButton1.Checked;
            txtVelLinealGas.ReadOnly = radioButton1.Checked;
            txtVelLinealGas.Clear();
            txtDeltaP.Clear();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnCalibrar.Enabled = radioButton1.Checked;
            txtDeltaP.Focus();
        }

        private void btnCalibrar_Click(object sender, EventArgs e)
        {
            frmCalibracion form = new frmCalibracion();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmValoresIniciales frmValoresIniciales = new frmValoresIniciales { dt = Utilities.CaidaPresion.getInitialValues() };
            frmValoresIniciales.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDatosEntrada frmDatos = new frmDatosEntrada
            {
                dt1 = Utilities.CaidaPresion.getTerminos("P1", Utilities.CaidaPresion.PrimerTermino),
                dt2 = Utilities.CaidaPresion.getTerminos("ReynoldEnjambre", Utilities.CaidaPresion.ReynoldEnjambre),
                dt3 = Utilities.CaidaPresion.getTerminos("SegundoTermino", Utilities.CaidaPresion.SegundoTermino),
                dt4 = Utilities.CaidaPresion.getTerminos("TercerTermino", Utilities.CaidaPresion.TercerTermino),
                dt5 = Utilities.CaidaPresion.getTerminos("FuncionObjetivo", Utilities.CaidaPresion.FuncionObjetivo),
                dt6 = Utilities.CaidaPresion.getTerminos("DiametroBurbuja", Utilities.CaidaPresion.DiametroBurbuja)
            };
            frmDatos.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Now.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
