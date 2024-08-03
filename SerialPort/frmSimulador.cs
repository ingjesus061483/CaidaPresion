using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace PuertoSerie
{

    public partial class frmSimulador : Form
    {
        SerialPort SerialPort;
        public frmSimulador()
        {
            InitializeComponent();
            SerialPort = new SerialPort();
        }
        void OpenDevice(string PortName)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
            }
            SerialPort.PortName = PortName;
            SerialPort.Open();
        }
        void FillCombo(ComboBox comboBox, Array arr)
        {
            foreach (var value in arr)
            {
                comboBox.Items.Add(value);
            }
        }
        private void btnCalibrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( txtDeltaP.Text))
            {
                MessageBox.Show("Delta p debe ser mayor que 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;         
            }
            SerialPort.Write(txtDeltaP.Text);
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenDevice(cmbSerialPort.Text);
            txtDeltaP.Text = string.Empty;
        }

        private void frmSimulador_Load(object sender, EventArgs e)
        {
            string[] serialports = SerialPort.GetPortNames();
            Array parities = Enum.GetValues(typeof(Parity));
            Array StopBits = Enum.GetValues(typeof(StopBits));          
            numBaudRate.Maximum = SerialPort.BaudRate;
            numBaudRate.Value = SerialPort.BaudRate;
            numDataBit.Value = SerialPort.DataBits;
            FillCombo(cmbStopBits, StopBits);
            FillCombo(cmbParity, parities);
            FillCombo(cmbSerialPort, serialports);

        }
    }
}
