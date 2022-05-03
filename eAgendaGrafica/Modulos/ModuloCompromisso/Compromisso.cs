using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgendaGrafica.Compartilhado;
using eAgendaGrafica.Modulos.ModuloContato;

namespace eAgendaGrafica.Modulos.ModuloCompromisso
{
    [Serializable]

    public class Compromisso : EntidadeBase
    {
        private string _assunto;
        private string _local;
        private string _nomeContato;
        private int _dia;
        private int _mes;
        private int _horaInicio;
        private int _horaFim;
        private Contato contato;
        
        public string Assunto { get => _assunto; set => _assunto = value; }
        public string Local { get => _local; set => _local = value; }
        public string NomeContato { get => _nomeContato; set => _nomeContato = value; }
        public int Dia { get => _dia; set => _dia = value; }
        public int Mes { get => _mes; set => _mes = value; }
        public int HoraInicio { get => _horaInicio; set => _horaInicio = value; }
        public int HoraFim { get => _horaFim; set => _horaFim = value; }
        public Contato Contato { get => contato; set => contato = value; }

        public override string ToString()
        {
            return 
                "ID: " + ID + Environment.NewLine +
                " / Assunto: " + Assunto + Environment.NewLine +
                " / Local: " + Local + Environment.NewLine +
                " / Contato: " + NomeContato + Environment.NewLine +
                " / Hora de Inicio: " + HoraInicio + Environment.NewLine +
                " / Hora de Termino: " + HoraFim + Environment.NewLine;
        }
    }
}
