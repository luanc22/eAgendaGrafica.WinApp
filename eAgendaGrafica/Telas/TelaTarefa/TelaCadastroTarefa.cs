using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgendaGrafica.Modulos.ModuloTarefa;

namespace eAgendaGrafica.Telas.TelaTarefa
{
    public partial class TelaCadastroTarefa : Form
    {
        private Tarefa tarefa = new Tarefa();
        private int contador;

        public TelaCadastroTarefa()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtTitulo.Text = tarefa.Titulo;
                if (tarefa.Prioridade == 3)
                {
                    chkAlta.Checked = true;
                }
                else if (tarefa.Prioridade == 2)
                {
                    chkMedia.Checked = true;
                }
                else if (tarefa.Prioridade == 1)
                {
                    chkBaixa.Checked = true;
                }
            }
        }

        private void lBtnConfirmar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = txtTitulo.Text;
            tarefa.ID = ++contador;
            DialogResult = DialogResult.OK;
        }

        private void chkAlta_CheckedChanged(object sender, EventArgs e)
        {
            tarefa.Prioridade = 3;
        }

        private void chkMedia_CheckedChanged(object sender, EventArgs e)
        {
            tarefa.Prioridade = 2;
        }

        private void chkBaixa_CheckedChanged(object sender, EventArgs e)
        {
            tarefa.Prioridade = 1;
        }
    }
}
