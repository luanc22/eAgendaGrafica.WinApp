using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgendaGrafica.Modulos.ModuloContato;

namespace eAgendaGrafica.Telas.TelaContato
{
    public partial class TelaCadastroContato : Form
    {
        private Contato contato = new Contato();


        public TelaCadastroContato()
        {
            InitializeComponent();
        }


        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtTelefone.Text = contato.Telefone.ToString();
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            int telefoneParse = int.Parse(telefone);
            contato.Telefone = telefoneParse;
            contato.Empresa = txtEmpresa.Text;
            contato.Cargo = txtCargo.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
