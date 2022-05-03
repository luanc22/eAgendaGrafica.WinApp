using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgendaGrafica.Modulos.ModuloTarefa
{
    [Serializable]

    public class Item
    {
        private string _nome;
        private bool _conclusao;

        public string Nome { get => _nome; set => _nome = value; }
        public bool Conclusao { get => _conclusao; set => _conclusao = value; }

        public override string ToString()
        {
            return Nome;
        }

        public void Completo()
        {
            Conclusao = true;
        }

        internal void NaoCompleto()
        {
            Conclusao = false;
        }
    }
}
