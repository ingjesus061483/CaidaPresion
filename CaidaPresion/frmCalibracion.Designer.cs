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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSerialPort
            // 
            cmbSerialPort.FormattingEnabled = true;
            cmbSerialPort.Location = new Point(196, 25);
            cmbSerialPort.Margin = new Padding(4, 5, 4, 5);
            cmbSerialPort.Name = "cmbSerialPort";
            cmbSerialPort.Size = new Size(200, 33);
            cmbSerialPort.TabIndex = 0;
            cmbSerialPort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 30);
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
            panel4.Location = new Point(134, 75);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(54, 35);
            panel4.TabIndex = 47;
            // 
            // txtDeltaP
            // 
            txtDeltaP.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeltaP.Location = new Point(196, 75);
            txtDeltaP.Name = "txtDeltaP";
            txtDeltaP.ReadOnly = true;
            txtDeltaP.Size = new Size(200, 30);
            txtDeltaP.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 11, 10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbSerialPort);
            panel1.Controls.Add(txtDeltaP);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(17, 20);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 145);
            panel1.TabIndex = 56;
            // 
            // frmCalibracion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(453, 186);
            ControlBox = false;
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCalibracion";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSerialPort;
        private Label label1;
        private Panel panel4;
        private TextBox txtDeltaP;
        private Panel panel1;
    }
}