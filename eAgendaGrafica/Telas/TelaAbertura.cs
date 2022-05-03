using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgendaGrafica.Compartilhado;
using eAgendaGrafica.Telas.TelaTarefa;
using eAgendaGrafica.Telas.TelaContato;
using eAgendaGrafica.Telas.TelaCompromissos;
using eAgendaGrafica.Telas;

namespace eAgendaGrafica
{
    public partial class TelaAbertura : Form
    {

        public TelaAbertura()
        {
            InitializeComponent();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            TelaCompromissos telaCompromissos = new TelaCompromissos();
            telaCompromissos.ShowDialog();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            TelaTarefas telaTarefas = new TelaTarefas();
            telaTarefas.ShowDialog();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            TelaContatos telaContatos = new TelaContatos();
            telaContatos.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            TelaDev telaDev = new TelaDev();
            telaDev.ShowDialog();
        }
    }
}
