using System.Data;
namespace CaidaPresion
{
    public partial class Form1 : Form
    {
        public Form1()
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmValoresIniciales frmValoresIniciales =new frmValoresIniciales { dt = Utilities .CaidaPresion .getInitialValues ()};

            frmValoresIniciales .ShowDialog();
        }
    }
}
