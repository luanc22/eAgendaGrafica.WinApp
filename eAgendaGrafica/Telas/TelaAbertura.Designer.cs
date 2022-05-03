namespace eAgendaGrafica
{
    partial class TelaAbertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAbertura));
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompromissos
            // 
            resources.ApplyResources(this.btnCompromissos, "btnCompromissos");
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // lblBemVindo
            // 
            resources.ApplyResources(this.lblBemVindo, "lblBemVindo");
            this.lblBemVindo.Name = "lblBemVindo";
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.Name = "lblTitulo";
            // 
            // btnContatos
            // 
            resources.ApplyResources(this.btnContatos, "btnContatos");
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnTarefas
            // 
            resources.ApplyResources(this.btnTarefas, "btnTarefas");
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDev
            // 
            resources.ApplyResources(this.btnDev, "btnDev");
            this.btnDev.Name = "btnDev";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // TelaAbertura
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDev);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnCompromissos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaAbertura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompromissos;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDev;
    }
}
