namespace CaidaPresion
{
    partial class frmCalibracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalibracion));
            cmbSerialPort = new ComboBox();
            label1 = new Label();
            panel4 = new Panel();
            txtDeltaP = new TextBox();
            cmbParity = new ComboBox();
            numBaudRate = new NumericUpDown();
            numDataBit = new NumericUpDown();
            cmbStopBits = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numBaudRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDataBit).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSerialPort
            // 
            cmbSerialPort.FormattingEnabled = true;
            cmbSerialPort.Location = new Point(137, 15);
            cmbSerialPort.Name = "cmbSerialPort";
            cmbSerialPort.Size = new Size(121, 23);
            cmbSerialPort.TabIndex = 0;
            cmbSerialPort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 16);
            label1.TabIndex = 1;
            label1.Text = "Puertos Seriales";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(94, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(38, 21);
            panel4.TabIndex = 47;
            // 
            // txtDeltaP
            // 
            txtDeltaP.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeltaP.Location = new Point(137, 45);
            txtDeltaP.Margin = new Padding(2, 2, 2, 2);
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.Size = new Size(60, 23);
            txtDeltaP.TabIndex = 46;
            // 
            // cmbParity
            // 
            cmbParity.FormattingEnabled = true;
            cmbParity.Location = new Point(137, 75);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(121, 23);
            cmbParity.TabIndex = 48;
            // 
            // numBaudRate
            // 
            numBaudRate.Location = new Point(137, 103);
            numBaudRate.Name = "numBaudRate";
            numBaudRate.Size = new Size(120, 23);
            numBaudRate.TabIndex = 49;
            // 
            // numDataBit
            // 
            numDataBit.Location = new Point(139, 135);
            numDataBit.Name = "numDataBit";
            numDataBit.Size = new Size(120, 23);
            numDataBit.TabIndex = 50;
            // 
            // cmbStopBits
            // 
            cmbStopBits.FormattingEnabled = true;
            cmbStopBits.Location = new Point(137, 161);
            cmbStopBits.Name = "cmbStopBits";
            cmbStopBits.Size = new Size(121, 23);
            cmbStopBits.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 142);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 52;
            label2.Text = "DataBits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(81, 78);
            label3.Name = "label3";
            label3.Size = new Size(46, 16);
            label3.TabIndex = 53;
            label3.Text = "Parity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(52, 110);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 54;
            label4.Text = "BaudRate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(63, 168);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 55;
            label5.Text = "StopBits";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 11, 10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbSerialPort);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDeltaP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbParity);
            panel1.Controls.Add(cmbStopBits);
            panel1.Controls.Add(numBaudRate);
            panel1.Controls.Add(numDataBit);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 201);
            panel1.TabIndex = 56;
            // 
            // frmCalibracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(283, 257);
            Controls.Add(panel1);
            Name = "frmCalibracion";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numBaudRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDataBit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSerialPort;
        private Label label1;
        private Panel panel4;
        private TextBox txtDeltaP;
        private ComboBox cmbParity;
        private NumericUpDown numBaudRate;
        private NumericUpDown numDataBit;
        private ComboBox cmbStopBits;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}