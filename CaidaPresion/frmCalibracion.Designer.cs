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
            ((System.ComponentModel.ISupportInitialize)numBaudRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDataBit).BeginInit();
            SuspendLayout();
            // 
            // cmbSerialPort
            // 
            cmbSerialPort.FormattingEnabled = true;
            cmbSerialPort.Location = new Point(194, 14);
            cmbSerialPort.Margin = new Padding(4, 5, 4, 5);
            cmbSerialPort.Name = "cmbSerialPort";
            cmbSerialPort.Size = new Size(171, 33);
            cmbSerialPort.TabIndex = 0;
            cmbSerialPort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 1;
            label1.Text = "Puertos Seriales";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(133, 64);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(54, 35);
            panel4.TabIndex = 47;
            // 
            // txtDeltaP
            // 
            txtDeltaP.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeltaP.Location = new Point(194, 64);
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.Size = new Size(84, 30);
            txtDeltaP.TabIndex = 46;
            // 
            // cmbParity
            // 
            cmbParity.FormattingEnabled = true;
            cmbParity.Location = new Point(194, 114);
            cmbParity.Margin = new Padding(4, 5, 4, 5);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(171, 33);
            cmbParity.TabIndex = 48;
            // 
            // numBaudRate
            // 
            numBaudRate.Location = new Point(195, 160);
            numBaudRate.Margin = new Padding(4, 5, 4, 5);
            numBaudRate.Name = "numBaudRate";
            numBaudRate.Size = new Size(171, 31);
            numBaudRate.TabIndex = 49;
            // 
            // numDataBit
            // 
            numDataBit.Location = new Point(197, 213);
            numDataBit.Margin = new Padding(4, 5, 4, 5);
            numDataBit.Name = "numDataBit";
            numDataBit.Size = new Size(171, 31);
            numDataBit.TabIndex = 50;
            // 
            // cmbStopBits
            // 
            cmbStopBits.FormattingEnabled = true;
            cmbStopBits.Location = new Point(195, 256);
            cmbStopBits.Margin = new Padding(4, 5, 4, 5);
            cmbStopBits.Name = "cmbStopBits";
            cmbStopBits.Size = new Size(171, 33);
            cmbStopBits.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 217);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 24);
            label2.TabIndex = 52;
            label2.Text = "DataBits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 118);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 53;
            label3.Text = "Parity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 163);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 54;
            label4.Text = "BaudRate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 261);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 24);
            label5.TabIndex = 55;
            label5.Text = "StopBits";
            // 
            // frmCalibracion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 375);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbStopBits);
            Controls.Add(numDataBit);
            Controls.Add(numBaudRate);
            Controls.Add(cmbParity);
            Controls.Add(panel4);
            Controls.Add(txtDeltaP);
            Controls.Add(label1);
            Controls.Add(cmbSerialPort);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCalibracion";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numBaudRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDataBit).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}