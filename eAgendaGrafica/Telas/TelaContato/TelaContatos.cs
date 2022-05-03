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
    public partial class TelaContatos : Form
    {
        private RepositorioContato _repositorioContato;

        public TelaContatos()
        {
            _repositorioContato = new RepositorioContato();
            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = _repositorioContato.SelecionarTodos();

            lBoxContatos.Items.Clear();

            foreach (Contato contato in contatos)
            {
                lBoxContatos.Items.Add(contato);
            }
        }

        private void CadastrarContato()
        {

            TelaCadastroContato telaCadastro = new TelaCadastroContato();

            telaCadastro.ShowDialog();

            string tipo = "Cadastrar";

            string validar = ValidarContato(telaCadastro.Contato, tipo);

            if (validar != "")
            {
                MessageBox.Show(validar, "Cadastro de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                _repositorioContato.Inserir(telaCadastro.Contato);
                CarregarContatos();
            }

        }

        private string ValidarContato(Contato contato, string tipo)
        {
            string validar = "";
            if (contato.Nome == "")
            {
                validar = "Por favor, insira um nome.";
            }
            if (ValidacaoEmail(contato.Email) == false)
            {
                validar += "\n E-Mail Invalido";
            }
            if (contato.Telefone.ToString().Length < 8 || contato.Telefone.ToString().Length > 9)
            {
                validar += "\n Telefone Invalido";
            }

            if (tipo == "Cadastrar")
            {
                List<Contato> listaContatos = _repositorioContato.SelecionarTodos();

                foreach (Contato contatoAvaliado in listaContatos)
                {
                    if (contatoAvaliado.Nome == contatoAvaliado.Nome)
                    {
                        validar += "\n Existe Contato com esse Nome";
                    }
                    if (contatoAvaliado.Email == contatoAvaliado.Email)
                    {
                        validar += "\n Existe Contato com esse E-mail";
                    }
                    if (contatoAvaliado.Telefone == contatoAvaliado.Telefone)
                    {
                        validar += "\n Existe Contato com esse Telefone";
                    }
                }
            }

            return validar;
        }

        private bool ValidacaoEmail(string email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(email);
                return enderecoEmail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void EditarContato()
        {

            Contato contatoEscolhido = (Contato)lBoxContatos.SelectedItem;
            if (contatoEscolhido == null)
            {
                contatoEscolhido = (Contato)lBoxContatos.SelectedItem;
            }

            if (contatoEscolhido == null)
            {
                MessageBox.Show("Selecione um contato primeiro", "Edição de Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroContato telaCadastro = new TelaCadastroContato();

            telaCadastro.Contato = contatoEscolhido;

            telaCadastro.ShowDialog();

            string tipo = "editar";

            string validar = ValidarContato(telaCadastro.Contato, tipo);

            if (validar != "")
            {
                MessageBox.Show(validar, "Cadastro de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                _repositorioContato.Editar(telaCadastro.Contato);
                CarregarContatos();
            }
        }

        private void ExcluirContato()
        {
            Contato contatoSelecionado = (Contato)lBoxContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro", "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _repositorioContato.Excluir(contatoSelecionado);
            CarregarContatos();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarContato();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarContato();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirContato();
        }

    }
}
