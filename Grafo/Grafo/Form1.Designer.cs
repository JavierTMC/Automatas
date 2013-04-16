namespace Grafo
{
    partial class frmInicio
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
            this.btn_crearGrafo = new System.Windows.Forms.Button();
            this.btn_abrirGrafo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_crearGrafo
            // 
            this.btn_crearGrafo.Location = new System.Drawing.Point(36, 46);
            this.btn_crearGrafo.Name = "btn_crearGrafo";
            this.btn_crearGrafo.Size = new System.Drawing.Size(130, 60);
            this.btn_crearGrafo.TabIndex = 0;
            this.btn_crearGrafo.Text = "Crear Grafo";
            this.btn_crearGrafo.UseVisualStyleBackColor = true;
            this.btn_crearGrafo.Click += new System.EventHandler(this.btn_crearGrafo_Click);
            // 
            // btn_abrirGrafo
            // 
            this.btn_abrirGrafo.Location = new System.Drawing.Point(36, 150);
            this.btn_abrirGrafo.Name = "btn_abrirGrafo";
            this.btn_abrirGrafo.Size = new System.Drawing.Size(130, 60);
            this.btn_abrirGrafo.TabIndex = 1;
            this.btn_abrirGrafo.Text = "Abrir Grafo";
            this.btn_abrirGrafo.UseVisualStyleBackColor = true;
            this.btn_abrirGrafo.Click += new System.EventHandler(this.btn_abrirGrafo_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(211, 262);
            this.Controls.Add(this.btn_abrirGrafo);
            this.Controls.Add(this.btn_crearGrafo);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crearGrafo;
        private System.Windows.Forms.Button btn_abrirGrafo;
    }
}

