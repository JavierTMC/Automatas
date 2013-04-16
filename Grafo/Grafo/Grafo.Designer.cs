namespace Grafo
{
    partial class Grafo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_crearGrafo = new System.Windows.Forms.Button();
            this.rd_grafoNoDirigido = new System.Windows.Forms.RadioButton();
            this.rd_grafoDirigido = new System.Windows.Forms.RadioButton();
            this.panelGrafo = new System.Windows.Forms.Panel();
            this.TSMenu = new System.Windows.Forms.ToolStrip();
            this.TSBGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbAgregarAdyacencia = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminaNodo = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarAdyacencia = new System.Windows.Forms.ToolStripButton();
            this.TSDDBInformacion = new System.Windows.Forms.ToolStripDropDownButton();
            this.ordenDelGrafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoDeUnNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoDeCadaNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSLOperacionEjecutandose = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLAdyacencia = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChecarInput = new System.Windows.Forms.Button();
            this.btnIndicarEstadoInicial = new System.Windows.Forms.Button();
            this.btnEstadosAceptantes = new System.Windows.Forms.Button();
            this.gbLeyenda = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNFA = new System.Windows.Forms.RadioButton();
            this.rbDFA = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbResulatdoAutomata = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.TSMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbLeyenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_crearGrafo);
            this.panel1.Controls.Add(this.rd_grafoNoDirigido);
            this.panel1.Controls.Add(this.rd_grafoDirigido);
            this.panel1.Location = new System.Drawing.Point(21, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 65);
            this.panel1.TabIndex = 1;
            // 
            // btn_crearGrafo
            // 
            this.btn_crearGrafo.Location = new System.Drawing.Point(117, 14);
            this.btn_crearGrafo.Name = "btn_crearGrafo";
            this.btn_crearGrafo.Size = new System.Drawing.Size(75, 40);
            this.btn_crearGrafo.TabIndex = 2;
            this.btn_crearGrafo.Text = "Crear \r\nGrafo";
            this.btn_crearGrafo.UseVisualStyleBackColor = true;
            this.btn_crearGrafo.Click += new System.EventHandler(this.btn_crearGrafo_Click);
            // 
            // rd_grafoNoDirigido
            // 
            this.rd_grafoNoDirigido.AutoSize = true;
            this.rd_grafoNoDirigido.Location = new System.Drawing.Point(15, 37);
            this.rd_grafoNoDirigido.Name = "rd_grafoNoDirigido";
            this.rd_grafoNoDirigido.Size = new System.Drawing.Size(106, 17);
            this.rd_grafoNoDirigido.TabIndex = 1;
            this.rd_grafoNoDirigido.TabStop = true;
            this.rd_grafoNoDirigido.Text = "Grafo No Dirigido";
            this.rd_grafoNoDirigido.UseVisualStyleBackColor = true;
            // 
            // rd_grafoDirigido
            // 
            this.rd_grafoDirigido.AutoSize = true;
            this.rd_grafoDirigido.Location = new System.Drawing.Point(15, 14);
            this.rd_grafoDirigido.Name = "rd_grafoDirigido";
            this.rd_grafoDirigido.Size = new System.Drawing.Size(89, 17);
            this.rd_grafoDirigido.TabIndex = 0;
            this.rd_grafoDirigido.TabStop = true;
            this.rd_grafoDirigido.Text = "Grafo Dirigido";
            this.rd_grafoDirigido.UseVisualStyleBackColor = true;
            // 
            // panelGrafo
            // 
            this.panelGrafo.BackColor = System.Drawing.Color.Gainsboro;
            this.panelGrafo.Location = new System.Drawing.Point(12, 109);
            this.panelGrafo.Name = "panelGrafo";
            this.panelGrafo.Size = new System.Drawing.Size(888, 331);
            this.panelGrafo.TabIndex = 2;
            this.panelGrafo.Visible = false;
            this.panelGrafo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGrafo_MouseDown);
            // 
            // TSMenu
            // 
            this.TSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBGuardar,
            this.toolStripButton1,
            this.tsbAgregarAdyacencia,
            this.tsbEliminaNodo,
            this.tsbEliminarAdyacencia,
            this.TSDDBInformacion});
            this.TSMenu.Location = new System.Drawing.Point(0, 0);
            this.TSMenu.Name = "TSMenu";
            this.TSMenu.Size = new System.Drawing.Size(1110, 25);
            this.TSMenu.TabIndex = 3;
            this.TSMenu.Text = "toolStrip1";
            // 
            // TSBGuardar
            // 
            this.TSBGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TSBGuardar.Image")));
            this.TSBGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBGuardar.Name = "TSBGuardar";
            this.TSBGuardar.Size = new System.Drawing.Size(69, 22);
            this.TSBGuardar.Text = "Guardar";
            this.TSBGuardar.ToolTipText = "Guardar Grafo";
            this.TSBGuardar.Click += new System.EventHandler(this.TSBGuardar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(102, 22);
            this.toolStripButton1.Text = "Agregar Nodo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbAgregarAdyacencia
            // 
            this.tsbAgregarAdyacencia.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregarAdyacencia.Image")));
            this.tsbAgregarAdyacencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarAdyacencia.Name = "tsbAgregarAdyacencia";
            this.tsbAgregarAdyacencia.Size = new System.Drawing.Size(133, 22);
            this.tsbAgregarAdyacencia.Text = "Agregar Adyacencia";
            this.tsbAgregarAdyacencia.Click += new System.EventHandler(this.tsbAgregarAdyacencia_Click);
            // 
            // tsbEliminaNodo
            // 
            this.tsbEliminaNodo.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminaNodo.Image")));
            this.tsbEliminaNodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminaNodo.Name = "tsbEliminaNodo";
            this.tsbEliminaNodo.Size = new System.Drawing.Size(103, 22);
            this.tsbEliminaNodo.Text = "Eliminar Nodo";
            this.tsbEliminaNodo.Click += new System.EventHandler(this.tsbEliminaNodo_Click);
            // 
            // tsbEliminarAdyacencia
            // 
            this.tsbEliminarAdyacencia.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminarAdyacencia.Image")));
            this.tsbEliminarAdyacencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarAdyacencia.Name = "tsbEliminarAdyacencia";
            this.tsbEliminarAdyacencia.Size = new System.Drawing.Size(134, 22);
            this.tsbEliminarAdyacencia.Text = "Eliminar Adyacencia";
            this.tsbEliminarAdyacencia.Click += new System.EventHandler(this.tsbEliminarAdyacencia_Click);
            // 
            // TSDDBInformacion
            // 
            this.TSDDBInformacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSDDBInformacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDelGrafoToolStripMenuItem,
            this.gradoDeUnNodoToolStripMenuItem,
            this.gradoDeCadaNodoToolStripMenuItem,
            this.esCompletoToolStripMenuItem});
            this.TSDDBInformacion.Image = ((System.Drawing.Image)(resources.GetObject("TSDDBInformacion.Image")));
            this.TSDDBInformacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDBInformacion.Name = "TSDDBInformacion";
            this.TSDDBInformacion.Size = new System.Drawing.Size(135, 22);
            this.TSDDBInformacion.Text = "Informacion del grafo";
            // 
            // ordenDelGrafoToolStripMenuItem
            // 
            this.ordenDelGrafoToolStripMenuItem.Name = "ordenDelGrafoToolStripMenuItem";
            this.ordenDelGrafoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ordenDelGrafoToolStripMenuItem.Text = "Orden del Grafo";
            this.ordenDelGrafoToolStripMenuItem.Click += new System.EventHandler(this.ordenDelGrafoToolStripMenuItem_Click);
            // 
            // gradoDeUnNodoToolStripMenuItem
            // 
            this.gradoDeUnNodoToolStripMenuItem.Name = "gradoDeUnNodoToolStripMenuItem";
            this.gradoDeUnNodoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gradoDeUnNodoToolStripMenuItem.Text = "Grado de un Nodo";
            this.gradoDeUnNodoToolStripMenuItem.Click += new System.EventHandler(this.gradoDeUnNodoToolStripMenuItem_Click);
            // 
            // gradoDeCadaNodoToolStripMenuItem
            // 
            this.gradoDeCadaNodoToolStripMenuItem.Name = "gradoDeCadaNodoToolStripMenuItem";
            this.gradoDeCadaNodoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gradoDeCadaNodoToolStripMenuItem.Text = "Grado de cada Nodo";
            // 
            // esCompletoToolStripMenuItem
            // 
            this.esCompletoToolStripMenuItem.Name = "esCompletoToolStripMenuItem";
            this.esCompletoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.esCompletoToolStripMenuItem.Text = "Es completo?";
            this.esCompletoToolStripMenuItem.Click += new System.EventHandler(this.esCompletoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLOperacionEjecutandose,
            this.TSSLAdyacencia});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1110, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSLOperacionEjecutandose
            // 
            this.TSLOperacionEjecutandose.Name = "TSLOperacionEjecutandose";
            this.TSLOperacionEjecutandose.Size = new System.Drawing.Size(132, 17);
            this.TSLOperacionEjecutandose.Text = "OperacionEjecutandose";
            // 
            // TSSLAdyacencia
            // 
            this.TSSLAdyacencia.Name = "TSSLAdyacencia";
            this.TSSLAdyacencia.Size = new System.Drawing.Size(71, 17);
            this.TSSLAdyacencia.Text = "adyacencias";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbResulatdoAutomata);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbDFA);
            this.groupBox1.Controls.Add(this.rbNFA);
            this.groupBox1.Controls.Add(this.txtbInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnChecarInput);
            this.groupBox1.Controls.Add(this.btnIndicarEstadoInicial);
            this.groupBox1.Controls.Add(this.btnEstadosAceptantes);
            this.groupBox1.Location = new System.Drawing.Point(906, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 285);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatas";
            // 
            // txtbInput
            // 
            this.txtbInput.Location = new System.Drawing.Point(11, 131);
            this.txtbInput.Name = "txtbInput";
            this.txtbInput.Size = new System.Drawing.Size(100, 20);
            this.txtbInput.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Input";
            // 
            // btnChecarInput
            // 
            this.btnChecarInput.Location = new System.Drawing.Point(11, 157);
            this.btnChecarInput.Name = "btnChecarInput";
            this.btnChecarInput.Size = new System.Drawing.Size(114, 36);
            this.btnChecarInput.TabIndex = 2;
            this.btnChecarInput.Text = "Checar Input";
            this.btnChecarInput.UseVisualStyleBackColor = true;
            this.btnChecarInput.Click += new System.EventHandler(this.btnChecarInput_Click);
            // 
            // btnIndicarEstadoInicial
            // 
            this.btnIndicarEstadoInicial.Location = new System.Drawing.Point(12, 79);
            this.btnIndicarEstadoInicial.Name = "btnIndicarEstadoInicial";
            this.btnIndicarEstadoInicial.Size = new System.Drawing.Size(182, 21);
            this.btnIndicarEstadoInicial.TabIndex = 1;
            this.btnIndicarEstadoInicial.Text = "Indicar Estado Inicial";
            this.btnIndicarEstadoInicial.UseVisualStyleBackColor = true;
            this.btnIndicarEstadoInicial.Click += new System.EventHandler(this.btnIndicarEstadoInicial_Click);
            // 
            // btnEstadosAceptantes
            // 
            this.btnEstadosAceptantes.Location = new System.Drawing.Point(12, 49);
            this.btnEstadosAceptantes.Name = "btnEstadosAceptantes";
            this.btnEstadosAceptantes.Size = new System.Drawing.Size(182, 21);
            this.btnEstadosAceptantes.TabIndex = 0;
            this.btnEstadosAceptantes.Text = "Indicar Estado(s) Aceptante(es)";
            this.btnEstadosAceptantes.UseVisualStyleBackColor = true;
            this.btnEstadosAceptantes.Click += new System.EventHandler(this.btnEstadosAceptantes_Click);
            // 
            // gbLeyenda
            // 
            this.gbLeyenda.Controls.Add(this.label4);
            this.gbLeyenda.Controls.Add(this.label3);
            this.gbLeyenda.Controls.Add(this.label2);
            this.gbLeyenda.Controls.Add(this.label1);
            this.gbLeyenda.Location = new System.Drawing.Point(922, 12);
            this.gbLeyenda.Name = "gbLeyenda";
            this.gbLeyenda.Size = new System.Drawing.Size(158, 91);
            this.gbLeyenda.TabIndex = 8;
            this.gbLeyenda.TabStop = false;
            this.gbLeyenda.Text = "Leyenda";
            this.gbLeyenda.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado(s) Aceptantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // rbNFA
            // 
            this.rbNFA.AutoSize = true;
            this.rbNFA.Checked = true;
            this.rbNFA.Location = new System.Drawing.Point(23, 25);
            this.rbNFA.Name = "rbNFA";
            this.rbNFA.Size = new System.Drawing.Size(46, 17);
            this.rbNFA.TabIndex = 5;
            this.rbNFA.TabStop = true;
            this.rbNFA.Text = "NFA";
            this.rbNFA.UseVisualStyleBackColor = true;
            // 
            // rbDFA
            // 
            this.rbDFA.AutoSize = true;
            this.rbDFA.Location = new System.Drawing.Point(94, 24);
            this.rbDFA.Name = "rbDFA";
            this.rbDFA.Size = new System.Drawing.Size(46, 17);
            this.rbDFA.TabIndex = 6;
            this.rbDFA.TabStop = true;
            this.rbDFA.Text = "DFA";
            this.rbDFA.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Resultado del Automata:";
            // 
            // txtbResulatdoAutomata
            // 
            this.txtbResulatdoAutomata.Location = new System.Drawing.Point(16, 223);
            this.txtbResulatdoAutomata.Multiline = true;
            this.txtbResulatdoAutomata.Name = "txtbResulatdoAutomata";
            this.txtbResulatdoAutomata.Size = new System.Drawing.Size(159, 51);
            this.txtbResulatdoAutomata.TabIndex = 8;
            // 
            // Grafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbLeyenda);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TSMenu);
            this.Controls.Add(this.panelGrafo);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Grafo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafo";
            this.Load += new System.EventHandler(this.Grafo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TSMenu.ResumeLayout(false);
            this.TSMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbLeyenda.ResumeLayout(false);
            this.gbLeyenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_crearGrafo;
        private System.Windows.Forms.RadioButton rd_grafoNoDirigido;
        private System.Windows.Forms.RadioButton rd_grafoDirigido;
        private System.Windows.Forms.Panel panelGrafo;
        private System.Windows.Forms.ToolStrip TSMenu;
        private System.Windows.Forms.ToolStripButton TSBGuardar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSLOperacionEjecutandose;
        private System.Windows.Forms.ToolStripStatusLabel TSSLAdyacencia;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbAgregarAdyacencia;
        private System.Windows.Forms.ToolStripButton tsbEliminaNodo;
        private System.Windows.Forms.ToolStripButton tsbEliminarAdyacencia;
        private System.Windows.Forms.ToolStripDropDownButton TSDDBInformacion;
        private System.Windows.Forms.ToolStripMenuItem ordenDelGrafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoDeUnNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoDeCadaNodoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIndicarEstadoInicial;
        private System.Windows.Forms.Button btnEstadosAceptantes;
        private System.Windows.Forms.GroupBox gbLeyenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChecarInput;
        private System.Windows.Forms.RadioButton rbDFA;
        private System.Windows.Forms.RadioButton rbNFA;
        private System.Windows.Forms.TextBox txtbResulatdoAutomata;
        private System.Windows.Forms.Label label6;
    }
}