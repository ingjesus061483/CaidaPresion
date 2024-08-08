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
using System.Windows.Forms.DataVisualization.Charting;

namespace CaidaPresion
{
    public partial class frmPrincipal : Form
    {
        ToolTip toolTip1;
        Chart grafica;

        public frmPrincipal()
        {
            InitializeComponent();
            grafica = new Chart { BackColor = Color.FromArgb(2, 11, 10) };

            toolTip1 = new ToolTip
            {

                // Set up the delays for the ToolTip.
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                // Force the ToolTip text to be displayed whether or not the form is active.
                ShowAlways = true
            };
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
            double reynold = Utilities.CaidaDePresion.CalcularValorReynold(DeltaP, VelLinealGas, Jsl);
            string[] columns = { "Variable", "Resultado" };
            DataTable dt = Utilities.Table.GetDataTable(columns);
            string[] values = { "Reynold", reynold.ToString() };
            Utilities.Table.SetRow(dt, columns, values);
            string[] values2 = { "Ub", Utilities.CaidaDePresion.ub.ToString() };
            Utilities.Table.SetRow(dt, columns, values2);
            string[] values3 = { "Hold up", Utilities.CaidaDePresion.holdup.ToString() };
            Utilities.Table.SetRow(dt, columns, values3);
            dataGridView1.DataSource = dt;
            grafica.DataSource = dt;
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
            txtDeltaP.Text = Utilities.Control.textBox.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmValoresIniciales frmValoresIniciales = new frmValoresIniciales { dt = Utilities.Table.GetInitialValues() };
            frmValoresIniciales.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDatosEntrada frmDatos = new frmDatosEntrada
            {
                dt1 = Utilities.Table.GetTerminos("P1", Utilities.CaidaDePresion.PrimerTermino),
                dt2 = Utilities.Table.GetTerminos("ReynoldEnjambre", Utilities.CaidaDePresion.ReynoldEnjambre),
                dt3 = Utilities.Table.GetTerminos("SegundoTermino", Utilities.CaidaDePresion.SegundoTermino),
                dt4 = Utilities.Table.GetTerminos("TercerTermino", Utilities.CaidaDePresion.TercerTermino),
                dt5 = Utilities.Table.GetTerminos("FuncionObjetivo", Utilities.CaidaDePresion.FuncionObjetivo),
                dt6 = Utilities.Table.GetTerminos("DiametroBurbuja", Utilities.CaidaDePresion.DiametroBurbuja)
            };
            frmDatos.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
            toolTip1.SetToolTip(button4, "Mostrar otros resultados");
            toolTip1.SetToolTip(button3, "Ver valores iniciales");
            toolTip1.SetToolTip(btnCalibrar, "Calibrar plc");
            toolTip1.SetToolTip(btnGraficar, "Graficar resultados");
            pnlGraficas .Controls.Add(grafica);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
