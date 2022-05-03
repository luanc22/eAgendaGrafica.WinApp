using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using eAgendaGrafica.Compartilhado;

namespace eAgendaGrafica.Modulos.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        private const string eCompromisso = @"C:\Windows\temp\eCompromisso.bin";
        private int cont = 0;
        List<Compromisso> listaCompromissos;

        public RepositorioCompromisso()
        {
            listaRegistros = CarregarRegistrosDoArquivo(eCompromisso);
            cont = listaRegistros.Count;
        }

        public override void Inserir(Compromisso compromisso)
        {
            compromisso.ID = ++cont;
            listaRegistros.Add(compromisso);
            GravarRegistrosEmArquivo();
        }

        public override void Editar(Compromisso compromisso)
        {
            foreach (var cadastro in listaRegistros)
            {
                if (cadastro.ID == compromisso.ID)
                {
                    cadastro.Local = compromisso.Local;
                    cadastro.Assunto = compromisso.Assunto;
                    cadastro.NomeContato = compromisso.NomeContato;
                    cadastro.Dia = compromisso.Dia;
                    cadastro.Mes = compromisso.Mes;
                    cadastro.HoraInicio = compromisso.HoraInicio;
                    cadastro.HoraFim = compromisso.HoraFim;
                    break;
                }
            }
            GravarRegistrosEmArquivo();
        }

        public override void Excluir(Compromisso compromisso)
        {
            listaRegistros.Remove(compromisso);
            GravarRegistrosEmArquivo();
        }

        public List<Compromisso> SelecionarTodos()
        {
            listaCompromissos = new List<Compromisso>();

            foreach (Compromisso compromisso in listaRegistros)
            {
                listaCompromissos.Add(compromisso);
            }
            return listaCompromissos;
        }

        public void GravarRegistrosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, listaRegistros);

            byte[] bytes = ms.ToArray();

            File.WriteAllBytes(eCompromisso, ms.ToArray());
        }
    }
}
