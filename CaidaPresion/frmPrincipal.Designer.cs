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
            dataGridView1 = new DataGridView();
            Variable = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            button3 = new Button();
            txtJsl = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtVelLinealGas = new TextBox();
            label2 = new Label();
            btnCalibrar = new Button();
            btnGraficar = new Button();
            txtDeltaP = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            label7 = new Label();
            pnlGraficas = new Panel();
            panel9 = new Panel();
            lblReloj = new Label();
            panel8 = new Panel();
            label1 = new Label();
            panel10 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(2, 11, 10);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Variable, Resultado });
            dataGridView1.Location = new Point(559, 510);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(261, 171);
            dataGridView1.TabIndex = 44;
            // 
            // Variable
            // 
            Variable.DataPropertyName = "Variable";
            Variable.HeaderText = "Variable";
            Variable.MinimumWidth = 8;
            Variable.Name = "Variable";
            Variable.ReadOnly = true;
            Variable.Width = 150;
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
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(51, 36);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(31, 30);
            button3.TabIndex = 43;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtJsl
            // 
            txtJsl.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJsl.Location = new Point(230, 95);
            txtJsl.Margin = new Padding(2);
            txtJsl.Name = "txtJsl";
            txtJsl.Size = new Size(60, 23);
            txtJsl.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(191, 98);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 16);
            label6.TabIndex = 42;
            label6.Text = "Jsl";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(30, 541);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 140);
            panel1.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(33, 31);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 16);
            label5.TabIndex = 39;
            label5.Text = "David Padilla Maza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 52);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 16);
            label4.TabIndex = 38;
            label4.Text = "Dir. Jorge Luis Piñeres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 16);
            label3.TabIndex = 37;
            label3.Text = "Indira Bermejo Fernandez";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.exportar;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(221, 36);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(31, 30);
            button2.TabIndex = 36;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.nuevo;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(86, 36);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(31, 30);
            button1.TabIndex = 35;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(26, 37);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 20);
            radioButton2.TabIndex = 34;
            radioButton2.TabStop = true;
            radioButton2.Text = "Manual";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(26, 73);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 20);
            radioButton1.TabIndex = 33;
            radioButton1.Text = "Automático";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtVelLinealGas
            // 
            txtVelLinealGas.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVelLinealGas.Location = new Point(230, 69);
            txtVelLinealGas.Margin = new Padding(2);
            txtVelLinealGas.Name = "txtVelLinealGas";
            txtVelLinealGas.Size = new Size(60, 23);
            txtVelLinealGas.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(210, 16);
            label2.TabIndex = 32;
            label2.Text = "Velocidad lineal del gas (m/s)";
            // 
            // btnCalibrar
            // 
            btnCalibrar.BackgroundImage = Properties.Resources.descarga__1_;
            btnCalibrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalibrar.Enabled = false;
            btnCalibrar.FlatStyle = FlatStyle.Flat;
            btnCalibrar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalibrar.Location = new Point(122, 36);
            btnCalibrar.Margin = new Padding(2);
            btnCalibrar.Name = "btnCalibrar";
            btnCalibrar.Size = new Size(44, 30);
            btnCalibrar.TabIndex = 31;
            btnCalibrar.UseVisualStyleBackColor = true;
            btnCalibrar.Click += btnCalibrar_Click;
            // 
            // btnGraficar
            // 
            btnGraficar.BackgroundImage = Properties.Resources.grafica;
            btnGraficar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGraficar.FlatStyle = FlatStyle.Flat;
            btnGraficar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGraficar.Location = new Point(171, 37);
            btnGraficar.Margin = new Padding(2);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(45, 30);
            btnGraficar.TabIndex = 28;
            btnGraficar.UseVisualStyleBackColor = true;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // txtDeltaP
            // 
            txtDeltaP.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeltaP.Location = new Point(230, 43);
            txtDeltaP.Margin = new Padding(2);
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.Size = new Size(60, 23);
            txtDeltaP.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(2, 11, 10);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(12, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 83);
            panel3.TabIndex = 45;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(187, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(38, 21);
            panel4.TabIndex = 45;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(16, 36);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(31, 30);
            button4.TabIndex = 44;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(2, 11, 10);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtVelLinealGas);
            panel5.Controls.Add(txtJsl);
            panel5.Controls.Add(txtDeltaP);
            panel5.Location = new Point(236, 510);
            panel5.Name = "panel5";
            panel5.Size = new Size(305, 171);
            panel5.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(72, 11);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(145, 16);
            label7.TabIndex = 53;
            label7.Text = "DATOS DE ENTRADA";
            // 
            // pnlGraficas
            // 
            pnlGraficas.BackColor = Color.FromArgb(2, 11, 10);
            pnlGraficas.Location = new Point(236, 7);
            pnlGraficas.Name = "pnlGraficas";
            pnlGraficas.Size = new Size(584, 483);
            pnlGraficas.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(2, 11, 10);
            panel9.Controls.Add(lblReloj);
            panel9.Location = new Point(845, 541);
            panel9.Name = "panel9";
            panel9.Size = new Size(277, 100);
            panel9.TabIndex = 49;
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.BackColor = Color.Transparent;
            lblReloj.Font = new Font("DF7seg", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReloj.ForeColor = Color.White;
            lblReloj.Location = new Point(13, 20);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(252, 48);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(2, 11, 10);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(radioButton2);
            panel8.Controls.Add(radioButton1);
            panel8.Location = new Point(845, 57);
            panel8.Name = "panel8";
            panel8.Size = new Size(178, 116);
            panel8.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 16);
            label1.TabIndex = 52;
            label1.Text = "MODO DE EJECUCIÓN";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(2, 11, 10);
            panel10.Controls.Add(button4);
            panel10.Controls.Add(btnGraficar);
            panel10.Controls.Add(button3);
            panel10.Controls.Add(btnCalibrar);
            panel10.Controls.Add(button1);
            panel10.Controls.Add(button2);
            panel10.Location = new Point(845, 244);
            panel10.Name = "panel10";
            panel10.Size = new Size(262, 91);
            panel10.TabIndex = 51;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1134, 749);
            Controls.Add(panel1);
            Controls.Add(pnlGraficas);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel10);
            Controls.Add(panel5);
            Controls.Add(panel8);
            Controls.Add(panel9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Variable;
        private DataGridViewTextBoxColumn Resultado;
        private Button button3;
        private TextBox txtJsl;
        private Label label6;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtVelLinealGas;
        private Label label2;
        private Button btnCalibrar;
        private Button btnGraficar;
        private TextBox txtDeltaP;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
        private Panel panel4;
        private Panel panel5;
        private Panel pnlGraficas;
        private Panel panel9;
        private Label lblReloj;
        private Panel panel8;
        private Panel panel10;
        private Label label7;
        private Label label1;
    }
}