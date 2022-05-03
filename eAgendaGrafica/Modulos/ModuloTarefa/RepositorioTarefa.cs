using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using eAgendaGrafica.Compartilhado;

namespace eAgendaGrafica.Modulos.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        private const string eTarefa = @"C:\Windows\temp\eTarefa.bin";
        private int cont = 0;
        List<Tarefa> listaTarefas;

        public RepositorioTarefa()
        {
            listaRegistros = CarregarRegistrosDoArquivo(eTarefa);
            cont = listaRegistros.Count;
        }

        public override void Inserir(Tarefa tarefa)
        {
            tarefa.ID = ++cont;
            listaRegistros.Add(tarefa);
            GravarRegistrosEmArquivo();
        }

        public override void Editar(Tarefa tarefa)
        {
            foreach (var cadastro in listaRegistros)
            {
                if (cadastro.ID == tarefa.ID)
                {
                    cadastro.Titulo = tarefa.Titulo;
                    break;
                }
            }
            GravarRegistrosEmArquivo();
        }

        public override void Excluir(Tarefa tarefa)
        {
            listaRegistros.Remove(tarefa);
            GravarRegistrosEmArquivo();
        }

        public List<Tarefa> SelecionarTodos()
        {
            listaTarefas = new List<Tarefa>();

            foreach (Tarefa tarefa in listaRegistros)
            {
                listaTarefas.Add(tarefa);
            }
            return listaTarefas;
        }

        public void AdicionarItens(Tarefa tarefa, List<Item> itens)
        {
            foreach (var item in itens)
            {
                tarefa.AdicionarItem(item);
            }
            GravarRegistrosEmArquivo();
        }

        public void AtualizarItens(Tarefa tarefa, List<Item> itensFinalizados, List<Item> itensNaoFinalizados)
        {
            foreach (var item in itensFinalizados)
            {
                tarefa.ConcluirItem(item);
            }

            foreach (var item in itensNaoFinalizados)
            {
                tarefa.NaoCompleto(item);
            }
            GravarRegistrosEmArquivo();
        }

        public void GravarRegistrosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, listaRegistros);

            byte[] bytes = ms.ToArray();

            File.WriteAllBytes(eTarefa, ms.ToArray());
        }
    }
}
