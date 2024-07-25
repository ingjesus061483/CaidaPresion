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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Variable, Resultado });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 245);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(356, 208);
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
            button3.Location = new Point(98, 207);
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
            txtJsl.Location = new Point(239, 168);
            txtJsl.Margin = new Padding(2);
            txtJsl.Name = "txtJsl";
            txtJsl.Size = new Size(60, 23);
            txtJsl.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(200, 171);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 16);
            label6.TabIndex = 42;
            label6.Text = "Jsl";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.descarga;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(82, 78);
            panel1.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(160, 24);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 16);
            label5.TabIndex = 39;
            label5.Text = "David Padilla Maza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(145, 45);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 16);
            label4.TabIndex = 38;
            label4.Text = "Dir. Jorge Luis Piñeres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 2);
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
            button2.Location = new Point(268, 207);
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
            button1.Location = new Point(133, 207);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(31, 30);
            button1.TabIndex = 35;
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(6, 84);
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
            radioButton1.Location = new Point(110, 84);
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
            txtVelLinealGas.Location = new Point(239, 142);
            txtVelLinealGas.Margin = new Padding(2);
            txtVelLinealGas.Name = "txtVelLinealGas";
            txtVelLinealGas.Size = new Size(60, 23);
            txtVelLinealGas.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 144);
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
            btnCalibrar.Location = new Point(169, 207);
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
            btnGraficar.Location = new Point(218, 208);
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
            txtDeltaP.Location = new Point(239, 119);
            txtDeltaP.Margin = new Padding(2);
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.Size = new Size(60, 23);
            txtDeltaP.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(425, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 453);
            panel2.TabIndex = 46;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtDeltaP);
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnGraficar);
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(txtJsl);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnCalibrar);
            panel3.Controls.Add(txtVelLinealGas);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 245);
            panel3.TabIndex = 45;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(196, 119);
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
            button4.Location = new Point(63, 207);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(31, 30);
            button4.TabIndex = 44;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(356, 431);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(498, 22);
            statusStrip1.TabIndex = 47;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 453);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel2;
        private Panel panel3;
        private Button button4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel4;
    }
}