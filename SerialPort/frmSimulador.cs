using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PuertoSerie
{
    public partial class frmSimulador : Form
    {        
        Utilities.PuertoSerial puertoserial;
        public frmSimulador()
        {
            InitializeComponent();
            puertoserial = new Utilities.PuertoSerial();  
        }
        private void btnCalibrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( txtDeltaP.Text))
            {
                MessageBox.Show("Delta p debe ser mayor que 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;         
            }
            puertoserial.WriteData(txtDeltaP.Text);
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puertoserial. OpenDevice(cmbSerialPort.Text);
            txtDeltaP.Text = string.Empty;
        }

        private void frmSimulador_Load(object sender, EventArgs e)
        {
            Utilities.Control. FillCombo(cmbStopBits,puertoserial. StopBits);
            Utilities.Control.  FillCombo(cmbParity,puertoserial.Parities);
            Utilities.Control.FillCombo(cmbSerialPort,puertoserial.Serialports );            
        }
    }
}
