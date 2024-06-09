
namespace CaidaPresion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeltaP = new System.Windows.Forms.TextBox();
            this.txtVelLinealGas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalibrar = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delta P";
            // 
            // txtDeltaP
            // 
            this.txtDeltaP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeltaP.Location = new System.Drawing.Point(884, 146);
            this.txtDeltaP.Name = "txtDeltaP";
            this.txtDeltaP.Size = new System.Drawing.Size(76, 30);
            this.txtDeltaP.TabIndex = 1;
            // 
            // txtVelLinealGas
            // 
            this.txtVelLinealGas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelLinealGas.Location = new System.Drawing.Point(884, 195);
            this.txtVelLinealGas.Name = "txtVelLinealGas";
            this.txtVelLinealGas.Size = new System.Drawing.Size(76, 30);
            this.txtVelLinealGas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Velocidad lineal del gas (m/s)";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(717, 99);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(142, 28);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Automático";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(583, 99);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 28);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Manual";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtResultados
            // 
            this.txtResultados.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultados.Location = new System.Drawing.Point(562, 247);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.Size = new System.Drawing.Size(398, 139);
            this.txtResultados.TabIndex = 13;
            this.txtResultados.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Indira Bermejo Fernandez";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dir. Jorge Luis Piñeres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "David Padilla Maza";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CaidaPresion.Properties.Resources.Sin_título;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(971, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 359);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CaidaPresion.Properties.Resources.descarga;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 104);
            this.panel1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CaidaPresion.Properties.Resources.exportar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(592, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CaidaPresion.Properties.Resources.nuevo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(419, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCalibrar
            // 
            this.btnCalibrar.BackgroundImage = global::CaidaPresion.Properties.Resources.descarga__1_;
            this.btnCalibrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalibrar.Enabled = false;
            this.btnCalibrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalibrar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalibrar.Location = new System.Drawing.Point(465, 429);
            this.btnCalibrar.Name = "btnCalibrar";
            this.btnCalibrar.Size = new System.Drawing.Size(57, 40);
            this.btnCalibrar.TabIndex = 3;
            this.btnCalibrar.UseVisualStyleBackColor = true;
            this.btnCalibrar.Click += new System.EventHandler(this.btnCalibrar_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackgroundImage = global::CaidaPresion.Properties.Resources.grafica;
            this.btnGraficar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(528, 429);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(58, 40);
            this.btnGraficar.TabIndex = 2;
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
     
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtVelLinealGas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalibrar);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.txtDeltaP);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Columna de flotación";     
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
       
    }
}

