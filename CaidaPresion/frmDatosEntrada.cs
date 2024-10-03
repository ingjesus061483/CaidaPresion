using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaidaPresion
{
    public partial class frmDatosEntrada : Form
    {
        public OtrosResultadosRepository OtrosResultadosRepository { get;set; }
        public DataTable? tableResultados { get; set; }
        public DataTable? dt1 { get; set; }
        public DataTable? dt2 { get; set; }
        public DataTable? dt3 { get; set; }
        public DataTable?    dt4 { get; set; }
        public DataTable? dt5 { get; set; }
        public DataTable? dt6 { get; set; }
        
        public frmDatosEntrada()
        {
           
            InitializeComponent();
        }

        private void frmDatosEntrada_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt1;
            dataGridView2.DataSource = dt2;
            dataGridView3.DataSource = dt3;
            dataGridView4.DataSource = dt4; 
            dataGridView5.DataSource = dt5;
            dataGridView6.DataSource = dt6;
            dgResultados.DataSource = tableResultados;
        }
    }
}
