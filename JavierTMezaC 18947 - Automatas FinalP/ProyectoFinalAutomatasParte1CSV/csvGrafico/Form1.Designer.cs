namespace csvGrafico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTMCodificado = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbTMCodificado = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbInsetarInput = new System.Windows.Forms.TextBox();
            this.txtbInputCodificado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoTM = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtbCinta3 = new System.Windows.Forms.TextBox();
            this.txtbCinta2 = new System.Windows.Forms.TextBox();
            this.txtbCinta1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevoInput = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(13, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Archivo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTMCodificado
            // 
            this.lblTMCodificado.AutoSize = true;
            this.lblTMCodificado.Location = new System.Drawing.Point(19, 40);
            this.lblTMCodificado.Name = "lblTMCodificado";
            this.lblTMCodificado.Size = new System.Drawing.Size(79, 13);
            this.lblTMCodificado.TabIndex = 4;
            this.lblTMCodificado.Text = "TM Codificado:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(384, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genearr archivo .txt:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(10, 14);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(72, 13);
            this.lblInput.TabIndex = 7;
            this.lblInput.Text = "Insertar Input:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbTMCodificado);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.lblTMCodificado);
            this.panel1.Location = new System.Drawing.Point(26, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 96);
            this.panel1.TabIndex = 8;
            // 
            // txtbTMCodificado
            // 
            this.txtbTMCodificado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbTMCodificado.Location = new System.Drawing.Point(103, 37);
            this.txtbTMCodificado.Multiline = true;
            this.txtbTMCodificado.Name = "txtbTMCodificado";
            this.txtbTMCodificado.ReadOnly = true;
            this.txtbTMCodificado.Size = new System.Drawing.Size(345, 56);
            this.txtbTMCodificado.TabIndex = 5;
            this.txtbTMCodificado.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNuevoInput);
            this.panel2.Controls.Add(this.txtbInsetarInput);
            this.panel2.Controls.Add(this.txtbInputCodificado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblInput);
            this.panel2.Location = new System.Drawing.Point(26, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 68);
            this.panel2.TabIndex = 9;
            // 
            // txtbInsetarInput
            // 
            this.txtbInsetarInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbInsetarInput.Enabled = false;
            this.txtbInsetarInput.Location = new System.Drawing.Point(103, 11);
            this.txtbInsetarInput.Name = "txtbInsetarInput";
            this.txtbInsetarInput.Size = new System.Drawing.Size(242, 20);
            this.txtbInsetarInput.TabIndex = 3;
            this.txtbInsetarInput.Leave += new System.EventHandler(this.txtbInsetarInput_Leave);
            // 
            // txtbInputCodificado
            // 
            this.txtbInputCodificado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbInputCodificado.Location = new System.Drawing.Point(103, 40);
            this.txtbInputCodificado.Name = "txtbInputCodificado";
            this.txtbInputCodificado.ReadOnly = true;
            this.txtbInputCodificado.Size = new System.Drawing.Size(345, 20);
            this.txtbInputCodificado.TabIndex = 9;
            this.txtbInputCodificado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input Codificado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoTM);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.txtbCinta3);
            this.groupBox1.Controls.Add(this.txtbCinta2);
            this.groupBox1.Controls.Add(this.txtbCinta1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 191);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maquina Universal Turing";
            // 
            // btnNuevoTM
            // 
            this.btnNuevoTM.Enabled = false;
            this.btnNuevoTM.Location = new System.Drawing.Point(6, 157);
            this.btnNuevoTM.Name = "btnNuevoTM";
            this.btnNuevoTM.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoTM.TabIndex = 5;
            this.btnNuevoTM.Text = "Nuevo TM";
            this.btnNuevoTM.UseVisualStyleBackColor = true;
            this.btnNuevoTM.Click += new System.EventHandler(this.btnNuevoTM_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(329, 157);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtbCinta3
            // 
            this.txtbCinta3.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbCinta3.Location = new System.Drawing.Point(59, 121);
            this.txtbCinta3.Name = "txtbCinta3";
            this.txtbCinta3.ReadOnly = true;
            this.txtbCinta3.Size = new System.Drawing.Size(345, 20);
            this.txtbCinta3.TabIndex = 13;
            this.txtbCinta3.TabStop = false;
            // 
            // txtbCinta2
            // 
            this.txtbCinta2.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbCinta2.Location = new System.Drawing.Point(59, 90);
            this.txtbCinta2.Name = "txtbCinta2";
            this.txtbCinta2.ReadOnly = true;
            this.txtbCinta2.Size = new System.Drawing.Size(345, 20);
            this.txtbCinta2.TabIndex = 12;
            this.txtbCinta2.TabStop = false;
            // 
            // txtbCinta1
            // 
            this.txtbCinta1.BackColor = System.Drawing.Color.Gainsboro;
            this.txtbCinta1.Location = new System.Drawing.Point(59, 25);
            this.txtbCinta1.Multiline = true;
            this.txtbCinta1.Name = "txtbCinta1";
            this.txtbCinta1.ReadOnly = true;
            this.txtbCinta1.Size = new System.Drawing.Size(345, 59);
            this.txtbCinta1.TabIndex = 11;
            this.txtbCinta1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cinta 3 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cinta 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cinta 1 :";
            // 
            // btnNuevoInput
            // 
            this.btnNuevoInput.Enabled = false;
            this.btnNuevoInput.Location = new System.Drawing.Point(351, 11);
            this.btnNuevoInput.Name = "btnNuevoInput";
            this.btnNuevoInput.Size = new System.Drawing.Size(97, 23);
            this.btnNuevoInput.TabIndex = 10;
            this.btnNuevoInput.Text = "Nuevo Input";
            this.btnNuevoInput.UseVisualStyleBackColor = true;
            this.btnNuevoInput.Click += new System.EventHandler(this.btnNuevoInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Maquina Universal Turing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTMCodificado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbTMCodificado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbInsetarInput;
        private System.Windows.Forms.TextBox txtbInputCodificado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtbCinta3;
        private System.Windows.Forms.TextBox txtbCinta2;
        private System.Windows.Forms.TextBox txtbCinta1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevoTM;
        private System.Windows.Forms.Button btnNuevoInput;
    }
}

