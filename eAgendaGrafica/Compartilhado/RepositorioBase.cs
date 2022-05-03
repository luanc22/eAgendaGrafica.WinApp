using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace eAgendaGrafica.Compartilhado
{
    [Serializable]

    public class RepositorioBase<T> where T : EntidadeBase
    {
        protected List<T> listaRegistros;
        protected int contador;

        public virtual void Inserir(T entidade) {}

        public virtual void Editar(T entidade) {}

        public virtual void Excluir(T entidade) {}

        public List<T> CarregarRegistrosDoArquivo(string arquivos)
        {
            if (File.Exists(arquivos) == false)
            {
                return new List<T>();
            }

            BinaryFormatter serializador = new BinaryFormatter();

            byte[] bytesRegistros = File.ReadAllBytes(arquivos);

            MemoryStream ms = new MemoryStream(bytesRegistros);

            return (List<T>)serializador.Deserialize(ms);
        }
    }
}
