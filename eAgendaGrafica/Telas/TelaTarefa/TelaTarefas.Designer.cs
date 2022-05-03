namespace eAgendaGrafica.Telas.TelaTarefa
{
    partial class TelaTarefas
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
            this.lBoxNaoConcluidas = new System.Windows.Forms.ListBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.lBoxConcluidas = new System.Windows.Forms.ListBox();
            this.lblTarefas = new System.Windows.Forms.Label();
            this.btnItemConcluir = new System.Windows.Forms.Button();
            this.lblItens = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBoxNaoConcluidas
            // 
            this.lBoxNaoConcluidas.FormattingEnabled = true;
            this.lBoxNaoConcluidas.ItemHeight = 15;
            this.lBoxNaoConcluidas.Location = new System.Drawing.Point(269, 30);
            this.lBoxNaoConcluidas.Name = "lBoxNaoConcluidas";
            this.lBoxNaoConcluidas.Size = new System.Drawing.Size(519, 184);
            this.lBoxNaoConcluidas.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(26, 106);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(220, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(26, 135);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(220, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(26, 164);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(220, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(26, 309);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(220, 23);
            this.btnItemAdd.TabIndex = 4;
            this.btnItemAdd.Text = "Adicionar Item";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // lBoxConcluidas
            // 
            this.lBoxConcluidas.FormattingEnabled = true;
            this.lBoxConcluidas.ItemHeight = 15;
            this.lBoxConcluidas.Location = new System.Drawing.Point(269, 254);
            this.lBoxConcluidas.Name = "lBoxConcluidas";
            this.lBoxConcluidas.Size = new System.Drawing.Size(519, 184);
            this.lBoxConcluidas.TabIndex = 5;
            // 
            // lblTarefas
            // 
            this.lblTarefas.AutoSize = true;
            this.lblTarefas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTarefas.Location = new System.Drawing.Point(98, 81);
            this.lblTarefas.Name = "lblTarefas";
            this.lblTarefas.Size = new System.Drawing.Size(73, 22);
            this.lblTarefas.TabIndex = 6;
            this.lblTarefas.Text = "Tarefas";
            // 
            // btnItemConcluir
            // 
            this.btnItemConcluir.Location = new System.Drawing.Point(26, 338);
            this.btnItemConcluir.Name = "btnItemConcluir";
            this.btnItemConcluir.Size = new System.Drawing.Size(220, 23);
            this.btnItemConcluir.TabIndex = 7;
            this.btnItemConcluir.Text = "Concluir Item";
            this.btnItemConcluir.UseVisualStyleBackColor = true;
            this.btnItemConcluir.Click += new System.EventHandler(this.btnItemConcluir_Click);
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItens.Location = new System.Drawing.Point(109, 284);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(52, 22);
            this.lblItens.TabIndex = 8;
            this.lblItens.Text = "Itens";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(269, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Concluidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(269, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pendentes";
            // 
            // TelaTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.btnItemConcluir);
            this.Controls.Add(this.lblTarefas);
            this.Controls.Add(this.lBoxConcluidas);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lBoxNaoConcluidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxNaoConcluidas;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.ListBox lBoxConcluidas;
        private System.Windows.Forms.Label lblTarefas;
        private System.Windows.Forms.Button btnItemConcluir;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}