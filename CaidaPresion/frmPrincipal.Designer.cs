﻿using DataAccess.Repository;

namespace CaidaPresion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0.68D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0.6D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1.2D, 20D);
            dataGridView1 = new DataGridView();
            Variable = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            btnValoresIniciales = new Button();
            txtJsl = new TextBox();
            label6 = new Label();
            btnNuevo = new Button();
            rbtManual = new RadioButton();
            radioButton1 = new RadioButton();
            txtVelLinealGas = new TextBox();
            label2 = new Label();
            btnCalibrar = new Button();
            btnGraficar = new Button();
            txtDeltaP = new TextBox();
            BtnOtrosResultados = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            label15 = new Label();
            label7 = new Label();
            pnlGraficas = new Panel();
            grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel18 = new Panel();
            cmbtipoGrafica = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            cmbParamGraficar = new ComboBox();
            label5 = new Label();
            cmbConcentracion = new ComboBox();
            label10 = new Label();
            cmbEspumante = new ComboBox();
            panel2 = new Panel();
            panel9 = new Panel();
            label14 = new Label();
            lblReloj = new Label();
            panel8 = new Panel();
            label1 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            panel6 = new Panel();
            btnAyuda = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            panel12 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            panel7 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            pictureBox1 = new PictureBox();
            panel15 = new Panel();
            panel17 = new Panel();
            panel16 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            pnlGraficas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grafica).BeginInit();
            panel18.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel15.SuspendLayout();
            panel17.SuspendLayout();
            panel16.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Variable, Resultado });
            dataGridView1.Location = new Point(761, 660);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(373, 218);
            dataGridView1.TabIndex = 44;
            // 
            // Variable
            // 
            Variable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Variable.DataPropertyName = "Variable";
            Variable.HeaderText = "Variable";
            Variable.MinimumWidth = 8;
            Variable.Name = "Variable";
            Variable.ReadOnly = true;
            // 
            // Resultado
            // 
            Resultado.DataPropertyName = "Resultado";
            Resultado.HeaderText = "Resultado";
            Resultado.MinimumWidth = 8;
            Resultado.Name = "Resultado";
            Resultado.ReadOnly = true;
            Resultado.Width = 150;
            // 
            // btnValoresIniciales
            // 
            btnValoresIniciales.BackgroundImage = (Image)resources.GetObject("btnValoresIniciales.BackgroundImage");
            btnValoresIniciales.BackgroundImageLayout = ImageLayout.Stretch;
            btnValoresIniciales.FlatStyle = FlatStyle.Flat;
            btnValoresIniciales.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValoresIniciales.Location = new Point(124, 60);
            btnValoresIniciales.Name = "btnValoresIniciales";
            btnValoresIniciales.Size = new Size(44, 50);
            btnValoresIniciales.TabIndex = 43;
            btnValoresIniciales.UseVisualStyleBackColor = true;
            btnValoresIniciales.Click += button3_Click;
            // 
            // txtJsl
            // 
            txtJsl.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJsl.Location = new Point(329, 158);
            txtJsl.Name = "txtJsl";
            txtJsl.Size = new Size(84, 30);
            txtJsl.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(219, 161);
            label6.Name = "label6";
            label6.Size = new Size(102, 24);
            label6.TabIndex = 42;
            label6.Text = "Jsl (cm/s)";
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(24, 62);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(44, 50);
            btnNuevo.TabIndex = 35;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += button1_Click;
            // 
            // rbtManual
            // 
            rbtManual.AutoSize = true;
            rbtManual.Checked = true;
            rbtManual.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtManual.ForeColor = Color.White;
            rbtManual.Location = new Point(37, 62);
            rbtManual.Name = "rbtManual";
            rbtManual.Size = new Size(103, 28);
            rbtManual.TabIndex = 34;
            rbtManual.TabStop = true;
            rbtManual.Text = "Manual";
            rbtManual.UseVisualStyleBackColor = true;
            rbtManual.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(37, 122);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(142, 28);
            radioButton1.TabIndex = 33;
            radioButton1.Text = "Automático";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtVelLinealGas
            // 
            txtVelLinealGas.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVelLinealGas.Location = new Point(329, 115);
            txtVelLinealGas.Name = "txtVelLinealGas";
            txtVelLinealGas.Size = new Size(84, 30);
            txtVelLinealGas.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 121);
            label2.Name = "label2";
            label2.Size = new Size(295, 24);
            label2.TabIndex = 32;
            label2.Text = "Velocidad lineal del gas (cm/s)";
            // 
            // btnCalibrar
            // 
            btnCalibrar.BackgroundImage = (Image)resources.GetObject("btnCalibrar.BackgroundImage");
            btnCalibrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalibrar.Enabled = false;
            btnCalibrar.FlatStyle = FlatStyle.Flat;
            btnCalibrar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalibrar.Location = new Point(174, 60);
            btnCalibrar.Name = "btnCalibrar";
            btnCalibrar.Size = new Size(63, 50);
            btnCalibrar.TabIndex = 31;
            btnCalibrar.UseVisualStyleBackColor = true;
            btnCalibrar.Click += btnCalibrar_Click;
            // 
            // btnGraficar
            // 
            btnGraficar.BackgroundImage = (Image)resources.GetObject("btnGraficar.BackgroundImage");
            btnGraficar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGraficar.FlatStyle = FlatStyle.Flat;
            btnGraficar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGraficar.Location = new Point(244, 62);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(64, 50);
            btnGraficar.TabIndex = 28;
            btnGraficar.UseVisualStyleBackColor = true;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // txtDeltaP
            // 
            txtDeltaP.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeltaP.Location = new Point(329, 72);
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.Size = new Size(84, 30);
            txtDeltaP.TabIndex = 27;
            // 
            // BtnOtrosResultados
            // 
            BtnOtrosResultados.BackgroundImage = (Image)resources.GetObject("BtnOtrosResultados.BackgroundImage");
            BtnOtrosResultados.BackgroundImageLayout = ImageLayout.Stretch;
            BtnOtrosResultados.FlatStyle = FlatStyle.Flat;
            BtnOtrosResultados.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOtrosResultados.Location = new Point(74, 60);
            BtnOtrosResultados.Name = "BtnOtrosResultados";
            BtnOtrosResultados.Size = new Size(44, 50);
            BtnOtrosResultados.TabIndex = 44;
            BtnOtrosResultados.UseVisualStyleBackColor = true;
            BtnOtrosResultados.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(42, 46, 50);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtVelLinealGas);
            panel5.Controls.Add(txtJsl);
            panel5.Controls.Add(txtDeltaP);
            panel5.Location = new Point(40, 660);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(436, 218);
            panel5.TabIndex = 46;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(152, 76);
            label15.Name = "label15";
            label15.Size = new Size(169, 24);
            label15.TabIndex = 54;
            label15.Text = "Caida de presión";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(103, 18);
            label7.Name = "label7";
            label7.Size = new Size(211, 24);
            label7.TabIndex = 53;
            label7.Text = "DATOS DE ENTRADA";
            // 
            // pnlGraficas
            // 
            pnlGraficas.BackColor = Color.FromArgb(42, 46, 50);
            pnlGraficas.Controls.Add(grafica);
            pnlGraficas.Controls.Add(panel18);
            pnlGraficas.Controls.Add(panel2);
            pnlGraficas.Dock = DockStyle.Top;
            pnlGraficas.Location = new Point(0, 0);
            pnlGraficas.Margin = new Padding(4, 5, 4, 5);
            pnlGraficas.Name = "pnlGraficas";
            pnlGraficas.Size = new Size(1146, 630);
            pnlGraficas.TabIndex = 0;
            // 
            // grafica
            // 
            grafica.BackColor = Color.FromArgb(42, 46, 50);
            chartArea1.Name = "ChartArea1";
            grafica.ChartAreas.Add(chartArea1);
            grafica.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            grafica.Legends.Add(legend1);
            grafica.Location = new Point(0, 171);
            grafica.Margin = new Padding(4, 5, 4, 5);
            grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            grafica.Series.Add(series1);
            grafica.Size = new Size(1146, 459);
            grafica.TabIndex = 0;
            grafica.Text = "chart1";
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(42, 46, 50);
            panel18.Controls.Add(cmbtipoGrafica);
            panel18.Controls.Add(label13);
            panel18.Controls.Add(label12);
            panel18.Controls.Add(cmbParamGraficar);
            panel18.Controls.Add(label5);
            panel18.Controls.Add(cmbConcentracion);
            panel18.Controls.Add(label10);
            panel18.Controls.Add(cmbEspumante);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(0, 20);
            panel18.Margin = new Padding(4, 5, 4, 5);
            panel18.Name = "panel18";
            panel18.Size = new Size(1146, 151);
            panel18.TabIndex = 1;
            // 
            // cmbtipoGrafica
            // 
            cmbtipoGrafica.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtipoGrafica.FormattingEnabled = true;
            cmbtipoGrafica.Location = new Point(701, 100);
            cmbtipoGrafica.Margin = new Padding(4, 5, 4, 5);
            cmbtipoGrafica.Name = "cmbtipoGrafica";
            cmbtipoGrafica.Size = new Size(227, 33);
            cmbtipoGrafica.TabIndex = 40;
            cmbtipoGrafica.SelectedIndexChanged += cmbtipoGrafica_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(539, 105);
            label13.Name = "label13";
            label13.Size = new Size(152, 24);
            label13.TabIndex = 39;
            label13.Text = "Tipo de grafica";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(54, 105);
            label12.Name = "label12";
            label12.Size = new Size(215, 24);
            label12.TabIndex = 38;
            label12.Text = "Parámetros a graficar";
            // 
            // cmbParamGraficar
            // 
            cmbParamGraficar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParamGraficar.FormattingEnabled = true;
            cmbParamGraficar.Location = new Point(276, 100);
            cmbParamGraficar.Margin = new Padding(4, 5, 4, 5);
            cmbParamGraficar.Name = "cmbParamGraficar";
            cmbParamGraficar.Size = new Size(240, 33);
            cmbParamGraficar.TabIndex = 37;
            cmbParamGraficar.SelectedIndexChanged += cmbParamGraficar_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 49);
            label5.Name = "label5";
            label5.Size = new Size(116, 24);
            label5.TabIndex = 36;
            label5.Text = "Espumante";
            // 
            // cmbConcentracion
            // 
            cmbConcentracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConcentracion.FormattingEnabled = true;
            cmbConcentracion.Location = new Point(601, 43);
            cmbConcentracion.Margin = new Padding(4, 5, 4, 5);
            cmbConcentracion.Name = "cmbConcentracion";
            cmbConcentracion.Size = new Size(227, 33);
            cmbConcentracion.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(445, 48);
            label10.Name = "label10";
            label10.Size = new Size(148, 24);
            label10.TabIndex = 34;
            label10.Text = "Concentración";
            // 
            // cmbEspumante
            // 
            cmbEspumante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspumante.FormattingEnabled = true;
            cmbEspumante.Location = new Point(182, 44);
            cmbEspumante.Margin = new Padding(4, 5, 4, 5);
            cmbEspumante.Name = "cmbEspumante";
            cmbEspumante.Size = new Size(227, 33);
            cmbEspumante.TabIndex = 0;
            cmbEspumante.SelectedIndexChanged += cmbEspumante_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1146, 20);
            panel2.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(42, 46, 50);
            panel9.Controls.Add(label14);
            panel9.Controls.Add(lblReloj);
            panel9.Location = new Point(24, 447);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(294, 112);
            panel9.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(11, 4);
            label14.Name = "label14";
            label14.Size = new Size(76, 24);
            label14.TabIndex = 53;
            label14.Text = "RELOJ";
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.BackColor = Color.Transparent;
            lblReloj.Font = new Font("Centaur", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReloj.ForeColor = Color.White;
            lblReloj.Location = new Point(10, 28);
            lblReloj.Margin = new Padding(4, 0, 4, 0);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(219, 64);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(42, 46, 50);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(rbtManual);
            panel8.Controls.Add(radioButton1);
            panel8.Location = new Point(24, 33);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(254, 193);
            panel8.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(226, 24);
            label1.TabIndex = 52;
            label1.Text = "MODO DE EJECUCIÓN";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(42, 46, 50);
            panel10.Controls.Add(BtnOtrosResultados);
            panel10.Controls.Add(btnGraficar);
            panel10.Controls.Add(btnValoresIniciales);
            panel10.Controls.Add(btnNuevo);
            panel10.Controls.Add(btnCalibrar);
            panel10.Location = new Point(24, 260);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(314, 152);
            panel10.TabIndex = 51;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Controls.Add(panel6);
            panel11.Controls.Add(panel3);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(label11);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(4, 5, 4, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(1794, 138);
            panel11.TabIndex = 54;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAyuda);
            panel6.Controls.Add(btnMinimizar);
            panel6.Controls.Add(btnMaximizar);
            panel6.Controls.Add(btnCerrar);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1648, 0);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(146, 138);
            panel6.TabIndex = 47;
            // 
            // btnAyuda
            // 
            btnAyuda.BackgroundImage = (Image)resources.GetObject("btnAyuda.BackgroundImage");
            btnAyuda.BackgroundImageLayout = ImageLayout.Stretch;
            btnAyuda.Dock = DockStyle.Fill;
            btnAyuda.Location = new Point(0, 0);
            btnAyuda.Margin = new Padding(4, 5, 4, 5);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(35, 138);
            btnAyuda.TabIndex = 43;
            btnAyuda.TabStop = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackgroundImage = (Image)resources.GetObject("btnMinimizar.BackgroundImage");
            btnMinimizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.Location = new Point(35, 0);
            btnMinimizar.Margin = new Padding(4, 5, 4, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(37, 138);
            btnMinimizar.TabIndex = 44;
            btnMinimizar.TabStop = false;
            // 
            // btnMaximizar
            // 
            btnMaximizar.BackgroundImage = (Image)resources.GetObject("btnMaximizar.BackgroundImage");
            btnMaximizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnMaximizar.Dock = DockStyle.Right;
            btnMaximizar.Location = new Point(72, 0);
            btnMaximizar.Margin = new Padding(4, 5, 4, 5);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(37, 138);
            btnMaximizar.TabIndex = 41;
            btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.Location = new Point(109, 0);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(37, 138);
            btnCerrar.TabIndex = 42;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(36, 113, 163);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(277, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1371, 138);
            panel3.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(88, 68);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(1132, 32);
            label9.TabIndex = 41;
            label9.Text = "DEL LABORATORIO DE CARBOQUIMICA  DE LA UNIVERSIDAD DEL ATLANTICO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(-2, 15);
            label8.Name = "label8";
            label8.Size = new Size(1366, 32);
            label8.TabIndex = 40;
            label8.Text = "DISEÑO DE UNA INTERFAZ GRAFICA PARA LA COLUMNA DE FLOTACION  A ESCALA TEST RIG ";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(42, 46, 50);
            panel12.Controls.Add(label4);
            panel12.Controls.Add(label3);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 0);
            panel12.Margin = new Padding(4, 5, 4, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(277, 138);
            panel12.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 67);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 25);
            label4.TabIndex = 40;
            label4.Text = "INGENIERIA QUIMICA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 22);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 39;
            label3.Text = "PROGRAMA DE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(191, 70);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 29);
            label11.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel14);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 138);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 968);
            panel1.TabIndex = 55;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel13);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 703);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(299, 265);
            panel7.TabIndex = 48;
            // 
            // panel13
            // 
            panel13.BackgroundImage = (Image)resources.GetObject("panel13.BackgroundImage");
            panel13.BackgroundImageLayout = ImageLayout.Stretch;
            panel13.Location = new Point(39, 48);
            panel13.Name = "panel13";
            panel13.Size = new Size(209, 258);
            panel13.TabIndex = 41;
            // 
            // panel14
            // 
            panel14.Controls.Add(pictureBox1);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Margin = new Padding(4, 5, 4, 5);
            panel14.Name = "panel14";
            panel14.Size = new Size(299, 703);
            panel14.TabIndex = 47;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 610);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // panel15
            // 
            panel15.Controls.Add(panel17);
            panel15.Controls.Add(panel16);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(299, 138);
            panel15.Margin = new Padding(4, 5, 4, 5);
            panel15.Name = "panel15";
            panel15.Size = new Size(1495, 968);
            panel15.TabIndex = 56;
            // 
            // panel17
            // 
            panel17.Controls.Add(panel8);
            panel17.Controls.Add(panel10);
            panel17.Controls.Add(panel9);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(1146, 0);
            panel17.Margin = new Padding(4, 5, 4, 5);
            panel17.Name = "panel17";
            panel17.Size = new Size(349, 968);
            panel17.TabIndex = 53;
            // 
            // panel16
            // 
            panel16.Controls.Add(pnlGraficas);
            panel16.Controls.Add(panel5);
            panel16.Controls.Add(dataGridView1);
            panel16.Dock = DockStyle.Left;
            panel16.Location = new Point(0, 0);
            panel16.Margin = new Padding(4, 5, 4, 5);
            panel16.Name = "panel16";
            panel16.Size = new Size(1146, 968);
            panel16.TabIndex = 52;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1794, 1106);
            Controls.Add(panel15);
            Controls.Add(panel1);
            Controls.Add(panel11);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            pnlGraficas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grafica).EndInit();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel15.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel16.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnValoresIniciales;
        private TextBox txtJsl;
        private Label label6;
        private Button btnNuevo;
        private RadioButton rbtManual;
        private RadioButton radioButton1;
        private TextBox txtVelLinealGas;
        private Label label2;
        private Button btnCalibrar;
        private Button btnGraficar;
        private TextBox txtDeltaP;
        private Button BtnOtrosResultados;
        private System.Windows.Forms.Timer timer1;
        private Panel panel5;
        private Panel pnlGraficas;
        private Panel panel9;
        private Label lblReloj;
        private Panel panel8;
        private Panel panel10;
        private Label label7;
        private Label label1;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private Label label10;
        private ComboBox cmbEspumante;
        private Panel panel11;
        private PictureBox btnAyuda;
        private PictureBox btnCerrar;
        private PictureBox btnMaximizar;
        private Panel panel12;
        private Label label9;
        private Label label8;
        private Label label11;
        private Panel panel3;
        private Panel panel6;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Panel panel7;
        private Panel panel13;
        private Panel panel14;
        private PictureBox pictureBox1;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private ComboBox cmbConcentracion;
        private Label label5;
        private Label label12;
        private ComboBox cmbParamGraficar;
        private DataGridViewTextBoxColumn Variable;
        private DataGridViewTextBoxColumn Resultado;
        private ComboBox cmbtipoGrafica;
        private Label label13; 
        private EspumanteRepository espumanteRepository;
        private ConcentracionRepository concentracionRepository;
        private ResultadoRepository resultadoRepository;
        private GraficaRepository graficaRepository;
        private OtrosResultadosRepository OtrosResultadosRepository;
        private Label label14;
        private Label label15;
        private PictureBox btnMinimizar;
    }
}