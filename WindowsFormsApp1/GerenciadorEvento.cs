using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GerenciadorEvento
    {
        private readonly List<ISala> listaSalas;
        public List<Pessoas> ListaPessoas { get; set; }

        public GerenciadorEvento()
        {
            listaSalas = new List<ISala>();
            ListaPessoas = new List<Pessoas>();
        }

        public void GarantirDiferencaDePessoasPorSala()
        {
            if (listaSalas.Count() == 0)
                return;

            int quantidadeSalaComMaisPessoas = listaSalas[0].GetQuantidadePessoas();

            for (int i = 1; i < listaSalas.Count(); i++)
            {
                int diferenca = listaSalas[i].GetQuantidadePessoas() - quantidadeSalaComMaisPessoas;

                if (quantidadeSalaComMaisPessoas < listaSalas[i].GetQuantidadePessoas())
                    quantidadeSalaComMaisPessoas = listaSalas[i].GetQuantidadePessoas();

                if (diferenca < -1 || diferenca > 1)
                    throw new Exception("A diferença de quantidade de pessoas por sala não pode ser maior que 1");
            }
        }

        public void AdicionarSala(ISala sala)
        {
            if (sala == null)
                throw new Exception("Essa sala não é válida");

            listaSalas.Add(sala);
        }

        public void Adicionar()
        {
            GerenciadorEvento gerenciador = new GerenciadorEvento();

            Sala sala = new Sala(10);

            Pessoas pessoa = new Pessoas();
            pessoa.Nome = "Miguel";

            Sala sala2 = new Sala(10);

            Pessoas pessoa2 = new Pessoas();
            pessoa2.Nome = "Luis";
            Pessoas pessoa3 = new Pessoas();
            pessoa3.Nome = "Maria";

            sala2.AdicionarPessoa(pessoa2);
            sala2.AdicionarPessoa(pessoa3);

            gerenciador.AdicionarSala(sala);
            gerenciador.AdicionarSala(sala2);
        }
    }
}
