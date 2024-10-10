﻿using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Controles;
using DataAccess.Repository;
using ZstdSharp.Unsafe;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CaidaPresion
{
    public partial class frmPrincipal : Form
    {

        string msg = "";
        double holdup;
        double ub;
        double db;
        string[] arr = ["id", "nombre"];
        DataTable? tblConcentracion;
        Dictionary<string, object>? colection;
        ToolTip? toolTip;
        public frmPrincipal(EspumanteRepository _espumanteRepository,
                            ConcentracionRepository _concentracionRepository,
                            ResultadoRepository _resultadoRepository,
                            GraficaRepository _graficaRepository,
                            OtrosResultadosRepository _otrosResultadosRepository)
        {
            InitializeComponent();
            OtrosResultadosRepository = _otrosResultadosRepository;
            espumanteRepository = _espumanteRepository;
            concentracionRepository = _concentracionRepository;
            resultadoRepository = _resultadoRepository;
            graficaRepository = _graficaRepository;
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbParamGraficar.SelectedValue == null)
                {
                    ControlForm.GetMessage("Debe seleccionar a que concentracion esta el espunante", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbConcentracion.SelectedValue == null)
                {
                    ControlForm.GetMessage("Debe seleccionar a que concentracion esta el espunante", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!CaidaDePresion.EsEvaluada(txtDeltaP.Text, txtVelLinealGas.Text, txtJsl.Text, ref msg))
                {
                    ControlForm.GetMessage(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double reynold = CaidaDePresion.CalcularValorReynold(double.Parse(txtDeltaP.Text),
                                                                               double.Parse(txtVelLinealGas.Text),
                                                                               double.Parse(txtJsl.Text));
                holdup = CaidaDePresion.Holdup * 100;
                ub = CaidaDePresion.ub * 100;
                db = CaidaDePresion.db * 1000;
                string[] columns = ["Variable", "Resultado"];
                DataTable dt = Table.GetDataTable(columns);
                string[] values = { "Reynold", reynold.ToString() };
                Table.SetRow(dt, columns, values);
                string[] values2 = { "Ub", ub.ToString() };
                Table.SetRow(dt, columns, values2);
                string[] values3 = { "Hold up", holdup.ToString() };
                Table.SetRow(dt, columns, values3);
                string[] values4 = { "Usg", CaidaDePresion.Usg.ToString() };
                Table.SetRow(dt, columns, values4);
                dataGridView1.DataSource = dt;
                colection = new (){
                    { "deltap", double.Parse(txtDeltaP.Text) },
                    {"jsl",double.Parse(txtJsl.Text) },
                    {"holdup",holdup },
                    {"db",db },
                    { "ub" ,ub},
                    { "reb",reynold },
                    {"usg",CaidaDePresion.Usg },
                    {"jg",double.Parse( txtVelLinealGas.Text) },
                    {"concentracion_id",double.Parse(cmbConcentracion.SelectedValue.ToString())},
                    {"espumante_id",double .Parse(cmbEspumante.SelectedValue.ToString()) },
                    {"grafica_id",double.Parse(cmbParamGraficar.SelectedValue.ToString()) }
                };
                int idresultado = 0;
                resultadoRepository.Save(colection, ref idresultado);
                foreach (DataRow row in CaidaDePresion.tblOtrosResultados.Rows)
                {
                    colection = new () {
                        { "PrimerTermino",double.Parse( row["PrimerTermino"].ToString()) },
                        { "ReynoldEnjambre",double.Parse( row["ReynoldEnjambre"].ToString()) },
                        { "SegundoTermino",double.Parse( row["SegundoTermino"].ToString()) },
                        { "TercerTermino",double.Parse( row["TercerTermino"].ToString()) },
                        { "FuncionObjetivo",double.Parse( row["FuncionObjetivo"].ToString()) },
                        { "DiametroBurbuja",double.Parse( row["DiametroBurbuja"].ToString()) }
                    };
                    OtrosResultadosRepository.Save(colection, ref idresultado);
                }
                cmbParamGraficar.SelectedIndex = 0;
                txtDeltaP.Clear();
                txtJsl.Clear();
                txtVelLinealGas.Clear();
                txtDeltaP.Focus();
                LoadGraphic();
            }
            catch (Exception ex)
            {
                ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnCalibrar.Enabled = radioButton1.Checked;
            txtDeltaP.ReadOnly = radioButton1.Checked;
            txtVelLinealGas.ReadOnly = radioButton1.Checked;
            txtVelLinealGas.Clear();
            txtDeltaP.Clear();
            txtJsl.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnCalibrar.Enabled = radioButton1.Checked;
            txtDeltaP.Focus();
        }

        private void btnCalibrar_Click(object sender, EventArgs e)
        {
            frmCalibracion form = new();
            form.ShowDialog();
            txtDeltaP.Text = ControlForm.textBox != null ? ControlForm.textBox.Text : "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmValoresIniciales frmValoresIniciales = new() { dt = Table.GetInitialValues() };
            frmValoresIniciales.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDatosEntrada frmDatos = new()
            {
                ResultadoRepository = resultadoRepository,
                EspumanteRepository = espumanteRepository,
                ConcentracionRepository = concentracionRepository,
                OtrosResultadosRepository = OtrosResultadosRepository
            };
            frmDatos.ShowDialog();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
            toolTip = ControlForm.GetToolTip(5000, 1000, 500, true);
            ControlForm.SetToolTip(toolTip, BtnOtrosResultados, "Mostrar otros resultados");
            ControlForm.SetToolTip(toolTip, btnNuevo, "Nuevos valores");
            ControlForm.SetToolTip(toolTip, btnCalibrar, "Calibrar plc");
            ControlForm.SetToolTip(toolTip, btnGraficar, "Graficar resultados");
            ControlForm.SetToolTip(toolTip, btnValoresIniciales, "Ver valores iniciales");
            ControlForm.FillCombo(espumanteRepository.GetDataTable(), arr, cmbEspumante);
            ControlForm.FillCombo(graficaRepository.GetDataTable(), arr, cmbParamGraficar);
            cmbtipoGrafica.DataSource = ControlForm.SeriesChartType;
            grafica.Series.Clear();
            DialogResult result = MessageBox.Show("Desea eliminar este registro", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Nuevo();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void cmbEspumante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                grafica.Series.Clear();
                string[] arr = { "concentracion_id", "concentracion" };
                int.TryParse(cmbEspumante.SelectedValue != null ? cmbEspumante.SelectedValue.ToString() : "", out int espumante);
                tblConcentracion = concentracionRepository.GetDataTable(espumante);
                ControlForm.FillCombo(tblConcentracion, arr, cmbConcentracion);
            }
            catch (Exception ex)
            {
                ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Nuevo()
        {
            try
            {
                grafica.Series.Clear();
                resultadoRepository.Delete();
            }
            catch (Exception ex)
            {
                ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadGraphic()
        {
            DataTable table;
            grafica.Series.Clear();
            int.TryParse(cmbEspumante.SelectedValue != null ? cmbEspumante.SelectedValue.ToString() : "", out int espumante);
            if (cmbConcentracion.SelectedValue == null)
            {
                switch (cmbParamGraficar.SelectedValue)
                {
                    case 1:
                        {
                            foreach (DataRow row in tblConcentracion.Rows)
                            {
                                string serie = cmbParamGraficar.Text + " " + row["concentracion"].ToString();
                                grafica.Series.Add(serie);
                                int.TryParse(row["concentracion_id"].ToString(), out int concentracion);
                                table = resultadoRepository.AirHoldupVsJg(concentracion, espumante);
                                string[] cols = { "jg", "holdup" };
                                ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), serie, cols, table);
                            }
                            break;
                        }
                    case 2:
                        {
                            foreach (DataRow row in tblConcentracion.Rows)
                            {
                                string serie = cmbParamGraficar.Text + " " + row["concentracion"].ToString();
                                grafica.Series.Add(serie);
                                int.TryParse(row["concentracion_id"].ToString(), out int concentracion);
                                table = resultadoRepository.AirHoldupVsJg(concentracion, espumante);
                                string[] cols = { "jg", "holdup" };
                                ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), serie, cols, table);
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (DataRow row in tblConcentracion.Rows)
                            {
                                string serie = cmbParamGraficar.Text + " " + row["concentracion"].ToString();
                                grafica.Series.Add(serie);
                                int.TryParse(row["concentracion_id"].ToString(), out int concentracion);
                                table = resultadoRepository.DiámetroBurbujaVsJg(concentracion, espumante);
                                string[] cols = { "jg", "db" };
                                ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), serie, cols, table);
                            }
                            break;
                        }
                    case 4:
                        {
                            string[] arr = [];
                            table = resultadoRepository.DiámetroBurbujaVsConcentracion( espumante);
                            ControlForm.FillArray(grafica, table, ref arr);
                            string[] cols = ["concentracion", "db"];
                            for (int j = 0; j <= arr.Length - 1; j++)
                            {
                                var search =Table. Busqueda("jg", arr[j], table);
                                ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), arr[j], cols, search);
                            }
                            break;
                        }
                }
            }
            else
            {
                grafica.Series.Add(cmbParamGraficar.Text);
                int.TryParse(cmbConcentracion.SelectedValue.ToString(), out int concentracion);
                switch (cmbParamGraficar.SelectedValue)
                {
                    case 1:
                        {
                            table = resultadoRepository.AirHoldupVsJg(concentracion, espumante);
                            string[] cols = { "jg", "holdup" };
                            ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), cmbParamGraficar.Text, cols, table);
                            break;
                        }
                    case 2:
                        {
                            table = resultadoRepository.UsgVsAirHoldup(concentracion, espumante);
                            string[] cols = { "holdup", "usg" };
                            ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), cmbParamGraficar.Text, cols, table);
                            break;
                        }
                    case 3:
                        {
                            table = resultadoRepository.DiámetroBurbujaVsJg(concentracion, espumante);
                            string[] cols = { "jg", "db" };
                            ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), cmbParamGraficar.Text, cols, table);
                            break;
                        }
                    case 4:
                        {
                            ControlForm.GetMessage("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                }
            }
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void cmbParamGraficar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbParamGraficar.SelectedValue != null)
                {
                    LoadGraphic();
                }

            }
            catch (Exception ex)
            {
                ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbtipoGrafica_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serie = Enum.Parse<SeriesChartType>(cmbtipoGrafica.SelectedValue.ToString());
            foreach (var series in grafica.Series)
            {
                series.ChartType = serie;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir de esta aplicación", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new();
            aboutBox1.ShowDialog();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) { WindowState = FormWindowState.Maximized; }
            else if (WindowState == FormWindowState.Maximized) { WindowState = FormWindowState.Normal; }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) { WindowState = FormWindowState.Minimized; }
            else if (WindowState == FormWindowState.Maximized) { WindowState = FormWindowState.Minimized; }
        }

        private void btnNuevoEspumante_Click(object sender, EventArgs e)
        {
           frmEspumante frmEspumante = new frmEspumante
           {
               EspumanteRepository=espumanteRepository,
               ConcentracionRepository=concentracionRepository
           };
            frmEspumante.ShowDialog();
            ControlForm.FillCombo(espumanteRepository.GetDataTable(), arr, cmbEspumante);

        }
 
    

    }
}
