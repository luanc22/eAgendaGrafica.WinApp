namespace eAgendaGrafica.Telas.TelaTarefa
{
    partial class TelaCadastroTarefa
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.chkBaixa = new System.Windows.Forms.CheckBox();
            this.chkMedia = new System.Windows.Forms.CheckBox();
            this.chkAlta = new System.Windows.Forms.CheckBox();
            this.lBtnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prioridade";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(73, 34);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(248, 23);
            this.txtTitulo.TabIndex = 2;
            // 
            // chkBaixa
            // 
            this.chkBaixa.AutoSize = true;
            this.chkBaixa.Location = new System.Drawing.Point(125, 133);
            this.chkBaixa.Name = "chkBaixa";
            this.chkBaixa.Size = new System.Drawing.Size(54, 19);
            this.chkBaixa.TabIndex = 3;
            this.chkBaixa.Text = "Baixa";
            this.chkBaixa.UseVisualStyleBackColor = true;
            this.chkBaixa.CheckedChanged += new System.EventHandler(this.chkBaixa_CheckedChanged);
            // 
            // chkMedia
            // 
            this.chkMedia.AutoSize = true;
            this.chkMedia.Location = new System.Drawing.Point(125, 108);
            this.chkMedia.Name = "chkMedia";
            this.chkMedia.Size = new System.Drawing.Size(59, 19);
            this.chkMedia.TabIndex = 4;
            this.chkMedia.Text = "Media";
            this.chkMedia.UseVisualStyleBackColor = true;
            this.chkMedia.CheckedChanged += new System.EventHandler(this.chkMedia_CheckedChanged);
            // 
            // chkAlta
            // 
            this.chkAlta.AutoSize = true;
            this.chkAlta.Location = new System.Drawing.Point(125, 83);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.Size = new System.Drawing.Size(47, 19);
            this.chkAlta.TabIndex = 5;
            this.chkAlta.Text = "Alta";
            this.chkAlta.UseVisualStyleBackColor = true;
            this.chkAlta.CheckedChanged += new System.EventHandler(this.chkAlta_CheckedChanged);
            // 
            // lBtnConfirmar
            // 
            this.lBtnConfirmar.Location = new System.Drawing.Point(233, 188);
            this.lBtnConfirmar.Name = "lBtnConfirmar";
            this.lBtnConfirmar.Size = new System.Drawing.Size(88, 23);
            this.lBtnConfirmar.TabIndex = 6;
            this.lBtnConfirmar.Text = "Confirmar";
            this.lBtnConfirmar.UseVisualStyleBackColor = true;
            this.lBtnConfirmar.Click += new System.EventHandler(this.lBtnConfirmar_Click);
            // 
            // TelaCadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 223);
            this.Controls.Add(this.lBtnConfirmar);
            this.Controls.Add(this.chkAlta);
            this.Controls.Add(this.chkMedia);
            this.Controls.Add(this.chkBaixa);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaCadastroTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.CheckBox chkBaixa;
        private System.Windows.Forms.CheckBox chkMedia;
        private System.Windows.Forms.CheckBox chkAlta;
        private System.Windows.Forms.Button lBtnConfirmar;
    }
}