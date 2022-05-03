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
    public partial class TelaCompromissos : Form
    {
        private RepositorioCompromisso _repositorioCompromisso;
        private RepositorioContato _repositorioContato;

        public TelaCompromissos()
        {
            _repositorioCompromisso = new RepositorioCompromisso();
            _repositorioContato = new RepositorioContato();
            InitializeComponent();
            CarregarCompromisso();
        }

        private void CarregarCompromisso()
        {
            List<Compromisso> compromissos = _repositorioCompromisso.SelecionarTodos();

            List<Compromisso> compromissosPorData = compromissos.OrderBy(x => x.Dia).ToList();

            lBoxCompromissosFuturos.Items.Clear();

            int data = DateTime.Now.Day;

            foreach (Compromisso compromisso in compromissosPorData)
            {
                if(compromisso.Dia >= data)
                lBoxCompromissosFuturos.Items.Add(compromisso);

                else
                lBoxCompromissosPassados.Items.Add(compromisso);
            }
        }

        private void CadastrarCompromisso()
        {
            List<Contato> listaContatos = _repositorioContato.SelecionarTodos();

            if (listaContatos.Count == 0)
            {
                MessageBox.Show("Não possui contatos cadastrados!", "Cadastro de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroCompromisso telaCadastro = new TelaCadastroCompromisso(listaContatos);

            telaCadastro.ShowDialog();

            _repositorioCompromisso.Inserir(telaCadastro.Compromisso);
            _repositorioContato.Compromisso(telaCadastro.Compromisso.NomeContato);
            CarregarCompromisso();

        }

        private void EditarCompromisso()
        {
            Compromisso compromissoEscolhido = (Compromisso)lBoxCompromissosFuturos.SelectedItem;

            if (compromissoEscolhido == null)
            {
                MessageBox.Show("Por favor, selecione um compromisso primeiro", "Edição de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<Contato> listaContatos = _repositorioContato.SelecionarTodos();

            TelaCadastroCompromisso telaCadastro = new TelaCadastroCompromisso(listaContatos);

            telaCadastro.Compromisso = compromissoEscolhido;

            telaCadastro.ShowDialog();

            _repositorioCompromisso.Editar(telaCadastro.Compromisso);
            CarregarCompromisso();
        }

        private void ExcluirCompromisso()
        {
            Compromisso compromissoEscolhido = (Compromisso)lBoxCompromissosFuturos.SelectedItem;
            if (compromissoEscolhido == null)
            {
                compromissoEscolhido = (Compromisso)lBoxCompromissosPassados.SelectedItem;
            }

            if (compromissoEscolhido == null)
            {
                MessageBox.Show("Por favor, selecione um compromisso primeiro", "Exclusão de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _repositorioCompromisso.Excluir(compromissoEscolhido);
            CarregarCompromisso();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarCompromisso();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCompromisso();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCompromisso();
        }
    }
}
