using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using eAgendaGrafica.Compartilhado;

namespace eAgendaGrafica.Modulos.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        private const string eContato = @"C:\Windows\temp\eContato.bin";
        private int cont = 0;
        List<Contato> listaContato;

        public RepositorioContato()
        {
            listaRegistros = CarregarRegistrosDoArquivo(eContato);
            cont = listaRegistros.Count;
        }

        public override void Inserir(Contato contato)
        {
            contato.ID = ++cont;
            listaRegistros.Add(contato);
            GravarRegistrosEmArquivo();
        }

        public override void Editar(Contato contato)
        {
            foreach (var cadastro in listaRegistros)
            {
                if (cadastro.ID == contato.ID)
                {
                    cadastro.Nome = contato.Nome;
                    cadastro.Email = contato.Email;       
                    cadastro.Empresa = contato.Empresa;
                    cadastro.Cargo = contato.Cargo;
                    cadastro.Telefone = contato.Telefone;
                    break;
                }
            }
            GravarRegistrosEmArquivo();
        }

        public void Compromisso(string nome)
        {
            foreach (var item in listaRegistros)
            {
                if (item.Nome == nome)
                {
                    item.Compromisso = true;
                    break;
                }
            }
            GravarRegistrosEmArquivo();
        }

        public override void Excluir(Contato contato)
        {
            listaRegistros.Remove(contato);
            GravarRegistrosEmArquivo();
        }

        public List<Contato> SelecionarTodos()
        {
            listaContato = new List<Contato>();

            foreach (Contato contato in listaRegistros)
            {
                listaContato.Add(contato);
            }
            return listaContato;
        }

        public void GravarRegistrosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, listaRegistros);

            byte[] bytes = ms.ToArray();

            File.WriteAllBytes(eContato, ms.ToArray());
        }
    }
}
