﻿using Microsoft.FSharp.Data.UnitSystems.SI.UnitNames;
using System;
using System.Data;
using System.Data.Common;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Microsoft.FSharp.Core.ByRefKinds;
using static System.Net.Mime.MediaTypeNames;
namespace Controles
{
    public abstract class ControlForm
    {
        public static Array SeriesChartType { get { return Enum.GetValues(typeof(SeriesChartType)); } }
        public static System.Windows.Forms. Form? Form;
        public static System.Windows.Forms. TextBox? textBox;
        static string? Dato;
        public static void SetToolTip(ToolTip toolTip , Button  button, string msg)
        {
            toolTip.SetToolTip(button, msg);
        }

        public static ToolTip GetToolTip(int AutoPopDelay, int InitialDelay, int ReshowDelay, bool ShowAlways)
        {
            ToolTip toolTip = new()
            {
                // Set up the delays for the ToolTip.
                AutoPopDelay = AutoPopDelay,
                InitialDelay = InitialDelay,
                ReshowDelay = ReshowDelay,
                // Force the ToolTip text to be displayed whether or not the form is active.
                ShowAlways = ShowAlways
            };
            return toolTip;
        }
        static void  SetGraphicProperty(Chart grafica,string[] cols)
        {
            grafica.ChartAreas[0].BorderColor = Color.White;
            grafica.ChartAreas[0].BackColor = Color.FromArgb(42, 46, 50);
            grafica.ChartAreas[0].AxisY.LineColor = Color.White;
            grafica.ChartAreas[0].AxisX.LineColor = Color.White;
            grafica.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            grafica.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            grafica.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            grafica.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            grafica.ChartAreas[0].AxisX.Title = cols[0].ToUpper();
            grafica.ChartAreas[0].AxisY.Title = cols[1].ToUpper();
        }
        public static void GetGraphic(Chart grafica,string TipoGrafica, string serie,string []  cols, DataTable table)
        {
            grafica.Series[serie].ChartType = Enum.Parse<SeriesChartType>(TipoGrafica);
            SetGraphicProperty(grafica, cols);
            foreach (DataRow row in table.Rows)
            {
                double x = double.Parse( row[cols[0]].ToString());
                double y = double.Parse(row[cols[1]].ToString());
                grafica.Series[serie].Points.AddXY(x,y);
            }
        }
      
        public static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort=(SerialPort)sender;
            Thread.Sleep(500);
            Dato = serialPort.ReadExisting()+";";
            Form.Invoke(new EventHandler(DisplayText));
        }
        private static void DisplayText(object sender, EventArgs e)
        {
            textBox.AppendText(Dato);
            Thread.Sleep(1000);
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
