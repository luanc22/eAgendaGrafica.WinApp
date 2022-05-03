using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgendaGrafica.Compartilhado;

namespace eAgendaGrafica.Modulos.ModuloTarefa
{
    [Serializable]

    public class Tarefa : EntidadeBase
    {
        private string titulo;
        private int prioridade;
        private DateTime dataCriacao;
        private DateTime? dataConcluido;
        private List<Item> itens = new List<Item>();

        public string Titulo { get => titulo; set => titulo = value; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public DateTime? DataConcluido { get => dataConcluido; set => dataConcluido = value; }
        public List<Item> Itens { get => itens; set => itens = value; }

        public Tarefa() {}

        public Tarefa(string titulo, int id) : this() 
        {
            Titulo = titulo;
            ID = id;
        }

        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (DataConcluido.HasValue)
            {
                return
                    "ID: " + ID + Environment.NewLine +
                    " / Titulo: " + Titulo + Environment.NewLine +
                    " / Prioridade: " + definirPrioridade() + Environment.NewLine +
                    " / Conclusao: " + DataConcluido.Value.ToShortDateString() + Environment.NewLine;
            }

            return 
                "ID: " + ID + Environment.NewLine +
                    " / Titulo: " + Titulo + Environment.NewLine +
                    " / Prioridade: " + definirPrioridade() + Environment.NewLine +
                    " / Criacao: " + DataCriacao.ToShortDateString() + Environment.NewLine +
                    " / Conclusao: " + percentual + Environment.NewLine;
        }

        public void AdicionarItem(Item item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(Item item)
        {
            Item tarefa = itens.Find(x => x.Equals(item));

            tarefa?.Completo();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConcluido = DateTime.Now;
        }

        public void NaoCompleto(Item item)
        {
            Item tarefa = itens.Find(x => x.Equals(item));

            tarefa?.NaoCompleto();
        }

        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.Conclusao);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }

        private string definirPrioridade()
        {
            string stringPrioridade = "";
            if (Prioridade == 3)
            {
                stringPrioridade = "ALTA";
            }
            else if (Prioridade == 2)
            {
                stringPrioridade = "MEDIA";
            }
            else if (Prioridade == 1)
            {
                stringPrioridade = "BAIXA";
            }

            return stringPrioridade;
        }
    }
}
