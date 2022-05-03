using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgendaGrafica.Modulos.ModuloCompromisso;
using eAgendaGrafica.Modulos.ModuloContato;

namespace eAgendaGrafica.Telas.TelaCompromissos
{
    public partial class TelaCadastroCompromisso : Form
    {
        Compromisso compromisso = new Compromisso();

        public TelaCadastroCompromisso(List<Contato> listaContatos)
        {
            InitializeComponent();
            foreach (Contato contato in listaContatos)
            {
                cBoxContato.Items.Add(contato.Nome);
            }
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                txtDia.Text = compromisso.Dia.ToString();
                txtMes.Text = compromisso.Mes.ToString();
                txtHoraInicio.Text = compromisso.HoraInicio.ToString();
                txtHoraFim.Text = compromisso.HoraFim.ToString();
                cBoxContato.Text = compromisso.NomeContato;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = txtAssunto.Text;
            compromisso.Local = txtLocal.Text;
            string dia = txtDia.Text;
            compromisso.Dia = int.Parse(dia);
            string mes = txtMes.Text;
            compromisso.Mes = int.Parse(mes);
            string horaInicio = txtHoraInicio.Text;
            compromisso.HoraInicio = int.Parse(horaInicio);
            string horaFim = txtHoraFim.Text;
            compromisso.HoraFim = int.Parse(horaFim);
            compromisso.NomeContato = cBoxContato.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
