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
using Controles;
using DataAccess;
using DataAccess.Repository;
using Microsoft.FSharp.Core;
using Org.BouncyCastle.Asn1.X509;
namespace CaidaPresion
{
    public partial class frmPrincipal : Form
    {

        string msg = "";
        double holdup;
        double ub;
        double db;
        Array seriesChartType;
        DataTable tblConcentracion;
        Dictionary<string, double> colection;
        ToolTip toolTip1;
        EspumanteRepository espumanteRepository;
        ConcentracionRepository concentracionRepository;
        ResultadoRepository resultadoRepository;
        public frmPrincipal(EspumanteRepository _espumanteRepository,
                            ConcentracionRepository _concentracionRepository,
                            ResultadoRepository _resultadoRepository)
        {
            InitializeComponent();
            espumanteRepository = _espumanteRepository;
            concentracionRepository = _concentracionRepository;
            resultadoRepository = _resultadoRepository;


        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            try
            {
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
                holdup = CaidaDePresion.holdup * 100;
                ub = CaidaDePresion.ub * 100;
                db = CaidaDePresion.db * 1000;
                string[] columns = { "Variable", "Resultado" };
                DataTable dt = Table.GetDataTable(columns);
                string[] values = { "Reynold", reynold.ToString() };
                Table.SetRow(dt, columns, values);
                string[] values2 = { "Ub", ub.ToString() };
                Table.SetRow(dt, columns, values2);
                string[] values3 = { "Hold up", holdup.ToString() };
                Table.SetRow(dt, columns, values3);
                dataGridView1.DataSource = dt;
                colection = new Dictionary<string, double> {
                    { "deltap", double.Parse(txtDeltaP.Text) },
                    {"jsl",double.Parse(txtJsl.Text) },
                    {"holdup",holdup },
                    {"db",db },
                    { "ub" ,ub},
                    { "reb",reynold },
                    {"usg",CaidaDePresion.Usg },
                    {"jg",double.Parse( txtVelLinealGas.Text) },
                    {"concentracion_id",double.Parse(cmbConcentracion.SelectedValue.ToString()) },
                    {"espumante_id",double .Parse(cmbEspumante.SelectedValue.ToString()) }
                };
                resultadoRepository.Save(colection);
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
            txtDeltaP.Text = ControlForm.textBox.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmValoresIniciales frmValoresIniciales = new frmValoresIniciales { dt = Table.GetInitialValues() };
            frmValoresIniciales.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDatosEntrada frmDatos = new frmDatosEntrada
            {
                dt1 = Table.GetTerminos("P1", CaidaDePresion.PrimerTermino),
                dt2 = Table.GetTerminos("ReynoldEnjambre", CaidaDePresion.ReynoldEnjambre),
                dt3 = Table.GetTerminos("SegundoTermino", CaidaDePresion.SegundoTermino),
                dt4 = Table.GetTerminos("TercerTermino", CaidaDePresion.TercerTermino),
                dt5 = Table.GetTerminos("FuncionObjetivo", CaidaDePresion.FuncionObjetivo),
                dt6 = Table.GetTerminos("DiametroBurbuja", CaidaDePresion.DiametroBurbuja)
            };
            frmDatos.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            seriesChartType = Enum.GetValues(typeof(SeriesChartType));
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
            string[] arr = { "id", "nombre" };
            string[] arrparam = { "AirHoldup Vs Jg", "Usg Vs Air holdup", "Diámetro de burbuja Vs Jg" };

            toolTip1 = new ToolTip
            {
                // Set up the delays for the ToolTip.
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                // Force the ToolTip text to be displayed whether or not the form is active.
                ShowAlways = true
            };
            toolTip1.SetToolTip(BtnOtrosResultados, "Mostrar otros resultados");
            toolTip1.SetToolTip(btnValoresIniciales, "Ver valores iniciales");
            toolTip1.SetToolTip(btnNuevo, "Nuevos valores");
            toolTip1.SetToolTip(btnCalibrar, "Calibrar plc");
            toolTip1.SetToolTip(btnGraficar, "Graficar resultados");
            ControlForm.FillCombo(espumanteRepository.GetDataTable(), arr, cmbEspumante);
            ControlForm.FillCombo(arrparam, cmbParamGraficar);

            cmbtipoGrafica.DataSource = seriesChartType;

            Nuevo();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            int.TryParse(cmbEspumante.SelectedValue.ToString(), out int espumante);
            if (cmbConcentracion.SelectedValue == null)
            {
                switch (cmbParamGraficar.Text)
                {
                    case "AirHoldup Vs Jg":
                        {
                            foreach (DataRow row in tblConcentracion.Rows)
                            {
                                string serie = cmbParamGraficar.Text + " " + row["concentracion"].ToString();
                                grafica.Series.Add(serie);
                                int.TryParse(row["concentracion_id"].ToString(), out int concentracion);
                                table = resultadoRepository.AirHoldupVsJg(concentracion, espumante);
                                string[] cols = { "jg", "holdup" };
                                ControlForm.GetGraphic(grafica,cmbtipoGrafica.SelectedValue.ToString(), serie,  cols, table);
                            }
                            break;
                        }
                    case "Usg Vs Air holdup":
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
                    case "Diámetro de burbuja Vs Jg":
                        {
                            foreach (DataRow row in tblConcentracion.Rows)
                            {
                                string serie = cmbParamGraficar.Text + " " + row["concentracion"].ToString();
                                grafica.Series.Add(serie);
                                int.TryParse(row["concentracion_id"].ToString(), out int concentracion);
                                table = resultadoRepository.DiámetroBurbujaVsJg(concentracion, espumante);
                                string[] cols = { "jg", "holdup" };
                                ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), serie, cols, table);
                            }

                            break;
                        }
                }
            }
            else
            {
                grafica.Series.Add(cmbParamGraficar.Text);
                int.TryParse(cmbConcentracion.SelectedValue.ToString(), out int concentracion);
                switch (cmbParamGraficar.Text)
                {
                    case "AirHoldup Vs Jg":
                        {
                            table = resultadoRepository.AirHoldupVsJg(concentracion, espumante);
                            string[] cols = { "jg", "holdup" };
                            ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), cmbParamGraficar.Text, cols, table);
                            break;
                        }
                    case "Usg Vs Air holdup":
                        {
                            table = resultadoRepository.UsgVsAirHoldup(concentracion, espumante);
                            string[] cols = { "holdup", "usg" };
                            ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), cmbParamGraficar.Text, cols, table);
                            break;
                        }
                    case "Diámetro de burbuja Vs Jg":
                        {
                            table = resultadoRepository.DiámetroBurbujaVsJg(concentracion, espumante);
                            string[] cols = { "db", "jg" };
                            ControlForm.GetGraphic(grafica, cmbtipoGrafica.SelectedValue.ToString(), cmbParamGraficar.Text, cols, table);
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
                LoadGraphic();
            }
            catch (Exception ex)
            {
                ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbtipoGrafica_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serie = Enum.Parse<SeriesChartType>(cmbtipoGrafica.SelectedValue.ToString());
            foreach(var series in grafica .Series)
            {
                series.ChartType= serie;
            }

        }
    }

}
