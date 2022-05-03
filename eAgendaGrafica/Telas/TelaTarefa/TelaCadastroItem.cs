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
    public partial class TelaCadastroItem : Form
    {
        private Tarefa tarefa;

        public TelaCadastroItem(Tarefa tarefaEscolhida)
        {

            this.tarefa = tarefaEscolhida;

            foreach (Item item in tarefa.Itens)
            {
                lBoxItens.Items.Add(item);
            }

            InitializeComponent();
        }

        public List<Item> ItensAdicionados
        {
            get
            {
                return lBoxItens.Items.Cast<Item>().ToList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> itens = ItensAdicionados.Select(x => x.Nome).ToList();

            if (itens.Count == 0 || itens.Contains(txtItem.Text) == false)
            {
                Item item = new Item();

                item.Nome = txtItem.Text;

                lBoxItens.Items.Add(item);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
