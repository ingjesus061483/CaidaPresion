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
    public partial class frmCalibracion : Form
    {
        Utilities.PuertoSerial puertoSerial;       
        public string Dato { get; set; }
        public frmCalibracion()
        {
            InitializeComponent();
            puertoSerial = new Utilities.PuertoSerial();
            Utilities. Control.Form=this;
            Utilities.Control.textBox = txtDeltaP;            
            Dato = "";
        }        
        private void Form1_Load(object sender, EventArgs e)
        {            
            Utilities.Control.FillCombo(cmbSerialPort, puertoSerial.Serialports);
            if (cmbSerialPort.Items .Count == 0)
            {
                MessageBox.Show("No hay Dispositivos disponibles","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                puertoSerial.OpenDevice(cmbSerialPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
    }
}
