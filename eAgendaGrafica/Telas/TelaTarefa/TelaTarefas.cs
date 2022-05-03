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
    public partial class TelaTarefas : Form
    {
        private RepositorioTarefa _repositorioTarefa;

        public TelaTarefas()
        {
            _repositorioTarefa = new RepositorioTarefa();
            InitializeComponent();
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = _repositorioTarefa.SelecionarTodos();

            List<Tarefa> tarefasOrdenadas = tarefas.OrderByDescending(x => x.Prioridade).ToList();

            lBoxNaoConcluidas.Items.Clear();
            lBoxConcluidas.Items.Clear();

            foreach (Tarefa tarefa in tarefasOrdenadas)
            {
                if (tarefa.CalcularPercentualConcluido() < 100)
                {
                    lBoxNaoConcluidas.Items.Add(tarefa);
                }
                else if (tarefa.CalcularPercentualConcluido() == 100)
                {
                    lBoxConcluidas.Items.Add(tarefa);
                }
            }
        }

        private void CadastrarTarefa()
        {

            TelaCadastroTarefa telaCadastro = new TelaCadastroTarefa();

            telaCadastro.ShowDialog();

            if (telaCadastro.Tarefa.Titulo == null)
            {
                MessageBox.Show("Por favor, digite um titulo.", "Cadastro de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (telaCadastro.Tarefa.Prioridade == 0)
                {
                    telaCadastro.Tarefa.Prioridade = 1;
                }
                telaCadastro.Tarefa.DataCriacao = DateTime.Now;
                _repositorioTarefa.Inserir(telaCadastro.Tarefa);
                CarregarTarefas();
            }

        }

        private void EditarTarefa()
        {
            Tarefa tarefaEscolhida = (Tarefa)lBoxNaoConcluidas.SelectedItem;

            if (tarefaEscolhida == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa primeiro.", "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroTarefa telaCadastro = new TelaCadastroTarefa();

            telaCadastro.Tarefa = tarefaEscolhida;

            telaCadastro.ShowDialog();


            _repositorioTarefa.Editar(telaCadastro.Tarefa);
            CarregarTarefas();

        }

        private void ExcluirTarefa()
        {
            Tarefa tarefaEscolhida = (Tarefa)lBoxNaoConcluidas.SelectedItem;
            if (tarefaEscolhida == null)
            {
                tarefaEscolhida = (Tarefa)lBoxNaoConcluidas.SelectedItem;
            }

            if (tarefaEscolhida == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa primeiro.", "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _repositorioTarefa.Excluir(tarefaEscolhida);
            CarregarTarefas();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarTarefa();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarTarefa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirTarefa();
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            Tarefa tarefaEscolhida = (Tarefa)lBoxNaoConcluidas.SelectedItem;
            if (tarefaEscolhida == null)
                tarefaEscolhida = (Tarefa)lBoxNaoConcluidas.SelectedItem;

            if (tarefaEscolhida == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa primeiro.", "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroItem telaItens = new TelaCadastroItem(tarefaEscolhida);

            if (telaItens.ShowDialog() == DialogResult.OK)
            {
                List<Item> itens = telaItens.ItensAdicionados;

                _repositorioTarefa.AdicionarItens(tarefaEscolhida, itens);

                CarregarTarefas();
            }
        }

        private void btnItemConcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaEscolhida = (Tarefa)lBoxNaoConcluidas.SelectedItem;

            if (tarefaEscolhida == null)
            {
                MessageBox.Show("Por favor, selecione uma tarefa primeiro.", "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaAtualizarItens telaAtualizaItem = new TelaAtualizarItens(tarefaEscolhida);

            if (telaAtualizaItem.ShowDialog() == DialogResult.OK)
            {
                List<Item> itensConcluidos = telaAtualizaItem.ItensConcluidos;

                List<Item> itensPendentes = telaAtualizaItem.ItensPendentes;

                _repositorioTarefa.AtualizarItens(tarefaEscolhida, itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
        }


    }
}
