﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Controles
{
    public abstract class ControlForm
    {
        public static System.Windows.Forms. Form Form;
        public static System.Windows.Forms. TextBox textBox;
        static string Dato;
        public static void  GetGraphic(Chart grafica,string TipoGrafica, string serie,string []  cols, DataTable table)
        {
            grafica.Series[serie].ChartType = Enum.Parse<SeriesChartType>(TipoGrafica);
            foreach (DataRow row in table.Rows)
            {
                double x = double.Parse(row[cols[0]].ToString());
                double y = double.Parse(row[cols[1]].ToString());
                grafica.Series[serie].Points.AddXY(x,y);
            }

        }
      
        public static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort=(SerialPort)sender;
            Thread.Sleep(500);
            Dato = serialPort.ReadExisting()+";";
      //      serialPort.Close();
            Form .Invoke(new EventHandler(DisplayText));
        }
        private static void DisplayText(object sender, EventArgs e)
        {
            textBox.AppendText(Dato);
            Thread.Sleep(1000);
            //   Form.Close();
        }
        public static void FillCombo(DataTable table,Array arr,  System.Windows.Forms. ComboBox combo)
        {
            combo.DataSource = table;
            combo.DisplayMember = arr.GetValue(1).ToString();
            combo.ValueMember = arr.GetValue(0).ToString();
            combo.SelectedIndex = -1;
        }
        public static void FillCombo(Enum  table, Array arr, System.Windows.Forms.ComboBox combo)
        {
            combo.DataSource = table;
            combo.DisplayMember = arr.GetValue(1).ToString();
            combo.ValueMember = arr.GetValue(0).ToString();
            combo.SelectedIndex = -1;
        }
        public static void FillCombo( Array arr, System.Windows.Forms.ComboBox comboBox)
        {
            foreach (var value in arr)
            {
                comboBox.Items.Add(value);
            }
        }
        public static void GetMessage(string message,string caption ,MessageBoxButtons buttons,MessageBoxIcon icon )
        {
            MessageBox.Show(message, caption,buttons, icon );
        }
    }
}