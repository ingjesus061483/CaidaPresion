namespace CaidaPresion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtDeltaP = new TextBox();
            txtVelLinealGas = new TextBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnCalibrar = new Button();
            btnGraficar = new Button();
            txtJsl = new TextBox();
            label6 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Variable = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(890, 186);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 0;
            label1.Text = "Delta P";
            // 
            // txtDeltaP
            // 
            txtDeltaP.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeltaP.Location = new Point(982, 182);
            txtDeltaP.Margin = new Padding(3, 4, 3, 4);
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.Size = new Size(84, 30);
            txtDeltaP.TabIndex = 1;
            // 
            // txtVelLinealGas
            // 
            txtVelLinealGas.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVelLinealGas.Location = new Point(982, 220);
            txtVelLinealGas.Margin = new Padding(3, 4, 3, 4);
            txtVelLinealGas.Name = "txtVelLinealGas";
            txtVelLinealGas.Size = new Size(84, 30);
            txtVelLinealGas.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(683, 224);
            label2.Name = "label2";
            label2.Size = new Size(284, 24);
            label2.TabIndex = 4;
            label2.Text = "Velocidad lineal del gas (m/s)";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(797, 124);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(142, 28);
            radioButton1.TabIndex = 11;
            radioButton1.Text = "Automático";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(648, 124);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 28);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Manual";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 11);
            label3.Name = "label3";
            label3.Size = new Size(252, 24);
            label3.TabIndex = 16;
            label3.Text = "Indira Bermejo Fernandez";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(220, 84);
            label4.Name = "label4";
            label4.Size = new Size(225, 24);
            label4.TabIndex = 17;
            label4.Text = "Dir. Jorge Luis Piñeres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(241, 48);
            label5.Name = "label5";
            label5.Size = new Size(186, 24);
            label5.TabIndex = 18;
            label5.Text = "David Padilla Maza";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Sin_título;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(1079, 84);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(127, 449);
            panel2.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.descarga;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(13, 11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(117, 130);
            panel1.TabIndex = 19;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.exportar;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(658, 536);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(44, 50);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.nuevo;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(466, 536);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(44, 50);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCalibrar
            // 
            btnCalibrar.BackgroundImage = Properties.Resources.descarga__1_;
            btnCalibrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalibrar.Enabled = false;
            btnCalibrar.FlatStyle = FlatStyle.Flat;
            btnCalibrar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalibrar.Location = new Point(517, 536);
            btnCalibrar.Margin = new Padding(3, 4, 3, 4);
            btnCalibrar.Name = "btnCalibrar";
            btnCalibrar.Size = new Size(63, 50);
            btnCalibrar.TabIndex = 3;
            btnCalibrar.UseVisualStyleBackColor = true;
            btnCalibrar.Click += btnCalibrar_Click;
            // 
            // btnGraficar
            // 
            btnGraficar.BackgroundImage = Properties.Resources.grafica;
            btnGraficar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGraficar.FlatStyle = FlatStyle.Flat;
            btnGraficar.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGraficar.Location = new Point(587, 538);
            btnGraficar.Margin = new Padding(3, 4, 3, 4);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(64, 50);
            btnGraficar.TabIndex = 2;
            btnGraficar.UseVisualStyleBackColor = true;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // txtJsl
            // 
            txtJsl.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJsl.Location = new Point(982, 264);
            txtJsl.Margin = new Padding(3, 4, 3, 4);
            txtJsl.Name = "txtJsl";
            txtJsl.Size = new Size(84, 30);
            txtJsl.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(925, 269);
            label6.Name = "label6";
            label6.Size = new Size(37, 24);
            label6.TabIndex = 22;
            label6.Text = "Jsl";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(416, 536);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(44, 50);
            button3.TabIndex = 24;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Variable, Resultado });
            dataGridView1.Location = new Point(683, 313);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(383, 205);
            dataGridView1.TabIndex = 25;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1219, 609);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(txtJsl);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtVelLinealGas);
            Controls.Add(label2);
            Controls.Add(btnCalibrar);
            Controls.Add(btnGraficar);
            Controls.Add(txtDeltaP);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Columna de flotación";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeltaP;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btnCalibrar;
        private System.Windows.Forms.TextBox txtVelLinealGas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private TextBox txtJsl;
        private Label label6;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Variable;
        private DataGridViewTextBoxColumn Resultado;
    }
}
