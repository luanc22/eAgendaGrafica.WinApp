using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgendaGrafica.Compartilhado;

namespace eAgendaGrafica.Modulos.ModuloContato
{
    [Serializable]

    public class Contato : EntidadeBase
    {
        private string _nome;
        private string _email;
        private string _empresa;
        private string _cargo;
        private int _telefone;
        private bool _compromisso;

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Empresa { get => _empresa; set => _empresa = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }
        public int Telefone { get => _telefone; set => _telefone = value; }
        public bool Compromisso { get => _compromisso; set => _compromisso = value; }

        public override string ToString()
        {
            return
                "ID: " + ID + Environment.NewLine +
                " / Nome: " + Nome + Environment.NewLine +
                " / Email: " + Email + Environment.NewLine +
                " / Empresa: " + Empresa + Environment.NewLine +
                " / Cargo: " + Cargo + Environment.NewLine +
                " / Telefone: " + Telefone + Environment.NewLine;
        }
    }
}
