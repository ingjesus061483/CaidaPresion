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
        public string Dato { get; set; }
        public frmCalibracion()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            Dato = "";
            serialPort.DataReceived += SerialPort_DataReceived;
        }        
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            Dato = serialPort.ReadExisting(); 
            this.Invoke(new EventHandler(DisplayText )); 
        }
        private void DisplayText(object sender, EventArgs e)
        {
            txtDeltaP.AppendText(Dato);
            Thread.Sleep(1000);
            this.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] serialports = SerialPort.GetPortNames();
            foreach (string serialport in serialports)
            {
                cmbSerialPort.Items.Add(serialport);
            }
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
    }
}
