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
    public partial class TelaAtualizarItens : Form
    {
        private Tarefa tarefa;

        public TelaAtualizarItens(Tarefa tarefa)
        {
            InitializeComponent();

            this.tarefa = tarefa;

            CarregarItensTarefa(tarefa);
        }

        private void CarregarItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                clBoxItens.Items.Add(item);

                if (item.Conclusao)
                    clBoxItens.SetItemChecked(i, true);

                i++;
            }
        }

        public List<Item> ItensConcluidos
        {
            get
            {
                return clBoxItens.CheckedItems
                    .Cast<Item>()
                    .ToList();
            }
        }

        public List<Item> ItensPendentes
        {
            get
            {
                return clBoxItens.Items
                    .Cast<Item>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
