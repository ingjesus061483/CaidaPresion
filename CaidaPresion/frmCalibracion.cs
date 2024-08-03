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
        SerialPort serialPort;
        public frmCalibracion()
        {
            InitializeComponent();
            string[] serialports = SerialPort.GetPortNames();
            foreach (string serialport in serialports)
            {
                cmbSerialPort.Items.Add(serialport);
            }
            serialPort = new SerialPort();
            serialPort.DataReceived += SerialPort_DataReceived;
            var valuesAsArray = Enum.GetValues(typeof(Parity));
            foreach (var value in valuesAsArray)
            {
                cmbParity.Items.Add(value);
            }
            numBaudRate.Maximum = serialPort.BaudRate;
            numBaudRate.Value = serialPort.BaudRate;
            numDataBit.Value = serialPort.DataBits;
            var valuesAsArray2 = Enum.GetValues(typeof(StopBits));
            foreach (var value in valuesAsArray2)
            {
                cmbStopBits.Items.Add(value);
            }

        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            string data = serialPort.ReadLine();;

            txtDeltaP.Text =data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            serialPort.PortName = cmbSerialPort.Text;
            serialPort.Open();
            txtDeltaP.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Invoke(SerialPort_DataReceived);



        }
    }
}
