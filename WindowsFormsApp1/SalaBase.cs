using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SalaBase : ISala
    {
        protected int lotacaoMaxima;
        private readonly List<Pessoas> listaPessoas;

        public SalaBase(int lotacaoMaxima)
        {
            this.lotacaoMaxima = lotacaoMaxima;
            listaPessoas = new List<Pessoas>();
        }

        public void AdicionarPessoa(Pessoas pessoa)
        {
            if (pessoa == null)
                throw new Exception("Essa pessoa é inválida.");

            listaPessoas.Add(pessoa);
        }

        public List<Pessoas> GetListaPessoas()
        {
            return listaPessoas;
        }

        public int GetLotacaoMaxima()
        {
            return lotacaoMaxima;
        }

        public int GetQuantidadePessoas()
        {
            return listaPessoas.Count();
        }
    }
}
