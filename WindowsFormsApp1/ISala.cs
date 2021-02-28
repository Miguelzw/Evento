using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface ISala
    {
        int GetLotacaoMaxima();
        int GetQuantidadePessoas();
        List<Pessoas> GetListaPessoas();
        void AdicionarPessoa(Pessoas pessoa);
    }
}
